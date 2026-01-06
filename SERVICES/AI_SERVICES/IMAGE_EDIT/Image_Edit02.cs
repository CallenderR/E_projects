using E_APP02.MODELS.AI_MODEL.AI_GET_MODEL;
using E_APP02.MODELS.AI_MODEL.AI_SET_MODEL;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;

//https://rapidapi.com/ailabapi-ailabapi-default/api/hairstyle-changer-pro/playground/apiendpoint_e671cca8-1b40-414e-b2a8-0bccd9612b24

namespace E_APP02.SERVICES.AI_SERVICES.IMAGE_EDIT
{
    internal class Image_Edit02
    {
        private static readonly HttpClient client = new HttpClient();
        public static List<Ai_Set_Model01> collectiondata01 = new List<Ai_Set_Model01>();
        private   string[] data01 = new string[100];
        private   List<string> request_id = new List<string>();
        private   List<string> log_id = new List<string>();
        private   List<int> error_code = new List<int>();
        private   List<string> error_code_str = new List<string>();
        private   List<string> error_msg = new List<string>();
        private   List<int> status_code = new List<int>();
        private   List<string> code = new List<string>();
        private   List<string> code_message = new List<string>();
        private   List<string> message = new List<string>();
        private   List<string> task_type = new List<string>();
        private   List<string> task_id = new List<string>();
        public static  List<string> hair_color = new List<string>();
        public static  List<string> hair_type = new List<string>();
        private   List<string> hair_color_code = new List<string>();
        private   List<string> hair_type_code = new List<string>();

        private static Read_Textfiles01 READ = new Read_Textfiles01();
        private  string[] Headers_ ={ "x-rapidapi-key",READ.api[0].Trim(),
                                            "x-rapidapi-host","hairstyle-changer-pro.p.rapidapi.com"};


        public Image_Edit02()
        {
            load_hairstyle_using_textfile();

        }

        public async Task<string> Hairstyle_Changer_Pro(string input, string input01, string input02)
        {
            data01[4] = hair_type_code[int.Parse(input.Trim())];
            data01[5] = hair_color_code[int.Parse(input01.Trim())]; 
            data01[6] = input02;
            data01[7] = await Ai_data01($"https://hairstyle-changer-pro.p.rapidapi.com/facebody/editing/hairstyle-pro", data01[4].Trim(), data01[5].Trim(), data01[6].Trim());

            //  return $"{data01[4]}\n,{data01[5]}\n{data01[6]}\n";
            return data01[7];

        }
        private async Task<string> Ai_data01(string input, string input01, string input02, string input03)
        {
            try
            {
                var filePath = input03.Trim();
                var bytes = File.ReadAllBytes(filePath);
                var multipart = new MultipartFormDataContent
{
    { new ByteArrayContent(bytes)
    { Headers = { ContentType = MediaTypeHeaderValue.Parse("image/jpeg") } }, "image", "face.jpg" },
    { new StringContent(input01), "hair_style" },
    { new StringContent(input02), "color" }
};

                var request = new HttpRequestMessage(HttpMethod.Post, input);
                request.Headers.Add(Headers_[0], Headers_[1]);
                request.Headers.Add(Headers_[2], Headers_[3]);
                request.Content = multipart;
                var response = await client.SendAsync(request);
                string body = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<Ai_Model03.Root>(body);
                if (results != null)
                {
                    request_id.Add(results.request_id);
                    log_id.Add(results.log_id);
                    error_code.Add(results.error_code);
                    error_code_str.Add(results.error_code_str);
                    error_msg.Add(results.error_msg);
                    status_code.Add(results.error_detail.status_code);
                    code.Add(results.error_detail.code);
                    message.Add(results.error_detail.message);
                    task_type.Add(results.task_type);
                    task_id.Add(results.task_id);
                }
                else
                {
                    request_id.Add("");
                    log_id.Add("");
                    error_code.Add(0);
                    error_code_str.Add("");
                    error_msg.Add("");
                    status_code.Add(0);
                    code.Add("");
                    message.Add("");
                    task_type.Add("");
                    task_id.Add("");

                }
                var collection_set = new Ai_Set_Model01
                {


                    Request_id = request_id.Count > 0 ? request_id[0] : null,
                    Log_id = log_id.Count > 0 ? log_id[0] : null,
                    Error_code = error_code.Count > 0 ? error_code[0] : 0,
                    Error_code_str = error_code_str.Count > 0 ? error_code_str[0] : null,
                    Error_msg = error_msg.Count > 0 ? error_msg[0] : null,
                    Status_code = status_code.Count > 0 ? status_code[0] : 0,
                    Code = code.Count > 0 ? code[0] : null,
                    Message = message.Count > 0 ? message[0] : null,
                    Task_type = task_type.Count > 0 ? task_type[0] : null,
                    Task_id = task_id.Count > 0 ? task_id[0] : null,
                };
                collectiondata01.Add(collection_set);
                data01[0] =
                    $"{string.Join(" ", request_id)}\n" +
                    $"{string.Join(" ", log_id)}\n" +
                    $"{string.Join(" ", error_code)}\n" +
                    $"{string.Join(" ", error_code_str)}\n" +
                    $"{string.Join(" ", error_msg)}\n" +
                    $"{string.Join(" ", status_code)}\n" +
                    $"{string.Join(" ", code)}\n" +
                    $"{string.Join(" ", message)}\n" +
                    $"{string.Join(" ", task_type)}\n" +
                    $"{string.Join(" ", task_id)}\n";

            }
            catch (Exception ex)
            {
                data01[0] = ex.Message;
            }
            return data01[0];
        }
        private void load_hairstyle_using_textfile()
        {
            hair_type.Clear();
            hair_type_code.Clear();
            hair_color.Clear();
            hair_color_code.Clear();

            for (int i = 0; i < READ.hairstyle_info_01.Length; i++)
            {
                string[] resaults = READ.hairstyle_info_01[i].Split(":");
                if (i % 2 == 0)
                {

                    hair_type.Add(resaults[0]);

                }
                else if (i % 2 == 1)
                {
                    hair_type_code.Add(resaults[1]);
                }

            }
            for (int i = 0; i < READ.hairstyle_info_02.Length; i++)
            {
                string[] resaults = READ.hairstyle_info_02[i].Split(":");
                if (i % 2 == 0)
                {

                    hair_color.Add(resaults[0]);

                }
                else if (i % 2 == 1)
                {
                    hair_color_code.Add(resaults[1]);
                }

            }

        }
        public string find_hairstyle_using_textfile(string input)
        {
            input = input.Trim();

            if (hair_type.Contains(input))
            {
                int index = hair_type.IndexOf(input);
                return hair_type_code[index];
            }


            // Not found
            return string.Empty;
        }

        public string find_haircolor_using_textfile(string input)
        {
            input = input.Trim();


            if (hair_color.Contains(input))
            {
                int index = hair_color.IndexOf(input);
                return hair_color_code[index];
            }


            // Not found
            return string.Empty;
        }
        public string print_hairtype_using_textfile()
        {

            for (int i = 0; i < hair_type_code.Count; i++)
            {
                data01[2] += $"{hair_type_code[i]}\n";
            }

            return data01[2];
        }
        public string print_haircolor_using_textfile()
        {

            for (int i = 0; i < hair_color_code.Count; i++)
            {
                data01[3] += $"{hair_color_code[i]}\n";
            }

            return data01[3];
        }
    }
}

