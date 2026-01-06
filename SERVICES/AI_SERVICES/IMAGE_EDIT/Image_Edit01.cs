using E_APP02.MODELS.AI_MODEL.AI_GET_MODEL;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace E_APP02.SERVICES.AI_SERVICES.IMAGE_EDIT
{
    internal class Image_Edit01 
    {
        private  string[] data01 = new string[100];
        private  List<string> image_url = new List<string>();
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        public async Task<string> PhotoAnime(string input)
        {
            //input=url image
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://photo-anime.p.rapidapi.com/RapidPhotoAnime"),
                Headers =
    {
        { "x-rapidapi-key", READ.api[0].Trim() },
        { "x-rapidapi-host", "photo-anime.p.rapidapi.com" },
    },
                Content = new StringContent(
                    $"{{\"url\":\"{input.Trim()}\",\"type\":\"anime\",\"mask_id\":1}}",
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
                Ai_Model02.Root resaults = JsonConvert.DeserializeObject<Ai_Model02.Root>(body);
                if (resaults.image_url != null)
                {
                    image_url.Add(resaults.image_url);
                }
                else
                {
                    image_url.Add(" ");
                }



                data01[0] += $"{image_url[0]}\n";
            }
            return data01[0];
        }
    }
}
