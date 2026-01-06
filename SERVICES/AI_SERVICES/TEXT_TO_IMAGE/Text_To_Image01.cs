using E_APP02.FILE_PATH;
using E_APP02.MODEL.AI_MODEL.AI_GET_MODEL;
using E_APP02.MODELS.AI_MODEL.AI_GET_MODEL;
using E_APP02.SERVICES.FILE_SERVICES.PYTHONE_FILES;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace E_APP02.SERVICES.AI_SERVICES.TEXT_TO_IMAGE
{
    internal class Text_To_Image01
    {
        private static Read_Python01 C_Sharp_To_Python_Serv = new Read_Python01();
        private  List<int> code = new List<int>();
        private  List<string> message = new List<string>();
        private  List<string> prompt_id = new List<string>();
        private  List<string> status = new List<string>();
        private  List<int> index = new List<int>();
        private  List<string> prompt_status = new List<string>();
        private  List<int> index01 = new List<int>();
        private  List<bool> nsfw = new List<bool>();
        private  List<string> origin = new List<string>();
        private  List<string> thumb = new List<string>();
        private  string[] data01 = new string[100];
        private static Read_Textfiles01 READ = new Read_Textfiles01();

        public async Task<string> AI_Text_to_image_Generator_Flux_Free(string input)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://ai-text-to-image-generator-flux-free-api.p.rapidapi.com/aaaaaaaaaaaaaaaaaiimagegenerator/quick.php"),
                Headers =
    {
        { "x-rapidapi-key",READ.api[0].Trim() },
        { "x-rapidapi-host", "ai-text-to-image-generator-flux-free-api.p.rapidapi.com" },
    },
                Content = new StringContent(
    $"{{\"prompt\":\"{input}\",\"style_id\":4,\"size\":\"1-1\"}}",
    Encoding.UTF8,
    "application/json"
)

                {
                    Headers =
        {
            ContentType = new MediaTypeHeaderValue("application/json")
        }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                AI_Text_to_image_Generator_Flux_Free_Model.Root resaults = JsonConvert.DeserializeObject<AI_Text_to_image_Generator_Flux_Free_Model.Root>(body);

                code.Add(resaults.code);
                message.Add(resaults.message);
                prompt_id.Add(resaults.result.data.prompt_id);
                status.Add(resaults.result.data.queue_info.status);
                index.Add(resaults.result.data.queue_info.index);
                prompt_status.Add(resaults.result.data.queue_info.prompt_status);
                for (int i = 0; i < resaults.result.data.results.Count; i++)
                {
                    index01.Add(resaults.result.data.results[i].index);
                    nsfw.Add(resaults.result.data.results[i].nsfw);
                    origin.Add(resaults.result.data.results[i].origin);
                    thumb.Add(resaults.result.data.results[i].thumb);
                }

                data01[0] += $"{string.Join(" ", code)}\n" +
                             $"{string.Join(" ", message)}\n" +
                             $"{string.Join(" ", prompt_id)}\n" +
                             $"{string.Join(" ", status)}\n" +
                             $"{string.Join(" ", index)}\n" +
                             $"{string.Join(" ", prompt_status)}\n" +
                             $"{string.Join(" ", index01)}\n" +
                             $"{string.Join(" ", nsfw)}\n" +
                             $"{string.Join(" ", origin)}\n" +
                             $"{string.Join(" ", thumb)}\n";

                data01[1] += $"{origin[0]}";


                data01[2] = body.ToString();

                return data01[1];


            }
        }
        public string image_to_text01(string input)
        {
            data01[3] = C_Sharp_To_Python_Serv.RunTextToImage(input);
            return data01[3];
        }
        public string text_to_image01(string input)
        {

            data01[4] = C_Sharp_To_Python_Serv.RunTextToImage(input);
            return data01[4];
        }
        public async Task<string> text_to_image02(string input)
        {
            data01[5] =  C_Sharp_To_Python_Serv.RunTextToImage01(input);
            return data01[5];
        }
        public async Task<string> text_to_image03(string input)
        {
            var runner = new Read_Python01();

            string resultJson = await runner.RunTextToImage03(new Ai_Model11
            {
                prompt = input,
                steps = 35
            });

            dynamic result = JsonConvert.DeserializeObject(resultJson);

            string finalPath = C_Sharp_To_Python_Serv.MoveImageToAppFolder((string)result.path);

            data01[6]=($"Image saved at: {finalPath}");
            return data01[6];
        }
    }
}
