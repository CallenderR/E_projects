using E_APP02.MODEL.AI_MODEL.AI_GET_MODEL;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using Newtonsoft.Json;
using System.Net.Http.Headers;
//https://rapidapi.com/ai-engine-ai-engine-default/api/phototoanime1/playground/apiendpoint_e423fd8e-6041-455f-9e12-641a71c22505
namespace E_APP02.SERVICES.AI_SERVICES.IMAGE_EDIT
{
    internal class Image_Edit05
    {
        private  string[] data01 = new string[100];
        private  List<int> statusCode = new List<int>();
        private  List<string> imageUrl = new List<string>();
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        private  string[] Headers_array = { "x-rapidapi-key", READ.api[0].Trim(),
                                                 "x-rapidapi-host", "phototoanime1.p.rapidapi.com"};
        public static string[] data_array01 = { "face2paint", "paprika", "webtoon" };

        public async Task<string> photo_to_anime(string input01, int input02)
        {
            data01[2] = await resaults("https://phototoanime1.p.rapidapi.com/photo-to-anime", input01, input02);
            //      data01[1] = $"{input01},{input02}\n";
            return data01[2];
        }
        private async Task<string> resaults(string input01, string input02, int input03)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add(Headers_array[0], Headers_array[1]);
            client.DefaultRequestHeaders.Add(Headers_array[2], Headers_array[3]);
            using var form = new MultipartFormDataContent();
            var imageBytes = await File.ReadAllBytesAsync(input02);
            var imageContent = new ByteArrayContent(imageBytes);
            imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
            form.Add(imageContent,"image",Path.GetFileName(input02));
            form.Add(new StringContent(data_array01[input03]),"style");
            using var response = await client.PostAsync(input01, form);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Ai_Model10.Root results =JsonConvert.DeserializeObject<Ai_Model10.Root>(body);

            if (results != null)
            {
                statusCode.Add(results.statusCode);
                imageUrl.Add(results.body.imageUrl);
            }
            else
            {
                statusCode.Add(0);
                imageUrl.Add(" ");
            }

            data01[0] =
                $"Status Code: {string.Join(",", statusCode)}\n" +
                $"imageUrl: {string.Join(",", imageUrl)}\n";

            data01[1] =$"{string.Join(",", imageUrl)}\n";

            return data01[1];
        }
    }
}