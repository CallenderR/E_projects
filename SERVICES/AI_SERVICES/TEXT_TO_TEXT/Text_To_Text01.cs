
using E_APP02.SERVICES.FILE_SERVICES.EXTERNAL_FILES;
using E_APP02.SERVICES.FILE_SERVICES.FILE_HELPER;
using LLama;
using LLama.Common;

//https://platform.openai.com/docs/overview 
//https://huggingface.co/models
namespace E_APP02.SERVICES.AI_SERVICES.TEXT_TO_TEXT
{
    internal class Text_To_Text01
    {
        private  string[] data01 = new string[100];
        private static File_Helper01 File_H01 = new File_Helper01();
        public async Task<string> text_generation(string input)
        {
            //  data01[1] = await text_to_text_generator01(input);
            data01[1] = await text_to_text_generator02(input);

            return data01[1];
        }

        private async Task<string> text_to_text_generator01(string input)
        {
            int index = 1;
            string[] model01 = File_H01.all_embedded_gguf_models().Split("\n");
            string file01 = model01[index].Trim();
            string fileName = string.Join(".",
                              model01[index].Split('.').TakeLast(2));


            string modelPath = await Extract_Embedded_Resource01.ExtractEmbeddedResourceAsync(file01, fileName);
            var parameters = new ModelParams(modelPath)
            {
                ContextSize = 512,
                GpuLayerCount = 0 // Use CPU only
            };
            using var model = LLamaWeights.LoadFromFile(parameters);
            using var context = model.CreateContext(parameters);
            var executor = new InteractiveExecutor(context);
            var session = new ChatSession(executor);
            var inferenceParams = new InferenceParams
            {
                MaxTokens = 128,

            };
            var userMessage = new ChatHistory.Message(AuthorRole.User, input);
            await foreach (var token in session.ChatAsync(userMessage, inferenceParams, CancellationToken.None))
            {
                data01[0] += (token);
            }

            return data01[0];
        }

        private async Task<string> text_to_text_generator02(string input)
        {
            int index = 0;
            string[] models = File_H01.all_text_to_text_gguf_models();
            string modelPath = models[index].Trim();

            // Estimate needed context size: input length + buffer (say 50% extra)
            int estimatedInputTokens = Math.Max(32, input.Length / 4); // rough estimate: 1 token ~ 4 chars
            uint contextSize = (uint)Math.Min(4096, estimatedInputTokens + 128); // don't exceed model max

            // Estimate output size: 2x input length (or max 1024)
            int maxTokens = Math.Min(1024, estimatedInputTokens * 2);

            var parameters = new ModelParams(modelPath)
            {
                ContextSize = contextSize,
                GpuLayerCount = 0 // CPU
            };

            using var model = LLamaWeights.LoadFromFile(parameters);
            using var context = model.CreateContext(parameters);

            var inferenceParams = new InferenceParams
            {
                MaxTokens = maxTokens

            };

            data01[0] = "";
            var executor = new InteractiveExecutor(context);
            await foreach (var token in executor.InferAsync(input, inferenceParams, CancellationToken.None))
            {
                data01[0] += token;
            }

            return data01[0];
        }
        public async Task<string> text_to_text_translate01(string input,string input01, string input02)
        {
            int index = 0;
            string[] models = File_H01.all_text_to_text_gguf_models();
            string modelPath = models[index].Trim();



            string prompt =
        $@"Translate the following text from {input.ToUpper().Trim()} to {input01.ToUpper().Trim()}.
        and only output the translated text.       
        Text: ""{input02}""";




            // Estimate needed context size: input length + buffer (say 50% extra)
            int estimatedInputTokens = Math.Max(32, prompt.Length / 4); // rough estimate: 1 token ~ 4 chars
            uint contextSize = (uint)Math.Min(4096, estimatedInputTokens + 128); // don't exceed model max

            // Estimate output size: 2x input length (or max 1024)
            int maxTokens = Math.Min(1024, estimatedInputTokens * 2);

            var parameters = new ModelParams(modelPath)
            {
                ContextSize = contextSize,
                GpuLayerCount = 0 // CPU
            };

            using var model = LLamaWeights.LoadFromFile(parameters);
            using var context = model.CreateContext(parameters);

            var inferenceParams = new InferenceParams
            {
                MaxTokens = maxTokens

            };

            data01[0] = "";
            var executor = new InteractiveExecutor(context);
            await foreach (var token in executor.InferAsync(prompt, inferenceParams, CancellationToken.None))
            {
                data01[0] += token;
            }

            return data01[0];
        }
    }
}
