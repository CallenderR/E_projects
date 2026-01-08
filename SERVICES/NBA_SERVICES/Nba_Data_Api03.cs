using E_APP02.MODELS.NBA_MODEL.NBA_GET_MODEL.NBA_GET_MODEL02;
using E_APP02.MODELS.NBA_MODEL.NBA_SET_MODEL.NBA_GET_MODEL04;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using Newtonsoft.Json;

//https://rapidapi.com/Creativesdev/api/nba-api-free-data/playground/apiendpoint_f5030852-9b5b-4c3d-b7c2-2aecd8fb46dc
//needs work has an index issue
namespace E_APP02.SERVICES.NBA_SERVICES
{
    internal class Nba_Data_Api03
    {
        private static string[] data01 = new string[100];
        private static  HttpClient client = new HttpClient();
        private  List<string> id = new List<string>();
        private  List<string> language = new List<string>();
        private  List<string> rel01 = new List<string>();
        private  List<string> href01 = new List<string>();
        private  List<string> text = new List<string>();
        private  List<string> shortText = new List<string>();
        private  List<bool> isExternal = new List<bool>();
        private  List<bool> isPremium = new List<bool>();
        private  List<string> href02 = new List<string>();
        private  List<int> width = new List<int>();
        private  List<int> height = new List<int>();
        private  List<string> alt = new List<string>();
        private  List<string> re02l = new List<string>();
        private  List<string> lastUpdated = new List<string>();
        private  List<string> referee = new List<string>();
        private  List<string> guid = new List<string>();
        private  List<string> uid = new List<string>();
        private  List<string?> name = new List<string?>();
        private  List<string> displayName = new List<string>();
        private  List<string> slug = new List<string>();
        private  List<string> status = new List<string>();
        private  List<string> logoDark = new List<string>();
        private  List<object> seasonType = new List<object>();
        private  List<int?> year = new List<int?>();
        private  List<string> startDate = new List<string>();
        private  List<string> endDate = new List<string>();
        private  List<string> gender = new List<string>();
        private  List<string> shortName = new List<string>();
        private  List<string> abbreviation = new List<string>();
        private  List<bool> isTournament = new List<bool>();
        private  List<string> isTournament01 = new List<string>();
        private  List<string> rel = new List<string>();
        private  List<string> href = new List<string>();
        private  List<string> width01 = new List<string>();
        private  List<string> height01 = new List<string>();
        private static  Read_Textfiles01 READ = new Read_Textfiles01();
        private static  string[] Headers = { "x-rapidapi-key", $"{READ.api[0]}",
                                         "x-rapidapi-host", "nba-api-free-data.p.rapidapi.com" };
        public  List<Nba_Set_Model04> collectiondata04 = new List<Nba_Set_Model04>();
        public  List<Nba_Set_Model05> collectiondata05 = new List<Nba_Set_Model05>();
        public async Task<string> NBA_League_Info()
        {


            data01[4] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-leagues");


            return data01[4];
        }
        public  async Task<string> NBA_Sport_Info()
        {


            data01[5] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-sports");


            return data01[5];
        }
        public  async Task<string> Seasons_Get_Seasons_Types_List()
        {


            data01[6] = await nba_data02("https://nba-api-free-data.p.rapidapi.com/nba-seasons-types-list");


            return data01[6];
        }
        public  async Task<string> Seasons_Get_Current_Season_Year()
        {


            data01[7] = await nba_data02("https://nba-api-free-data.p.rapidapi.com/nba-current-season-year");

            return data01[7];
        }
        public  async Task<string> Seasons_Get_Current_Season()
        {


            data01[8] = await nba_data03("https://nba-api-free-data.p.rapidapi.com/nba-current-seasons");

            return data01[8];
        }


        public  async Task<string> Seasons_Get_Seasons_Year_List()
        {


            data01[9] = await nba_data04("https://nba-api-free-data.p.rapidapi.com/nba-season-year-list");

            return data01[9];
        }
        public  async Task<string> Seasons_Get_Seasons_List()
        {


            data01[10] = await nba_data03("https://nba-api-free-data.p.rapidapi.com/nba-seasons-list");

            return data01[10];
        }




        public  async Task<string> Leagues_Get_Info()
        {


            data01[11] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-leagues");

            return data01[11];
        }



        public  async Task<string> Scoreboard_Get_by_Date()
        {


            data01[12] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-scoreboard-by-date?date=20250120");

            return data01[12];
        }

        public  async Task<string> Schedule_Get_by_Date()
        {


            data01[13] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-schedule-by-date?date=20250123");

            return data01[13];
        }
        public  async Task<string> Standings_Conference_Standings()
        {


            data01[14] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-conference-standings?year=2023");

            return data01[14];
        }
        public  async Task<string> Standings_Division_Standings()
        {


            data01[15] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-division-standings?year=2023");

            return data01[15];
        }


        public  async Task<string> Standings_League_Standings()
        {


            data01[16] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-league-standings?year=2024");

            return data01[16];
        }




        public  async Task<string> Player_All_List()
        {


            data01[17] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-player-list?teamid=13");

            return data01[17];
        }

        public  async Task<string> Player_Info()
        {


            data01[18] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-player-info?playerid=4869342");

            return data01[18];
        }
        public  async Task<string> Player_Image()
        {


            data01[19] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-player-image?playerid=4869342");

            return data01[19];
        }

        public  async Task<string> Player_Status()
        {


            data01[20] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-player-status?playerid=4869342");

            return data01[20];
        }
        public  async Task<string> Player_Team()
        {
            data01[21] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-player-team?playerid=4869342");
            return data01[21];
        }
        public  async Task<string> Player_Tickets_Info()
        {


            data01[22] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-player-ticketsinfo?playerid=4869342");
            return data01[22];
        }

        public  async Task<string> Player_Videos()
        {


            data01[23] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-player-videos?playerid=4869342");
            return data01[23];
        }


        public  async Task<string> Player_Links()
        {


            data01[24] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-player-links?playerid=4869342");
            return data01[24];
        }


        public  async Task<string> Player_Season()
        {


            data01[25] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-player-season?playerid=4869342");
            return data01[25];
        }
        public  async Task<string> Player_Splits()
        {


            data01[26] = await nba_data01("https://nba-api-free-data.p.rapidapi.com/nba-player-splits?playerid=4869342");
            return data01[26];
        }

        private  async Task<string> nba_data01(string input01)
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
                try
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    Nba_Model01.Root result = JsonConvert.DeserializeObject<Nba_Model01.Root>(body);

                    if (result != null)
                    {
                        status.Add(result.status);
                        id.Add(result.response.id);
                        guid.Add(result.response.guid);
                        uid.Add(result.response.uid);
                        name.Add(result.response.name);
                        displayName.Add(result.response.displayName);
                        abbreviation.Add(result.response.abbreviation);
                        shortName.Add(result.response.shortName);
                        slug.Add(result.response.slug);
                        isTournament.Add(result.response.isTournament);
                        gender.Add(result.response.gender);
                        if (result.response.logos != null)
                        {
                            foreach (var a in result.response.logos)
                            {
                                href.Add(a.href);
                                width.Add(a.width);
                                height.Add(a.height);
                                alt.Add(a.alt);



                                if (a.rel != null)
                                {
                                    foreach (var b in a.rel)
                                    {
                                        rel.Add(b);
                                    }
                                }
                                else
                                {
                                    rel.Add("");
                                }

                                lastUpdated.Add(a.lastUpdated);

                            }

                        }
                        else
                        {
                            href.Add("");
                            width.Add(0);
                            height.Add(0);
                            alt.Add("");
                            lastUpdated.Add("");
                        }
                    }
                    else
                    {
                        status.Add(" ");
                        id.Add(" ");
                        guid.Add(" ");
                        uid.Add(" ");
                        name.Add(" ");
                        displayName.Add(" ");
                        abbreviation.Add(" ");
                        shortName.Add(" ");
                        slug.Add(" ");
                        isTournament.Add(false);
                        gender.Add(" ");
                    }

                    int minCount = new[]
                    {

            href.Count,
                width.Count,
                height.Count,
                alt.Count,
                         rel.Count,

                lastUpdated.Count,

                    status.Count,
                    id.Count,
                    guid.Count,
                    uid.Count,
                    name.Count,
                    displayName.Count,
                    abbreviation.Count,
                    shortName.Count,
                    slug.Count,
                    isTournament.Count,
                    gender.Count,

        }.Min();

                    for (int i = 0; i < minCount; i++)
                    {
                        data01[0] +=

                $"href: {href[i]}\n" +
                $"width: {width[i]}\n" +
                $"height: {height[i]}\n" +
                $"alt: {alt[i]}\n" +
                $"rel: {rel[i]}\n" +
                $"lastUpdated: {lastUpdated[i]}\n" +
                $"status: {status[i]}\n" +
                $"id: {id[i]}\n" +
                $"guid: {guid[i]}\n" +
                $"uid: {uid[i]}\n" +
                $"name: {name[i]}\n" +
                $"displayName: {displayName[i]}\n" +
                $"abbreviation: {abbreviation[i]}\n" +
                $"shortName: {shortName[i]}\n" +
                $"slug: {slug[i]}\n" +
                $"isTournament: {isTournament[i]}\n" +
                $"gender: {gender[i]}\n";
                        var nba_set_model03 = new Nba_Set_Model03
                        {
                            href = href[i],
                            width = width01[i],
                            height = height01[i],
                            alt = alt[i],
                            rel = rel[i],
                            lastUpdated = lastUpdated[i],
                            status = status[i],
                            id = id[i],
                            guid = guid[i],
                            uid = uid[i],
                            name = name[i],
                            displayName = displayName[i],
                            abbreviation = abbreviation[i],
                            shortName = shortName[i],
                            slug = slug[i],
                            isTournament = isTournament01[i],
                        };
                    }
                }
                catch (Exception ex)
                {
                    data01[0] = ex.Message;
                }
                return data01[0];
            }
        }

        private  async Task<string> nba_data02(string input01)
        {
            try
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
                    Nba_Model04.Root result = JsonConvert.DeserializeObject<Nba_Model04.Root>(body);

                    if (result != null)
                    {
                        status.Add(result.status);
                        if (result.response.years != null)
                        {
                            foreach (var a in result.response.years)
                            {
                                year.Add(a);
                            }
                            var nba_set_model01 = new Nba_Set_Model04
                            {
                                years = year[0],
                                status = status[0],
                            };
                    //        collectiondata04.Add(nba_set_model01);
                        }
                        else
                        {
                            year.Add(0);
                        }

                    }
                    else
                    {
                        status.Add("");
                    }

                    int minCount = new[]
                    {
                       year.Count,
                       status.Count,
                }.Min();
                    for (int i = 0; i < minCount; i++)
                    {
                        data01[1] +=
                                     $"year: {year[i]}\n" +
                                     $"status: {status[i]}\n";
                    }

                }
            }
            catch (Exception ex)
            {
                data01[1] = ex.Message;
                
            }
            return data01[1];
        }
        private  async Task<string> nba_data03(string input01)
        {
            try
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
                    Nba_Model03.Root result = JsonConvert.DeserializeObject<Nba_Model03.Root>(body);
                    if (result != null)
                    {
                        status.Add(result.status);
                        year.Add(result.response.season.year);
                        startDate.Add(result.response.season.startDate);
                        endDate.Add(result.response.season.endDate);
                        displayName.Add(result.response.season.displayName);

                        var nba_set_model01 = new Nba_Set_Model05
                        {
                            year = year[0],
                            startDate = startDate[0],
                            endDate = endDate[0],
                            displayName = displayName[0],
                            status = status[0],
                        };
                    //    collectiondata05.Add(nba_set_model01);
                    }
                    else
                    {
                        status.Add("");
                        year.Add(0);
                        startDate.Add("");
                        endDate.Add("");
                        displayName.Add("");

                    }
                    int minCount = new[]
                    {      year.Count,
                       startDate.Count,
                       endDate.Count,
                       displayName.Count,
                       status.Count,
                }.Min();
                    for (int i = 0; i < minCount; i++)
                    {
                        data01[2] +=
                                     $"year: {year[i]}\n" +
                                     $"startDate: {startDate[i]}\n" +
                                     $"endDate: {endDate[i]}\n" +
                                     $"displayName: {displayName[i]}\n" +
                                     $"status: {status[i]}\n";
                    }
               
                }
            }
            catch (Exception ex)
            {
                data01[2] = ex.Message;
                
            }
            return data01[2];
        }

        private  async Task<string> nba_data04(string input01)
        {
            try
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
                    Nba_Model04.Root result = JsonConvert.DeserializeObject<Nba_Model04.Root>(body);

                    if (result != null)
                    {
                        status.Add(result.status);
                        year.AddRange(result.response.years);
                        var nba_set_model01 = new Nba_Set_Model04
                        {
                            years = year[0],
                            status = status[0],
                        };
                        //collectiondata04.Add(nba_set_model01);
                    }
                    else
                    {
                        status.Add("");
                        year.Add(0);
                    }
                    data01[3] = body.ToString();
                }
         
            }
            catch (Exception ex)
            {
                data01[3] = ex.Message;
              
            }
            return data01[3];
        }
    }
}