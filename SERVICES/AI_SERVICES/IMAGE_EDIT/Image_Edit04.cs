using E_APP02.MODEL.AI_MODEL.AI_GET_MODEL;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;

//https://rapidapi.com/whitegf/api/faceswap-pro/playground/apiendpoint_79424603-440f-44b4-80e6-7e15659c8813
namespace E_APP02.SERVICES.AI_SERVICES.IMAGE_EDIT
{
    internal class Image_Edit04
    {
        private  string[] data01 = new string[100];
        private  List<string> status = new List<string>();
        private  List<string> base64 = new List<string>();
        private  List<string> request_id = new List<string>();
        private static  Read_Textfiles01 READ = new Read_Textfiles01();
        private  string[] Headers_array = { "x-rapidapi-key", READ.api[0].Trim(),
                                                 "x-rapidapi-host", "faceswap-pro.p.rapidapi.com" };
        public async Task<string> Result(string[] input01)
        {

            data01[2] =await face_swap_data01(input01);

            return data01[2];
        }

        private async Task<string> face_swap_data01(string[] input)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://faceswap-pro.p.rapidapi.com/getResult.php?request_id={face_swap_data02(input).Result.Trim()}"),
                Headers =
    {
        { Headers_array[0], Headers_array[1]},
        { Headers_array[2], Headers_array[3]},
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Ai_Model09.Root resaults = JsonConvert.DeserializeObject<Ai_Model09.Root>(body);
                if (resaults != null)
                {
                    status.Add(resaults.status);
                    base64.Add(resaults.base64);

                }
                else
                {
                    status.Add(" ");
                    base64.Add(" ");

                }
                data01[1] = $"{string.Join(",", status)}\n" +
                            $"{string.Join(",", base64)}\n";


                data01[2] = $"{string.Join(",", base64)}\n";
                return data01[2];
            }
        }
        private async Task<string> face_swap_data02(string[] input)
        {
  
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://faceswap-pro.p.rapidapi.com/upload.php"),
                Headers =
    {
      { Headers_array[0], Headers_array[1]},
        { Headers_array[2], Headers_array[3]},
    },
                Content = new MultipartFormDataContent
    {
        new StringContent(input[0].Trim())
        {
            Headers =
            {
                ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "target_image_file",
                }
            }
        },
        new StringContent(input[1].Trim())
        {
            Headers =
            {
                ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "target_face_file",
                }
            }
        },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Ai_Model09.Root resaults = JsonConvert.DeserializeObject<Ai_Model09.Root>(body);
                if (resaults != null)
                {
                    status.Add(resaults.status);
                    request_id.Add(resaults.request_id);

                }
                else
                {
                    status.Add(" ");
                    request_id.Add(" ");

                }
                data01[0] = $"{string.Join(",", status)}\n" +
                            $"{string.Join(",", request_id)}\n";
                data01[1] =
            $"{string.Join(",", request_id)}\n";
                return data01[1];
            }
        }
    }
}