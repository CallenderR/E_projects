using E_APP02.SERVICES.FILE_SERVICES.EXTERNAL_FILES;
using NAudio.Wave;
using System.Security;
using System.Speech.Synthesis;
using Whisper.net;

namespace E_APP02.SERVICES.AI_SERVICES.SPEACH_TO_TEXT
{
    internal class Speach_to_Text01
    {
        private  string[] data01 = new string[100];
        private static List<SegmentData> segments = new List<SegmentData>();
        private static MemoryStream memoryStream = new MemoryStream();



        public  async Task<string> Convert_Speach_to_Text(string input)
        {

            Read_External_File01.modelStream01[0].CopyTo(memoryStream);
            memoryStream.Position = 0;

            using var model = WhisperFactory.FromBuffer(memoryStream.ToArray())
                                            .CreateBuilder()
                                            .WithLanguage("en")
                                            .Build();

            // Convert audio to 16KHz WAV
            using var audio16k = ConvertTo16kHz(input);
            await foreach (var segment in model.ProcessAsync(audio16k))
            {
                segments.Add(segment);
            }
            data01[0] = $"{segments.Count.ToString()}\n" +
                 $"{string.Join(" ", segments.Select(s => s.Text))}";

            return data01[0];
        }
        private  MemoryStream ConvertTo16kHz(string inputFile)
        {
            using var reader = new AudioFileReader(inputFile);  
            var outFormat = new WaveFormat(16000, 16, 1); // 16 kHz, 16-bit, mono
            using var resampler = new MediaFoundationResampler(reader, outFormat)
            {
                ResamplerQuality = 60
            };
            var outputStream = new MemoryStream();
            WaveFileWriter.WriteWavFileToStream(outputStream, resampler);
            outputStream.Position = 0;  
            return outputStream;
        }

        public async Task text_to_voice01(string input)
        {

            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                // Volume: 0 - 100
                synth.Volume = 100;

                // Rate: -10 (slow) to 10 (fast)
                synth.Rate = 1;

                synth.Speak(input);
            }
        }
        public async Task text_to_voice02(string input)
        {

            await Task.Run(() =>
            {
                using (SpeechSynthesizer synth = new SpeechSynthesizer())
                {
                    synth.Volume = 100;
                    synth.Rate = 5;

                    // Select a deep male voice
                    foreach (var voice in synth.GetInstalledVoices())
                    {
                        if (voice.VoiceInfo.Gender == VoiceGender.Male &&
                            voice.VoiceInfo.Culture.Name.StartsWith("en"))
                        {
                            synth.SelectVoice(voice.VoiceInfo.Name);
                            break;
                        }
                    }

                    // Escape the input so it’s valid XML
                    string escapedInput = SecurityElement.Escape(input);

                    string ssml = $@"
<speak version='1.0' xml:lang='en-US'>
    <prosody rate='slow' pitch='-2st'>
        {escapedInput}
    </prosody>
</speak>";

                    synth.SpeakSsml(ssml);
                }
            });
        }

        public async Task convert_text_to_voice01(string input)
        {
            using var audio = new AudioFileReader(input);
            using var output = new WaveOutEvent();
            output.Init(audio);
            output.Play();


        }

    }
}