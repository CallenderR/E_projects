using E_APP02.MODEL.NBA_MODEL.NBA_GET_MODEL.NBA_GET_MODEL03;
using E_APP02.MODEL.NBA_MODEL.NBA_SET_MODEL.NBA_SET_MODEL02;
using E_APP02.MODELS.NBA_MODEL.NBA_SET_MODEL.NBA_SET_MODEL02;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using Newtonsoft.Json;

//https://rapidapi.com/api-sports/api/api-nba/playground/apiendpoint_fc80e633-f956-40e2-b139-0bb28254e3f0
//need to finish adding variables.
namespace E_APP02.SERVICES.NBA_SERVICES
{
    internal class Nba_Data_Api02
    {
        private static string[] data01 = new string[100];
        private readonly HttpClient client = new HttpClient();
        private List<string> get = new List<string>();
        private List<object> parameters = new List<object>();
        private List<object> errors = new List<object>();
        private List<int> results = new List<int>();
        private List<string> response01 = new List<string>();

        private List<string> date = new List<string>();
        private List<int> id = new List<int>();
        private List<string> league = new List<string>();
        private List<int> season = new List<int>();
        private List<int> stage = new List<int>();
        private List<string> officials = new List<string>();
        private List<int> timesTied = new List<int>();
        private List<int> leadChanges = new List<int>();
        private List<object> nugget = new List<object>();
        private List<object> clock = new List<object>();
        private List<bool> halftime = new List<bool>();
        private List<int> @short = new List<int>();
        private List<string> @long = new List<string>();
        private List<int> current = new List<int>();
        private List<int> total = new List<int>();
        private List<int> endOfPeriod = new List<int>();
        private List<string> name = new List<string>();
        private List<string> city = new List<string>();
        private List<string> state = new List<string>();
        private List<string> country = new List<string>();
        private List<int> id01 = new List<int>();
        private List<string> name01 = new List<string>();
        private List<string> nickname = new List<string>();
        private List<string> code = new List<string>();
        private List<string> logo = new List<string>();
        private List<int> win = new List<int>();
        private List<int> loss = new List<int>();

        public List<string> linescore = new List<string>();
        private List<int> points = new List<int>();

        private List<int> win01 = new List<int>();
        private List<int> loss01 = new List<int>();
        private List<int> id02 = new List<int>();
        private List<string> name02 = new List<string>();
        private List<string> nickname01 = new List<string>();
        private List<string> code01 = new List<string>();
        private List<string> logo01 = new List<string>();
        private List<int> win02 = new List<int>();
        private List<int> loss02 = new List<int>();
        private List<int> win03 = new List<int>();
        private List<int> loss03 = new List<int>();
        private List<string> linescore01 = new List<string>();
        private List<int> points01 = new List<int>();
        private List<int> id03 = new List<int>();
        private List<string> name03 = new List<string>();
        private List<string> nickname02 = new List<string>();
        private List<string> code03 = new List<string>();
        private List<string> logo03 = new List<string>();
        private List<int> win04 = new List<int>();
        private List<int> loss04 = new List<int>();
        private List<string> linescore02 = new List<string>();
        private List<int> points02 = new List<int>();
        private List<int> win05 = new List<int>();
        private List<int> loss05 = new List<int>();
        private List<string> officials01 = new List<string>();
        private List<int> timesTied01 = new List<int>();
        private List<int> leadChanges01 = new List<int>();
        private List<object> nugget01 = new List<object>();

        public List<Nba_Set_Model01> collectiondata01 = new List<Nba_Set_Model01>();
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        private string[] Headers = { "x-rapidapi-key", $"{READ.api[0]}",
                                      "x-rapidapi-host","api-nba-v1.p.rapidapi.com" };
        public async Task<string> Leagues()
        {
            data01[1] += await nba_data01($"https://api-nba-v1.p.rapidapi.com/leagues");

            return data01[1];
        }
        public async Task<string> Games(string input)
        {
            data01[1] += await nba_data02($"https://api-nba-v1.p.rapidapi.com/games?date={input}");

            return data01[1];
        }
        private async Task<string> nba_data01(string input01)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input01),
                Headers =
    {
        { Headers[0].Trim(), Headers[1].Trim()},
        { Headers[2].Trim(), Headers[3].Trim()},
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Nba_Model01.Root resaults = JsonConvert.DeserializeObject<Nba_Model01.Root>(body);
                if (resaults != null)
                {
                    get.Add(resaults.get);
                    parameters.Add(resaults.parameters != null ? string.Join(", ", resaults.parameters) : "");
                    errors.Add(resaults.errors != null ? string.Join(", ", resaults.errors) : "");
                    response01.Add(resaults.response != null ? string.Join(", ", resaults.response) : "");
                    results.Add(resaults.results);
                    var collection_set = new Nba_set_Model01
                    {
                        get = resaults.get,
                        parameters = resaults.parameters,
                        errors = resaults.errors,
                        results = resaults.results,
                        response = resaults.response

                    };

                    int minCount = new[]
                     {      get.Count,
                            parameters.Count,
                            errors.Count,
                            results.Count,
                            response01.Count
                   }.Min();
                    for (int i = 0; i < minCount; i++)
                    {
                        data01[0] += $"get: {get[i]}\n" +
                                     $"Parameters: {parameters[i]}\n" +
                                     $"Errors: {errors[i]}\n" +
                                     $"Results: {results[i]}\n" +
                                     $"Response: {response01[i]}\n\n";
                    }
                }
                else
                {
                    get.Add("null");
                    parameters.Add("null");
                    errors.Add("null");
                    results.Add(0);
                    response01.Add("null");

                }

                return data01[0];
            }

        }
        private async Task<string> nba_data02(string input01)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input01),
                Headers =
    {
        { Headers[0].Trim(), Headers[1].Trim()},
        { Headers[2].Trim(), Headers[3].Trim()},
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Nba_Model02.Root resaults = JsonConvert.DeserializeObject<Nba_Model02.Root>(body);
                if (resaults != null)
                {
                    get.Add(resaults.get);
                    date.Add(resaults.parameters.date);
                    errors.Add(resaults.errors != null ? string.Join(", ", resaults.errors) : "");
                    results.Add(resaults.results);
                    foreach (var item in resaults.response)
                    {
                        id.Add(item.id);
                        league.Add(item.league);
                        season.Add(item.season);
                        stage.Add(item.stage);
                        officials.Add(item.officials != null ? string.Join(", ", item.officials) : "");
                        timesTied.Add(item.timesTied);
                        leadChanges.Add(item.leadChanges);
                        nugget.Add(item.nugget != null ? string.Join(", ", item.nugget) : "");

                        int minCount = new[]
                        {      get.Count,
                            date.Count,
                            errors.Count,
                            results.Count,
                            id.Count,
                            league.Count,
                            season.Count,
                            stage.Count,
                            officials.Count,
                            timesTied.Count,
                            leadChanges.Count,
                            nugget.Count
                    }.Min();
                        for (int i = 0; i < minCount; i++)
                        {
                            data01[2] += $"get: {get[i]}\n" +
                                         $"Date: {date[i]}\n" +
                                         $"Errors: {errors[i]}\n" +
                                         $"Results: {results[i]}\n" +
                                         $"ID: {id[i]}\n" +
                                         $"League: {league[i]}\n" +
                                         $"Season: {season[i]}\n" +
                                         $"Stage: {stage[i]}\n" +
                                         $"Officials: {officials[i]}\n" +
                                         $"Times Tied: {timesTied[i]}\n" +
                                         $"Lead Changes: {leadChanges[i]}\n" +
                                         $"Nugget: {nugget[i]}\n\n";
                        }
                    }
                }

                else
                {

                }

                return data01[2];
            }
        }
    }
}



