using E_APP02.MODELS.LANGUAGE_MODEL;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using E_APP02.SERVICES.SECURITY_SERVICES;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_LANGUAGE;
using E_APP02.TEMPLATE.TEXTS;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using E_APP02.SERVICES.AI_SERVICES.TEXT_TO_TEXT;
//https://rapidapi.com/robust-api-robust-api-default/api/google-translate113/playground/apiendpoint_a13bd40a-5212-4f25-b997-f8bb30db6e5f
namespace E_APP02.SERVICES.LANGUAGE_SERVICES
{
    internal class Language_Services01
    {

        private  string[] data01 = new string[100];
        private  List<string> trans = new List<string>();
        private  List<string> source_language_code = new List<string>();
        private  List<string> source_language = new List<string>();
        private  List<int> trust_level = new List<int>();
        private  List<string> code = new List<string>();
        private  List<string> language = new List<string>();
        private  List<string> source_lang = new List<string>();
        private  List<int> trust_level01 = new List<int>();
        private  List<string> source_lang_code = new List<string>();
        private  List<string> lowercase01 = new List<string>();
        private  List<string> lowercase02 = new List<string>();
        private  Sql_Services01 Sql_Serv04 = new Sql_Services01();
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        private static Text_To_Text01 Text_To_T01=new Text_To_Text01();     
        public static string[] data_array01 = { "Tranlate Text", "select language" };
        public Language_Services01()
        {
            update_language_sql();
            update_language_sqlite();
        }
        public async Task<string> Tranlate_Text(string input01, string input02)
        {

            //input01= language apprivation en,vi,fr,jp,cn
            //input02= text need to translate
            string detct_lang = await Detect_Language(input02);
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/text"),
                    Headers =
    {
        { "x-rapidapi-key",  READ.api[0].Trim()},
        { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
    },
                    Content = new StringContent($"{{\"from\":\"{detct_lang}\",\"to\":\"{pick_languge_using_text_file(input01).Trim()}\",\"text\":\"{input02}\"}}", Encoding.UTF8, "application/json")

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
                    Language_Model01.Root resaults = JsonConvert.DeserializeObject<Language_Model01.Root>(body);

                    if (resaults != null)
                    {
                        trans.Add(resaults.trans);
                        source_language_code.Add(resaults.source_language_code);
                        source_language.Add(resaults.source_language);
                        trust_level.Add(resaults.trust_level);
                    }
                    else
                    {
                        trans.Add(" ");
                        source_language_code.Add(" ");
                        source_language.Add(" ");
                        trust_level.Add(0);
                    }

                    /* data01[3] = $"{string.Join(" ", trans)}\n" +
                                 $"{string.Join(" ", source_language_code)}\n" +
                                 $" {string.Join(" ", source_language)}\n" +
                                 $"{string.Join(" ", trust_level)}";*/

                    data01[3] = $"{string.Join(" ", trans)}\n";
                }
            }
            catch (Exception ex)
            {
                data01[3] = $"{ex}\n";


            }


            return data01[3];
        }

        public async Task<string> Tranlate_Text01(int input01, string input02)
        {

            //input01= language apprivation en,vi,fr,jp,cn
            //input02= text need to translate
            string detct_lang = await Detect_Language(input02);
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/text"),
                    Headers =
    {
        { "x-rapidapi-key",  READ.api[0].Trim()},
        { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
    },
                    Content = new StringContent($"{{\"from\":\"{detct_lang}\",\"to\":\"{READ.language_abbreviation[input01].Trim().ToLower()}\",\"text\":\"{input02}\"}}", Encoding.UTF8, "application/json")

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
                    Language_Model01.Root resaults = JsonConvert.DeserializeObject<Language_Model01.Root>(body);

                    if (resaults != null)
                    {
                        trans.Add(resaults.trans);
                        source_language_code.Add(resaults.source_language_code);
                        source_language.Add(resaults.source_language);
                        trust_level.Add(resaults.trust_level);
                    }
                    else
                    {
                        trans.Add(" ");
                        source_language_code.Add(" ");
                        source_language.Add(" ");
                        trust_level.Add(0);
                    }

                    /* data01[3] = $"{string.Join(" ", trans)}\n" +
                                 $"{string.Join(" ", source_language_code)}\n" +
                                 $" {string.Join(" ", source_language)}\n" +
                                 $"{string.Join(" ", trust_level)}";*/

                    data01[3] = $"{string.Join(" ", trans)}\n";
                }
            }
            catch (Exception ex)
            {
                data01[3] = $"{ex}\n";


            }


            return data01[3];
        }


        public async Task<string> Batch_Translation()//needs work
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/json"),
                Headers =
    {
        { "x-rapidapi-key",  READ.api[0] },
        { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
    },
                Content = new StringContent("{\"from\":\"auto\",\"to\":\"vi\",\"protected_paths\":[\"extra.last_comment.author\"],\"common_protected_paths\":[\"image\"],\"json\":[\"Batch Translation\",\"Mutiple Text\"]}")
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
                data01[0] = body;
                return data01[0];
            }
        }



        public async Task<string> Translate_JSON()
        {
            object jsonToTranslate = "";
            string targetLang = "vi";
            var client = new HttpClient();

            var bodyObject = new
            {
                from = "auto",
                to = targetLang,
                protected_paths = new[] { "extra.last_comment.author" },
                common_protected_paths = new[] { "image" },
                json = jsonToTranslate
            };
            string jsonPayload = JsonConvert.SerializeObject(bodyObject);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/json"),
                Headers =
        {
            { "x-rapidapi-key", READ.api[0] },
            { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
        },
                Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json")
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                data01[0] = body;
            }

            return data01[0];
        }
        public async Task<string> Translate_HTML()//idk what this does
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/html"),
                Headers =
    {
        { "x-rapidapi-key", READ.api[0]},
        { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
    },
                Content = new StringContent("{\"from\":\"en\",\"to\":\"vi\",\"html\":\"<ul><li>Hello</li><li>This is Translate HTML endpoint</li></ul>\"}")
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
                data01[0] = body;

            }
            return data01[0];
        }

        private async Task<string> Detect_Language(string input)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/detect-language"),
                Headers =
        {
            { "x-rapidapi-key", READ.api[0].Trim() },
            { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
        },
                Content = new StringContent($"{{\"text\":\"{input.Trim()}\"}}", Encoding.UTF8, "application/json")
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Language_Model03.Root resaults = JsonConvert.DeserializeObject<Language_Model03.Root>(body);
                source_lang.Add(resaults.source_lang);
                trust_level01.Add(resaults.trust_level);
                source_lang_code.Add(resaults.source_lang_code);
                data01[0] = $"{string.Join(" ", source_lang)}\n" +
                            $"{string.Join(" ", trust_level01)}\n" +
                            $"{string.Join(" ", source_lang_code)}";
                data01[1] = source_lang_code[0];
                return data01[1];
            }
        }
        private async Task<string> Supported_languages()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/support-languages"),
                Headers =
    {
        { "x-rapidapi-key", READ.api[0] },
        { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                List<Language_Model02.Root> resaults = JsonConvert.DeserializeObject<List<Language_Model02.Root>>(body);

                foreach (var a in resaults)
                {
                    code.Add(a.code);
                    language.Add(a.language);
                }
                data01[0] = $"{string.Join(" ", code)}\n" +
                            $"{string.Join(" ", language)}";

                return data01[0];
            }


        }
        public string pick_languge_using_text_file(string input)
        {
            string lowerInput = input.Trim().ToLower();
            for (int i = 0; i < READ.language_name.Length; i++)
            {
                lowercase01.Add(READ.language_name[i].Trim().ToLower());
                lowercase02.Add(READ.language_abbreviation[i].Trim().ToLower());
            }

            if (lowercase01.Contains(lowerInput))
            {
                int index = lowercase01.IndexOf(lowerInput);
                return lowercase01[index];
            }
            else if (lowercase02.Contains(lowerInput))
            {
                int index = lowercase01.IndexOf(lowerInput);
                return lowercase01[index];
            }
            else if (Security_Services01.string_only_digit(lowerInput))
            {
                int inputIndex = int.Parse(lowerInput);
                if (inputIndex >= 0 && inputIndex < lowercase01.Count)
                {
                    return lowercase01[inputIndex];
                }
            }

            return Default_Text01.text02[0];

        }
        private void update_language_sql()
        {

            update_languge_using_text_file();
            for (int i = 0; i < code.Count; i++)
            {
                data01[0] += Sql_Serv04.insert_language(language[i], code[i]);
            }
        }
        private void update_language_sqlite()
        {
            update_languge_using_text_file();
            for (int i = 0; i < code.Count; i++)
            {
                data01[0] += Sql_Serv04.insert_language(language[i], code[i]);
            }      
        }
        private string test()
        {

            update_languge_using_text_file();
            data01[0] += $"{string.Join("\n", code)}\n" +
                        $"{string.Join("\n", language)}\n" +
                        $"code {code.Count}" +
                        $"language {language.Count}";
            return data01[0];
        }
        private void update_languge_using_text_file()
        {
            for (int i = 0; i < READ.language_abbreviation.Length; i++)
            {
                code.Add(READ.language_abbreviation[i]);
            }
            for (int i = 0; i < READ.language_name.Length; i++)
            {
                language.Add(READ.language_name[i]);
            }

        }
        public string pick_language_using_sql(string input) //needs work 
        {

            data01[0] = Sql_Serv04.find_code_using_code(input);

            //     data01[0] = Sql_Serv04.find_code_using_language(input);

            return data01[0];
        }
        public async Task< string> Translate_using_Ai(int input, string input01)
        {       
            string select_lang = READ.language_abbreviation[input].Trim().ToLower();
            string detct_lang = await Detect_Language(input01);
            data01[0] =await Text_To_T01.text_to_text_translate01(detct_lang.Trim(), select_lang.Trim(), input01.Trim());
            return data01[0];
        }
    }
}