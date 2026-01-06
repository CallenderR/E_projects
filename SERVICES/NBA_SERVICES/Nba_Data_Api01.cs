using E_APP02.MODELS.NBA_MODEL.NBA_GET_MODEL.NBA_GET_MODEL01;
using E_APP02.MODELS.NBA_MODEL.NBA_SET_MODEL.NBA_SET_MODEL01;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_NBA;
using E_APP02.TEMPLATE.TEXTS;
using Newtonsoft.Json;
namespace E_APP02.SERVICES.NBA_SERVICES
{
    internal class Nba_Data_Api01
    {
        private static string[] data01 = new string[100];
        private  List<int> Season = new List<int>();
        private  List<int> SeasonType = new List<int>();
        private  List<int?> TeamID = new List<int?>();
        private  List<string> Key = new List<string>();
        private  List<string> City = new List<string>();
        private  List<string> Name = new List<string>();
        private  List<string> Conference = new List<string>();
        private  List<string> Division = new List<string>();
        private  List<int> Wins = new List<int>();
        private  List<int> Losses = new List<int>();
        private  List<double> Percentage = new List<double>();
        private  List<int> ConferenceWins = new List<int>();
        private  List<int> ConferenceLosses = new List<int>();
        private  List<int> DivisionWins = new List<int>();
        private  List<int> DivisionLosses = new List<int>();
        private  List<int> HomeWins = new List<int>();
        private  List<int> HomeLosses = new List<int>();
        private  List<int> AwayWins = new List<int>();
        private  List<int> AwayLosses = new List<int>();
        private  List<int> LastTenWins = new List<int>();
        private  List<int> LastTenLosses = new List<int>();
        private  List<double> PointsPerGameFor = new List<double>();
        private  List<double> PointsPerGameAgainst = new List<double>();
        private  List<int> Streak = new List<int>();
        private  List<double> GamesBack = new List<double>();
        private  List<string> StreakDescription = new List<string>();
        private  List<int> GlobalTeamID = new List<int>();
        private  List<int> ConferenceRank = new List<int>();
        private  List<int> DivisionRank = new List<int>();
        private  List<int> PlayerID = new List<int>();
        private  List<string> SportsDataID = new List<string>();
        private  List<string> Status = new List<string>();
        private  List<string> Team = new List<string>();
        private  List<string> Jersey = new List<string>();
        private  List<string> PositionCategory = new List<string>();
        private  List<object> Position = new List<object>();
        private  List<string> FirstName = new List<string>();
        private  List<string> LastName = new List<string>();
        private  List<DateTime?> BirthDate = new List<DateTime?>();
        private  List<string> BirthCity = new List<string>();
        private  List<string> BirthState = new List<string>();
        private  List<string> BirthCountry = new List<string>();
        private  List<string> Height = new List<string>();
        private  List<string> Weight = new List<string>();
        private  List<bool?> Active = new List<bool?>();
        private  List<int> LeagueID = new List<int>();
        private  List<int?> StadiumID = new List<int?>();
        private  List<string> PrimaryColor = new List<string>();
        private  List<string> SecondaryColor = new List<string>();
        private  List<string> TertiaryColor = new List<string>();
        private  List<string> QuaternaryColor = new List<string>();
        private  List<string> WikipediaLogoUrl = new List<string>();
        private  List<object> WikipediaWordMarkUrl = new List<object>();
        private  List<int?> NbaDotComTeamID = new List<int?>();
        private  List<string> HeadCoach = new List<string>();
        private  List<int?> RefereeID = new List<int?>();
        private  List<int> Number = new List<int>();
        private  List<string> College = new List<string>();
        private  List<string> Address = new List<string>();
        private  List<string> State = new List<string>();
        private  List<string> Zip = new List<string>();
        private  List<string> Country = new List<string>();
        private  List<int?> Capacity = new List<int?>();
        private  List<double?> GeoLat = new List<double?>();
        private  List<double?> GeoLong = new List<double?>();
        private  List<int?> Experience = new List<int?>();
        private  List<int> RecordId = new List<int>();
        private  List<int> BettingMarketTypeId = new List<int>();
        private  List<int> BettingBetTypeId = new List<int>();
        private  List<int> BettingPeriodTypeId = new List<int>();
        private  List<bool?> Active01 = new List<bool?>();
        private  List<bool?> Active02 = new List<bool?>();
        private  List<bool?> Active03 = new List<bool?>();
        private  List<bool?> Active04 = new List<bool?>();
        private  List<bool?> Active05 = new List<bool?>();
        private  List<string> Name01 = new List<string>();
        private  List<string> Name02 = new List<string>();
        private  List<string> Name03 = new List<string>();
        private  List<string> Name04 = new List<string>();
        private  List<string> Name05 = new List<string>();
        private  List<int> RecordId01 = new List<int>();
        private  List<int> RecordId02 = new List<int>();
        private  List<int> RecordId03 = new List<int>();
        private  List<int> RecordId04 = new List<int>();
        private  List<int> RecordId05 = new List<int>();
        private  List<int> StartYear = new List<int>();
        private  List<int> EndYear = new List<int>();
        private  List<string> Description = new List<string>();
        private  List<DateTime> RegularSeasonStartDate = new List<DateTime>();
        private  List<DateTime> PostSeasonStartDate = new List<DateTime>();
        private  List<string> ApiSeason = new List<string>();
        private  List<string> SeasonType01 = new List<string>();
        private  List<int> SportsbookID = new List<int>();
        private  List<int> GameID = new List<int>();
        private  List<DateTime> Day = new List<DateTime>();
        private  List<DateTime> DateTime = new List<DateTime>();
        private  List<string> AwayTeam = new List<string>();
        private  List<string> HomeTeam = new List<string>();
        private  List<int> AwayTeamID = new List<int>();
        private  List<int> HomeTeamID = new List<int>();
        private  List<string> Channel = new List<string>();
        private  List<int?> Attendance = new List<int?>();
        private  List<int?> AwayTeamScore = new List<int?>();
        private  List<int?> HomeTeamScore = new List<int?>();
        private  List<DateTime> Updated = new List<DateTime>();
        private  List<object> Quarter = new List<object>();
        private  List<object> TimeRemainingMinutes = new List<object>();
        private  List<object> TimeRemainingSeconds = new List<object>();
        private  List<double?> PointSpread = new List<double?>();
        private  List<double?> OverUnder = new List<double?>();
        private  List<int?> AwayTeamMoneyLine = new List<int?>();
        private  List<int?> HomeTeamMoneyLine = new List<int?>();
        private  List<int> GlobalGameID = new List<int>();
        private  List<int> GlobalAwayTeamID = new List<int>();
        private  List<int> GlobalHomeTeamID = new List<int>();
        private  List<int?> PointSpreadAwayTeamMoneyLine = new List<int?>();
        private  List<int?> PointSpreadHomeTeamMoneyLine = new List<int?>();
        private  List<string> LastPlay = new List<string>();
        private  List<bool> IsClosed = new List<bool>();
        private  List<DateTime?> GameEndDateTime = new List<DateTime?>();
        private  List<int?> HomeRotationNumber = new List<int?>();
        private  List<int?> AwayRotationNumber = new List<int?>();
        private  List<bool> NeutralVenue = new List<bool>();
        private  List<int?> OverPayout = new List<int?>();
        private  List<int?> UnderPayout = new List<int?>();
        private  List<int?> CrewChiefID = new List<int?>();
        private  List<int?> UmpireID = new List<int?>();
        private  List<object> AlternateID = new List<object>();
        private  List<DateTime> DateTimeUTC = new List<DateTime>();
        private  List<bool> InseasonTournament = new List<bool>();
        private  List<object> SeriesInfo = new List<object>();
        private  List<object> Quarters = new List<object>();
        private  List<DateTime> GameEndDateTIme = new List<DateTime>();
        private  List<int> SeasonID = new List<int>();
        private  Sql_Services02 Sql_Ser02= new Sql_Services02();
        public List<Nba_Set_Model01> collectiondata01 = new List<Nba_Set_Model01>();
        public List<Nba_Set_Model02> collectiondata02 = new List<Nba_Set_Model02>();
        public List<Nba_Set_Model03> collectiondata03 = new List<Nba_Set_Model03>();
        public List<Nba_Set_Model04> collectiondata04 = new List<Nba_Set_Model04>();
        public List<Nba_Set_Model05> collectiondata05 = new List<Nba_Set_Model05>();
        public List<Nba_Set_Model06> collectiondata06 = new List<Nba_Set_Model06>();
        public List<Nba_Set_Model07> collectiondata07 = new List<Nba_Set_Model07>();
        public List<Nba_Set_Model08> collectiondata08 = new List<Nba_Set_Model08>();
        public List<Nba_Set_Model09> collectiondata09 = new List<Nba_Set_Model09>();
        public List<Nba_Set_Model10> collectiondata10 = new List<Nba_Set_Model10>();
        public List<Nba_Set_Model11> collectiondata11 = new List<Nba_Set_Model11>();
        public List<Nba_Set_Model12> collectiondata12 = new List<Nba_Set_Model12>();
        public List<Nba_Set_Model13> collectiondata13 = new List<Nba_Set_Model13>();

        private static HttpClient client = new HttpClient();
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        public async Task<string> Standings(string input)
        {
            data01[31] = await nba_data01($"https://api.sportsdata.io/v3/nba/scores/json/Standings/{input.Trim()}?key={READ.api[3]}", input);

            return data01[31];
        }
        public async Task<string> Player_Profiles_by_Active()
        {


            data01[32] = await nba_data02($"https://api.sportsdata.io/v3/nba/scores/json/PlayersActiveBasic?key={READ.api[3].Trim()}");

            return data01[32];
        }
        public async Task<string> Player_Profiles_by_Free_Agent()
        {
            data01[33] = await nba_data02($"https://api.sportsdata.io/v3/nba/scores/json/PlayersByFreeAgents?key={READ.api[3].Trim()}");

            return data01[33];
        }
        public async Task<string> Players_Profiles_by_Team(string input)
        {
            //inpout team key phi
            data01[34] = await nba_data02($"https://api.sportsdata.io/v3/nba/scores/json/PlayersBasic/{input}?key={READ.api[3].Trim()}");

            return data01[34];
        }
        public async Task<string> Team_Profiles_All()
        {
            data01[35] = await nba_data03($"https://api.sportsdata.io/v3/nba/scores/json/AllTeams?key={READ.api[3].Trim()}");

            return data01[35];
        }

        public async Task<string> Team_Profiles_by_Active()
        {
            data01[36] = await nba_data03($"https://api.sportsdata.io/v3/nba/scores/json/teams?key={READ.api[3].Trim()}");

            return data01[36];
        }
        public async Task<string> Team_Profiles_by_Season(string input)
        {
            data01[37] = await nba_data03($"https://api.sportsdata.io/v3/nba/scores/json/teams/{input}?key={READ.api[3].Trim()}");

            return data01[37];
        }
        public async Task<string> Referees()
        {
            data01[38] = await nba_data04($"https://api.sportsdata.io/v3/nba/scores/json/Referees?key={READ.api[3].Trim()}");

            return data01[38];
        }

        public async Task<string> Stadiums()
        {
            data01[39] = await nba_data05($"https://api.sportsdata.io/v3/nba/scores/json/Stadiums?key={READ.api[3].Trim()}");

            return data01[39];
        }
        public async Task<string> Are_Games_In_Progress()
        {
            data01[40] = await nba_data06($"https://api.sportsdata.io/v3/nba/scores/json/AreAnyGamesInProgress?key={READ.api[3].Trim()}");

            return data01[40];
        }
        public async Task<string> Betting_Metadata()
        {
            data01[41] = await nba_data07($"https://api.sportsdata.io/v3/nba/odds/json/BettingMetadata?key={READ.api[3].Trim()}");

            return data01[41];
        }
        public async Task<string> Season_Current()
        {
            data01[42] = await nba_data08($"https://api.sportsdata.io/v3/nba/scores/json/CurrentSeason?key={READ.api[3].Trim()}");

            return data01[42];
        }
        public async Task<string> Sportsbooks_by_Active()
        {
            data01[43] = await nba_data09($"https://api.sportsdata.io/v3/nba/odds/json/ActiveSportsbooks?key={READ.api[3].Trim()}");

            return data01[43];
        }
        public async Task<string> Schedules(string input)
        {
            //inpuut year
            data01[44] = await nba_data10($"https://api.sportsdata.io/v3/nba/scores/json/Games/{input}?key={READ.api[3].Trim()}");

            return data01[44];
        }
        public async Task<string> Schedules_Basic(string input)
        {
            data01[45] = await nba_data11($"https://api.sportsdata.io/v3/nba/scores/json/SchedulesBasic/{input}?key={READ.api[3].Trim()}");

            return data01[45];
        }
        public async Task<string> Games_Basic_by_Date_Final(string input)
        {
            data01[46] = await nba_data12($"https://api.sportsdata.io/v3/nba/scores/json/ScoresBasicFinal/{input}?key={READ.api[3].Trim()}");

            return data01[46];
        }

        private async Task<string> nba_data01(string input01, string input)
        {
            System.DateTime dateTime = System.DateTime.Now;
            int year = dateTime.Year;
            try
            {
                if (int.Parse(input) > 1946 && int.Parse(input) < year)
                {

                    HttpResponseMessage response = await client.GetAsync(input01);
                    response.EnsureSuccessStatusCode();
                    string body = await response.Content.ReadAsStringAsync();
                    List<Nba_Model01.Root> resaults = JsonConvert.DeserializeObject<List<Nba_Model01.Root>>(body);
                    if (resaults != null)
                    {
                        foreach (var a in resaults)
                        {
                            Season.Add(a.Season);
                            SeasonType.Add(a.SeasonType);
                            TeamID.Add(a.TeamID);
                            Key.Add(a.Key);
                            City.Add(a.City);
                            Name.Add(a.Name);
                            Conference.Add(a.Conference);
                            Division.Add(a.Division);
                            Wins.Add(a.Wins);
                            Losses.Add(a.Losses);
                            Percentage.Add(a.Percentage);
                            ConferenceWins.Add(a.ConferenceWins);
                            ConferenceLosses.Add(a.ConferenceLosses);
                            DivisionWins.Add(a.DivisionWins);
                            DivisionLosses.Add(a.DivisionLosses);
                            HomeWins.Add(a.HomeWins);
                            HomeLosses.Add(a.HomeLosses);
                            AwayWins.Add(a.AwayWins);
                            AwayLosses.Add(a.AwayLosses);
                            LastTenWins.Add(a.LastTenWins);
                            LastTenLosses.Add(a.LastTenLosses);
                            PointsPerGameFor.Add(a.PointsPerGameFor);
                            PointsPerGameAgainst.Add(a.PointsPerGameAgainst);
                            Streak.Add(a.Streak);
                            GamesBack.Add(a.GamesBack);
                            StreakDescription.Add(a.StreakDescription);
                            GlobalTeamID.Add(a.GlobalTeamID);
                            ConferenceRank.Add(a.ConferenceRank);
                            DivisionRank.Add(a.DivisionRank);







                        }
                    }
                    else
                    {
                        Season.Add(0);
                        SeasonType.Add(0);
                        TeamID.Add(0);
                        Key.Add(" ");
                        City.Add(" ");
                        Name.Add(" ");
                        Conference.Add(" ");
                        Division.Add(" ");
                        Wins.Add(0);
                        Losses.Add(0);
                        Percentage.Add(0);
                        ConferenceWins.Add(0);
                        ConferenceLosses.Add(0);
                        DivisionWins.Add(0);
                        DivisionLosses.Add(0);
                        HomeWins.Add(0);
                        HomeLosses.Add(0);
                        AwayWins.Add(0);
                        AwayLosses.Add(0);
                        LastTenWins.Add(0);
                        LastTenLosses.Add(0);
                        PointsPerGameFor.Add(0);
                        PointsPerGameAgainst.Add(0);
                        Streak.Add(0);
                        GamesBack.Add(0);
                        StreakDescription.Add(" ");
                        GlobalTeamID.Add(0);
                        ConferenceRank.Add(0);
                        DivisionRank.Add(0);
                    }


                    foreach (var a in resaults)
                    {

                        var collection_set = new Nba_Set_Model01
                        {

                            Season = a.Season,
                            SeasonType = a.SeasonType,
                            TeamID = a.TeamID,
                            Key = a.Key,
                            City = a.City,
                            Name = a.Name,
                            Conference = a.Conference,
                            Division = a.Division,
                            Wins = a.Wins,
                            Losses = a.Losses,
                            Percentage = a.Percentage,
                            ConferenceWins = a.ConferenceWins,
                            ConferenceLosses = a.ConferenceLosses,
                            DivisionWins = a.DivisionWins,
                            DivisionLosses = a.DivisionLosses,
                            HomeWins = a.HomeWins,
                            HomeLosses = a.HomeLosses,
                            AwayWins = a.AwayWins,
                            AwayLosses = a.AwayWins,
                            LastTenWins = a.LastTenWins,
                            LastTenLosses = a.LastTenLosses,
                            PointsPerGameFor = a.PointsPerGameFor,
                            PointsPerGameAgainst = a.PointsPerGameAgainst,
                            Streak = a.Streak,
                            GamesBack = a.GamesBack,
                            StreakDescription = a.StreakDescription,
                            GlobalTeamID = a.GlobalTeamID,
                            ConferenceRank = a.ConferenceRank,
                            DivisionRank = a.DivisionRank,

                        };

                        collectiondata01.Add(collection_set);
                    }

                    int minCount = new[]
      {




              Season.Count,
                SeasonType.Count,
                TeamID.Count,
                Key.Count,
                City.Count,
                Name.Count,
                Conference.Count,
                Division.Count,
                Wins.Count,
                Losses.Count,
                Percentage.Count,
                ConferenceWins.Count,
                ConferenceLosses.Count,
                DivisionWins.Count,
                DivisionLosses.Count,
                HomeWins.Count,
                HomeLosses.Count,
                AwayWins.Count,
                AwayLosses.Count,
                LastTenWins.Count,
                LastTenLosses.Count,
                PointsPerGameFor.Count,
                PointsPerGameAgainst.Count,
                Streak.Count,
                GamesBack.Count,
                StreakDescription.Count,
                GlobalTeamID.Count,
                ConferenceRank.Count,
                DivisionRank.Count
            }.Min();
                    for (int i = 0; i < minCount; i++)
                    {
                        data01[0] += $"Season: {Season[i]}\n" +
                                     $"SeasonType: {SeasonType[i]}\n" +
                                     $"TeamID: {TeamID[i]}\n" +
                                     $"Key: {Key[i]}\n" +
                                     $"City: {City[i]}\n" +
                                     $"Name: {Name[i]}\n" +
                        $"Conference: {Conference[i]}\n" +
                        $"Division: {Division[i]}\n" +
                        $"Wins: {Wins[i]}\n" +
                         $"Losses: {Losses[i]}\n" +
                        $"Percentage: {Percentage[i]}\n" +
                        $"ConferenceWins: {ConferenceWins[i]}\n" +
                        $"ConferenceLosses: {ConferenceLosses[i]}\n" +
                        $"DivisionWins: {DivisionWins[i]}\n" +
                        $"DivisionLosses: {DivisionLosses[i]}\n" +
                        $"HomeWins: {HomeWins[i]}\n" +
                         $"HomeLosses: {HomeLosses[i]}\n" +
                        $"AwayWins: {AwayWins[i]}\n" +
                        $"AwayLosses: {AwayLosses[i]}\n" +
                        $"LastTenWins: {LastTenWins[i]}\n" +
                        $"LastTenLosses: {LastTenLosses[i]}\n" +
                        $"PointsPerGameFor: {PointsPerGameFor[i]}\n" +
                        $"PointsPerGameAgainst: {PointsPerGameAgainst[i]}\n" +
                        $"Streak: {Streak[i]}\n" +
                        $"GamesBack: {GamesBack[i]}\n" +
                        $"StreakDescription: {StreakDescription[i]}\n" +
                        $"GlobalTeamID: {GlobalTeamID[i]}\n" +
                        $"ConferenceRank: {ConferenceRank[i]}\n" +
                        $"DivisionRank: {DivisionRank[i]}\n\n\n";



                        data01[1] += Sql_Ser02.insert_team_standings(Season[i].ToString(),
                                                              SeasonType[i].ToString(),
                                                              TeamID[i].ToString(),
                                                              Key[i],
                                                              City[i],
                                                              Name[i],
                                                              Conference[i],
                                                              Division[i],
                                                              Wins[i].ToString(),
                                                              Losses[i].ToString(),
                                                              Percentage[i].ToString(),
                                                              ConferenceWins[i].ToString(),
                                                              ConferenceLosses[i].ToString(),
                                                              DivisionWins[i].ToString(),
                                                              DivisionLosses[i].ToString(),
                                                              HomeWins[i].ToString(),
                                                              HomeLosses[i].ToString(),
                                                              AwayWins[i].ToString(),
                                                              AwayLosses[i].ToString(),
                                                              LastTenWins[i].ToString(),
                                                              LastTenLosses[i].ToString(),
                                                              PointsPerGameFor[i].ToString(),
                                                              PointsPerGameAgainst[i].ToString(),
                                                              Streak[i].ToString(),
                                                              GamesBack[i].ToString(),
                                                              StreakDescription[i],
                                                              GlobalTeamID[i].ToString(),
                                                              ConferenceRank[i].ToString(),
                                                              DivisionRank[i].ToString());

                    }
                }
                else
                {
                    data01[1] = Default_Text01.text02[0];

                }


            }
            catch (Exception ex)
            {
                data01[1] = ex.Message;

            }


            return $"{data01[0]}\n" +
                   $"{data01[1]}";
        }

        private async Task<string> nba_data02(string input01)
        {

            HttpResponseMessage response = await client.GetAsync(input01);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nba_Model02.Root> resaults = JsonConvert.DeserializeObject<List<Nba_Model02.Root>>(body);
            if (resaults != null)
            {
                foreach (var a in resaults)
                {
                    PlayerID.Add(a.PlayerID);
                    SportsDataID.Add(a.SportsDataID);
                    Status.Add(a.Status);
                    TeamID.Add(a.TeamID);
                    Team.Add(a.Team);
                    Jersey.Add(a.Jersey);
                    PositionCategory.Add(a.PositionCategory);
                    Position.Add(a.Position);
                    FirstName.Add(a.FirstName);
                    LastName.Add(a.LastName);
                    BirthDate.Add(a.BirthDate);
                    BirthCity.Add(a.BirthCity);
                    BirthState.Add(a.BirthState);
                    BirthCountry.Add(a.BirthCountry);
                    GlobalTeamID.Add(a.GlobalTeamID);
                    Height.Add(a.Height);
                    Weight.Add(a.Weight);







                }
            }
            else
            {

                PlayerID.Add(0);
                SportsDataID.Add(" ");
                Status.Add(" ");
                TeamID.Add(0);
                Team.Add(" ");
                Jersey.Add(" ");
                PositionCategory.Add(" ");
                Position.Add(" ");
                FirstName.Add(" ");
                LastName.Add(" ");
                BirthDate.Add(null);
                BirthCity.Add(" ");
                BirthState.Add(" ");
                BirthCountry.Add(" ");
                GlobalTeamID.Add(0);
                Height.Add(" ");
                Weight.Add(" ");
            }
            int minCount = new[]
     {




                PlayerID.Count,
            SportsDataID.Count,
            Status.Count,
            TeamID.Count,
            Team.Count,
            Jersey.Count,
            PositionCategory.Count,
            Position.Count,
            FirstName.Count,
            LastName.Count,
            BirthDate.Count,
            BirthCity.Count,
            BirthState.Count,
            BirthCountry.Count,
            GlobalTeamID.Count,
            Height.Count,
            Weight.Count
        }.Min();




            foreach (var a in resaults)
            {

                var collection_set = new Nba_Set_Model02
                {
                    PlayerID = a.PlayerID.ToString(),
                    SportsDataID = a.SportsDataID,
                    Status = a.Status,
                    TeamID = a.TeamID.ToString(),
                    Team = a.Team,
                    Jersey = a.Jersey,
                    PositionCategory = a.PositionCategory,
                    Position = a.Position.ToString(),
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    BirthDate = a.BirthDate.ToString(),
                    BirthCity = a.BirthCity,
                    BirthState = a.BirthState,
                    BirthCountry = a.BirthCountry,
                    GlobalTeamID = a.GlobalTeamID.ToString(),
                    Height = a.Height,
                    Weight = a.Weight,

                };

                collectiondata02.Add(collection_set);
            }

            for (int i = 0; i < minCount; i++)
            {
                data01[2] += $"PlayerID: {PlayerID[i]}\n" +
                          $"SportsDataID: {SportsDataID[i]}\n" +
                $"PlayerID: {Status[i]}\n" +
               $"TeamID: {TeamID[i]}\n" +
               $"Team: {Team[i]}\n" +
               $"Jersey: {Jersey[i]}\n" +
               $"PositionCategory: {PositionCategory[i]}\n" +
               $"Position: {Position[i]}\n" +
               $"FirstName: {FirstName[i]}\n" +
               $"LastName: {LastName[i]}\n" +
                $"BirthDate: {BirthDate[i]}\n" +
               $"BirthCity: {BirthCity[i]}\n" +
               $"BirthState: {BirthState[i]}\n" +
               $"BirthCountry: {BirthCountry[i]}\n" +
               $"GlobalTeamID: {GlobalTeamID[i]}\n" +
               $"Height: {Height[i]}\n" +
               $"Weight: {Weight[i]}\n\n";


                data01[3] += Sql_Ser02.insert_players(PlayerID[i].ToString(),
                                               SportsDataID[i],
                                               Status[i],
                                               TeamID[i].ToString(),
                                               Team[i],
                                               Jersey[i].ToString(),
                                               PositionCategory[i],
                                               Position[i].ToString(),
                                               FirstName[i],
                                               LastName[i],
                                               BirthDate[i].ToString(),
                                               BirthCity[i],
                                               BirthState[i],
                                               BirthCountry[i],
                                               GlobalTeamID[i].ToString(),
                                               Height[i].ToString(),
                                               Weight[i].ToString());





            }
            data01[4] += $"{string.Join(" ", PlayerID)}\n" +
               $"{string.Join(" ", SportsDataID)}\n" +
              $"{string.Join(" ", Status)}\n" +
             $"{string.Join(" ", TeamID)}\n" +
            $"{string.Join(" ", Team)}\n" +
             $"{string.Join(" ", Jersey)}\n" +
               $"{string.Join(" ", PositionCategory)}\n" +
             $"{string.Join(" ", Position)}\n" +
              $"{string.Join(" ", FirstName)}\n" +
              $"{string.Join(" ", LastName)}\n" +
               $"{string.Join(" ", BirthDate)}\n" +
               $"{string.Join(" ", BirthCity)}\n" +
             $"{string.Join(" ", BirthState)}\n" +
              $"{string.Join(" ", BirthCountry)}\n" +
               $"{string.Join(" ", GlobalTeamID)}\n" +
              $"{string.Join(" ", Height)}\n" +
               $"{string.Join(" ", Weight)}\n";
            return $"{data01[2]}\n" +
                   $"{data01[3]}\n" +
                   $"{data01[4]}";
        }
        private async Task<string> nba_data03(string input)//need work
        {


            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nba_Model03.Root> resaults = JsonConvert.DeserializeObject<List<Nba_Model03.Root>>(body);

            if (resaults != null)
            {
                foreach (var a in resaults)
                {
                    TeamID.Add(a.TeamID);
                    Key.Add(a.Key ?? " ");
                    Active.Add(a.Active ?? false);
                    City.Add(a.City ?? " ");
                    Name.Add(a.Name ?? " ");
                    LeagueID.Add(a.LeagueID);
                    StadiumID.Add(a.StadiumID);
                    Conference.Add(a.Conference ?? " ");
                    Division.Add(a.Division ?? " ");
                    PrimaryColor.Add(a.PrimaryColor ?? " ");
                    SecondaryColor.Add(a.SecondaryColor ?? " ");
                    TertiaryColor.Add(a.TertiaryColor ?? " ");
                    QuaternaryColor.Add(a.QuaternaryColor ?? " ");
                    WikipediaLogoUrl.Add(a.WikipediaLogoUrl ?? " ");
                    WikipediaWordMarkUrl.Add(a.WikipediaWordMarkUrl ?? " ");
                    GlobalTeamID.Add(a.GlobalTeamID);
                    NbaDotComTeamID.Add(a.NbaDotComTeamID);
                    HeadCoach.Add(a.HeadCoach ?? " ");

                }

            }
            else
            {
                TeamID.Add(0);
                Key.Add(" ");
                Active.Add(false);
                City.Add(" ");
                Name.Add(" ");
                LeagueID.Add(0);
                StadiumID.Add(0);
                Conference.Add(" ");
                Division.Add(" ");
                PrimaryColor.Add(" ");
                SecondaryColor.Add(" ");
                TertiaryColor.Add(" ");
                QuaternaryColor.Add(" ");
                WikipediaLogoUrl.Add(" ");
                WikipediaWordMarkUrl.Add(" ");
                GlobalTeamID.Add(0);
                NbaDotComTeamID.Add(0);
                HeadCoach.Add(" ");
            }

            foreach (var a in resaults)
            {

                var collection_set = new Nba_Set_Model03
                {
                    TeamID = a.TeamID,
                    Key = a.Key,
                    Active = a.Active,
                    City = a.City,
                    Name = a.Name,
                    LeagueID = a.LeagueID,
                    StadiumID = a.StadiumID,
                    Conference = a.Conference,
                    Division = a.Division,
                    PrimaryColor = a.PrimaryColor,
                    SecondaryColor = a.SecondaryColor,
                    TertiaryColor = a.TertiaryColor,
                    QuaternaryColor = a.QuaternaryColor,
                    WikipediaLogoUrl = a.WikipediaLogoUrl,
                    WikipediaWordMarkUrl = a.WikipediaWordMarkUrl,
                    GlobalTeamID = a.GlobalTeamID,
                    NbaDotComTeamID = a.NbaDotComTeamID,
                    HeadCoach = a.HeadCoach,

                };

                collectiondata03.Add(collection_set);
            }


            int minCount = new[]
    {
            TeamID.Count,
            Key.Count,
            Active.Count,
            City.Count,
            Name.Count,
            LeagueID.Count,
            StadiumID.Count,
            Conference.Count,
            Division.Count,
            PrimaryColor.Count,
            SecondaryColor.Count,
            TertiaryColor.Count,
            QuaternaryColor.Count,
            WikipediaLogoUrl.Count,
            WikipediaWordMarkUrl.Count,
            GlobalTeamID.Count,
            NbaDotComTeamID.Count,
            HeadCoach.Count,
        }.Min();
            for (int i = 0; i < minCount; i++)
            {
                data01[5] += $"TeamID: {TeamID[i]}\n" +
$"Key: {Key[i]}\n" +
$"Active: {Active[i]}\n" +
$"City: {City[i]}\n" +
$"Name: {Name[i]}\n" +
$"LeagueID: {LeagueID[i]}\n" +
$"StadiumID: {StadiumID[i]}\n" +
$"Conference: {Conference[i]}\n" +
$"Division: {Division[i]}\n" +
$"PrimaryColor: {PrimaryColor[i]}\n" +
$"SecondaryColor: {SecondaryColor[i]}\n" +
$"TertiaryColor: {TertiaryColor[i]}\n" +
$"QuaternaryColor: {QuaternaryColor[i]}\n" +
$"WikipediaLogoUrl: {WikipediaLogoUrl[i]}\n" +
$"WikipediaWordMarkUrl: {WikipediaWordMarkUrl[i]}\n" +
$"GlobalTeamID: {GlobalTeamID[i]}\n" +
$"NbaDotComTeamID: {NbaDotComTeamID[i]}\n" +
$"HeadCoach: {HeadCoach[i]}\n\n";



                data01[6] += Sql_Ser02.insert_team_all(TeamID[i].ToString(),
                                                    Key[i],
                                                    Active[i].ToString(),
                                                    City[i],
                                                    Name[i],
                                                    LeagueID[i].ToString(),
                                                    StadiumID[i].ToString(),
                                                    Conference[i],
                                                    Division[i],
                                                    PrimaryColor[i],
                                                    SecondaryColor[i],
                                                    TertiaryColor[i],
                                                    QuaternaryColor[i],
                                                    WikipediaLogoUrl[i],
                                                    WikipediaWordMarkUrl[i].ToString(),
                                                    GlobalTeamID[i].ToString(),
                                                    NbaDotComTeamID[i].ToString(),
                                                    HeadCoach[i]);

            }


            data01[7] += $"{string.Join(" ", TeamID)}" +
      $"{string.Join(" ", Key)}" +
        $"{string.Join(" ", Active)}" +
        $"{string.Join(" ", City)}" +
        $"{string.Join(" ", Name)}" +
       $"{string.Join(" ", LeagueID)}" +
         $"{string.Join(" ", StadiumID)}" +
         $"{string.Join(" ", Conference)}" +
       $"{string.Join(" ", Division)}" +
        $"{string.Join(" ", PrimaryColor)}" +
       $"{string.Join(" ", SecondaryColor)}" +
      $"{string.Join(" ", TertiaryColor)}" +
      $"{string.Join(" ", QuaternaryColor)}" +
     $"{string.Join(" ", WikipediaLogoUrl)}" +
     $"{string.Join(" ", WikipediaWordMarkUrl)}" +
       $"{string.Join(" ", GlobalTeamID)}" +
        $"{string.Join(" ", NbaDotComTeamID)}" +
          $"{string.Join(" ", HeadCoach)}";

            return $"{data01[5]}\n" +
              $"{data01[6]}\n" +
              $"{data01[7]}";
        }
        public string sql_get_team_data_01(string input)
        {

            data01[8] = Sql_Ser02.find_team_by_name(input);



            return data01[8];
        }
        private async Task<string> nba_data04(string input)
        {
            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nba_Model04.Root> resaults = JsonConvert.DeserializeObject<List<Nba_Model04.Root>>(body);
            if (resaults != null)
            {
                foreach (var a in resaults)
                {
                    RefereeID.Add(a.RefereeID);
                    Name.Add(a.Name ?? " ");
                    Number.Add(a.Number);
                    Position.Add(a.Position ?? " ");
                    College.Add(a.College ?? " ");

                }
                foreach (var a in resaults)
                {

                    var collection_set = new Nba_Set_Model04
                    {

                        RefereeID = a.RefereeID,
                        Name = a.Name,
                        Number = a.Number,
                        Position = a.Position,
                        College = a.College,

                    };

                    collectiondata04.Add(collection_set);
                }




                int minCount = new[]
{

            RefereeID.Count,
                Name.Count,
                Number.Count,
                Position.Count,
                College.Count
            }.Min();

                for (int i = 0; i < minCount; i++)
                {
                    data01[9] += $"RefereeID: {RefereeID[i]}" +
                        $"Name: {Name[i]}" +
                        $"Number: {Number[i]}" +
                        $"Position: {Position[i]}" +
                        $"College: {College[i]}";




                    data01[10] += Sql_Ser02.insert_Referee(RefereeID[i].ToString(),
                                                   Name[i],
                                                   Number[i].ToString(),
                                                   Position[i].ToString(),
                                                   College[i]);

                }

            }
            else
            {
                RefereeID.Add(0);
                Name.Add(" ");
                Number.Add(0);
                Position.Add(" ");
                College.Add(" ");

            }

            data01[11] += $"{string.Join(" ", RefereeID)}" +
                $"{string.Join(" ", Name)}" +
                $"{string.Join(" ", Number)}" +
                $"{string.Join(" ", Position)}" +
                $"{string.Join(" ", College)}";

            return $"{data01[9]}\n" +
           $"{data01[10]}\n" +
           $"{data01[11]}";
        }
        private async Task<string> nba_data05(string input)
        {


            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nba_Model05.Root> resaults = JsonConvert.DeserializeObject<List<Nba_Model05.Root>>(body);
            if (resaults != null)
            {
                foreach (var a in resaults)
                {

                    StadiumID.Add(a.StadiumID);
                    Active.Add(a.Active);
                    Name.Add(a.Name);
                    Address.Add(a.Address);
                    City.Add(a.City);
                    State.Add(a.State);
                    Zip.Add(a.Zip);
                    Country.Add(a.Country);
                    Capacity.Add(a.Capacity);
                    GeoLat.Add(a.GeoLat);
                    GeoLong.Add(a.GeoLong);

                }





                foreach (var a in resaults)
                {

                    var collection_set = new Nba_Set_Model05
                    {


                        StadiumID = a.StadiumID,
                        Active = a.Active,
                        Name = a.Name,
                        Address = a.Address,
                        City = a.City,
                        State = a.State,
                        Zip = a.Zip,
                        Country = a.Country,
                        Capacity = a.Capacity,
                        GeoLat = a.GeoLat,
                        GeoLong = a.GeoLong,

                    };

                    collectiondata05.Add(collection_set);
                }

                int minCount = new[]
    {

                StadiumID.Count,
                Active.Count,
                Name.Count,
                Address.Count,
                City.Count,
                State.Count,
                Zip.Count,
                Country.Count,
                Capacity.Count,
                GeoLat.Count,
                GeoLong.Count
            }.Min();
                for (int i = 0; i < minCount; i++)
                {
                    data01[12] += $"TeamID: {StadiumID[i]}\n" +
                         $"Active: {Active[i]}\n" +
                         $"Name: {Name[i]}\n" +
                         $"Address: {Address[i]}\n" +
                         $"City: {City[i]}\n" +
                         $"City: {State[i]}\n" +
                         $"Zip: {Zip[i]}\n" +
                         $"Country: {Country[i]}\n" +
                         $"Capacity: {Capacity[i]}\n" +
                         $"GeoLat: {GeoLat[i]}\n" +
                         $"GeoLong: {GeoLong[i]}\n";

                    data01[13] += Sql_Ser02.insert_Stadium(
                                                                 StadiumID[i].ToString(),
                                                                 Active[i].ToString(),
                                                                 Name[i],
                                                                 Address[i],
                                                                 City[i],
                                                                 State[i],
                                                                 Zip[i],
                                                                 Country[i],
                                                                 Capacity[i].ToString(),
                                                                 GeoLat[i].ToString(),
                                                                 GeoLong[i].ToString());


                }


            }
            else
            {
                StadiumID.Add(0);
                Active.Add(null);
                Name.Add("");
                Address.Add("");
                City.Add("");
                State.Add(" ");
                Zip.Add(" ");
                Country.Add(" ");
                Capacity.Add(0);
                GeoLat.Add(0);
                GeoLong.Add(0);
            }

            data01[14] += $"{string.Join(" ", TeamID)}" +
                $"{string.Join(" ", Active)}" +
                $"{string.Join(" ", Name)}" +
                $"{string.Join(" ", City)}" +
                $"{string.Join(" ", Zip)}" +
                $"{string.Join(" ", Country)}" +
                $"{string.Join(" ", Capacity)}" +
                $"{string.Join(" ", GeoLat)}" +
                $"{string.Join(" ", GeoLong)}";

            return $"{data01[12]}\n" +
                     $"{data01[3]}\n" +
                     $"{data01[14]}";
        }
        private async Task<string> nba_data06(string input)
        {


            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            if (body != null)
            {
                if (body.Trim() == "true")
                {
                    data01[15] = "games are playing";
                }
                else
                {
                    data01[15] = "games are not playing";
                }

            }
            else
            {
                data01[15] = "no data";
            }
            var collection_set = new Nba_Set_Model06
            {


                Active = body,


            };

            collectiondata06.Add(collection_set);
            return data01[15];
        }
        private async Task<string> nba_data07(string input)
        {


            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            Nba_Model06.Root results = JsonConvert.DeserializeObject<Nba_Model06.Root>(body);
            if (results != null)
            {
                if (results.BettingBetTypes != null)
                {
                    foreach (var b in results.BettingBetTypes)
                    {
                        RecordId.Add(b.RecordId);
                        Name.Add(b.Name);
                        Active.Add(b.Active);
                    }
                }
                else
                {
                    RecordId.Add(0);
                    Name.Add(" ");
                    Active.Add(null);

                }

                if (results.BettingMarketTypes != null)
                {
                    foreach (var b in results.BettingMarketTypes)
                    {
                        RecordId01.Add(b.RecordId);
                        Name01.Add(b.Name);
                        Active01.Add(b.Active);
                    }
                }
                else
                {
                    RecordId01.Add(0);
                    Name01.Add(" ");
                    Active01.Add(null);
                }

                if (results.BettingPeriodTypes != null)
                {
                    foreach (var b in results.BettingPeriodTypes)
                    {
                        RecordId02.Add(b.RecordId);
                        Name02.Add(b.Name);
                        Active02.Add(b.Active);
                    }
                }
                else
                {
                    RecordId02.Add(0);
                    Name02.Add(" ");
                    Active02.Add(null);
                }
                if (results.BettingEventTypes != null)
                {
                    foreach (var b in results.BettingEventTypes)
                    {
                        RecordId03.Add(b.RecordId);
                        Name03.Add(b.Name);
                        Active03.Add(b.Active);
                    }
                }
                else
                {
                    RecordId03.Add(0);
                    Name03.Add(" ");
                    Active03.Add(null);
                }

                if (results.BettingOutcomeTypes != null)
                {

                    foreach (var b in results.BettingOutcomeTypes)
                    {
                        RecordId04.Add(b.RecordId);
                        Name04.Add(b.Name);
                        Active04.Add(b.Active);
                    }
                }
                else
                {
                    RecordId04.Add(0);
                    Name04.Add(" ");
                    Active04.Add(null);
                }
                if (results.ResultedMarketMetaData != null)
                {
                    foreach (var b in results.ResultedMarketMetaData)
                    {
                        BettingMarketTypeId.Add(b.BettingMarketTypeId);
                        BettingBetTypeId.Add(b.BettingBetTypeId);
                        BettingPeriodTypeId.Add(b.BettingPeriodTypeId);
                    }
                }
                else
                {
                    BettingMarketTypeId.Add(0);
                    BettingBetTypeId.Add(0);
                    BettingPeriodTypeId.Add(0);
                }

                if (results.BettingResultTypes != null)
                {
                    foreach (var b in results.BettingResultTypes)
                    {
                        RecordId05.Add(b.RecordId);
                        Name05.Add(b.Name);
                        Active05.Add(b.Active);
                    }
                }
                else
                {
                    RecordId05.Add(0);
                    Name05.Add(" ");
                    Active05.Add(null);
                }




            }
            else
            {

                RecordId.Add(0);
                Name.Add(" ");
                Active.Add(null);
                RecordId01.Add(0);
                Name01.Add(" ");
                Active01.Add(null);
                RecordId02.Add(0);
                Name02.Add(" ");
                Active02.Add(null);
                RecordId03.Add(0);
                Name03.Add(" ");
                Active03.Add(null);
                RecordId04.Add(0);
                Name04.Add(" ");
                Active04.Add(null);
                BettingMarketTypeId.Add(0);
                BettingBetTypeId.Add(0);
                BettingPeriodTypeId.Add(0);
                RecordId05.Add(0);
                Name05.Add(" ");
                Active05.Add(null);
            }

            var collection_set = new Nba_Set_Model07
            {

                RecordId = RecordId.Count > 0 ? RecordId[0] : 0,
                Name = Name.Count > 0 ? Name[0] : null,
                Active = Active.Count > 0 ? Active[0] : null,
                RecordId01 = RecordId01.Count > 0 ? RecordId01[0] : 0,
                Name01 = Name01.Count > 0 ? Name01[0] : null,
                Active01 = Active01.Count > 0 ? Active01[0] : null,
                RecordId02 = RecordId02.Count > 0 ? RecordId02[0] : 0,
                Name02 = Name02.Count > 0 ? Name02[0] : null,
                Active02 = Active02.Count > 0 ? Active02[0] : null,
                RecordId03 = RecordId03.Count > 0 ? RecordId03[0] : 0,
                Name03 = Name03.Count > 0 ? Name03[0] : null,
                Active03 = Active03.Count > 0 ? Active03[0] : null,
                RecordId04 = RecordId04.Count > 0 ? RecordId04[0] : 0,
                Name04 = Name04.Count > 0 ? Name04[0] : null,
                Active04 = Active04.Count > 0 ? Active04[0] : null,
                BettingMarketTypeId = BettingMarketTypeId.Count > 0 ? BettingMarketTypeId[0] : 0,
                BettingBetTypeId = BettingBetTypeId.Count > 0 ? BettingBetTypeId[0] : 0,
                BettingPeriodTypeId = BettingPeriodTypeId.Count > 0 ? BettingPeriodTypeId[0] : 0,
                RecordId05 = RecordId05.Count > 0 ? RecordId05[0] : 0,
                Name05 = Name05.Count > 0 ? Name05[0] : null,
                Active05 = Active05.Count > 0 ? Active05[0] : null,

            };

            collectiondata07.Add(collection_set);





            int minCount = new[]
         {
    RecordId.Count,
    Name.Count,
    Active.Count,
    RecordId01.Count,
    Name01.Count,
    Active01.Count,
    RecordId02.Count,
    Name02.Count,
    Active02.Count,
    RecordId03.Count,
    Name03.Count,
    Active03.Count,
    RecordId04.Count,
    Name04.Count,
    Active04.Count,
    BettingMarketTypeId.Count,
    BettingBetTypeId.Count,
    BettingPeriodTypeId.Count,
    RecordId05.Count,
    Name05.Count,
    Active05.Count
}.Min();

            for (var i = 0; i < minCount; i++)
            {
                data01[16] += $"RecordId: {RecordId[i]}\n" +
                $"RecordId: {RecordId[i]}\n" +
                $"Name: {Name[i]}\n" +
                $"Active: {Active[i]}\n" +
                $"RecordId01: {RecordId01[i]}\n" +
                $"Name01: {Name01[i]}\n" +
                $"Active01: {Active01[i]}\n" +
                $"RecordId02: {RecordId02[i]}\n" +
                $"Name02: {Name02[i]}\n" +
                $"Active02: {Active02[i]}\n" +
                $"RecordId03: {RecordId03[i]}\n" +
                $"Name03: {Name03[i]}\n" +
                $"Active03: {Active03[i]}\n" +
                $"RecordId04: {RecordId04[i]}\n" +
                $"Name04: {Name04[i]}\n" +
                $"Active04: {Active04[i]}\n" +
                $"BettingMarketTypeId: {BettingMarketTypeId[i]}\n" +
                $"BettingBetTypeId: {BettingBetTypeId[i]}\n" +
                $"BettingPeriodTypeId: {BettingPeriodTypeId[i]}\n" +
                $"RecordId05: {RecordId05[i]}\n" +
                $"Name05: {Name05[i]}\n" +
                $"Active05: {Active05[i]}\n";


            }
            data01[17] += $"{string.Join(" ", RecordId)}" +
 $"{string.Join(" ", RecordId)}" +
             $"{string.Join(" ", Name)}" +
            $"{string.Join(" ", Active)}" +
             $"{string.Join(" ", RecordId01)}" +
              $"{string.Join(" ", Name01)}" +
                $"{string.Join(" ", Active01)}" +
            $"{string.Join(" ", RecordId02)}" +
             $"{string.Join(" ", Name02)}" +
             $"{string.Join(" ", Active02)}" +
           $"{string.Join(" ", RecordId03)}" +
           $"{string.Join(" ", Name03)}" +
           $"{string.Join(" ", Active03)}" +
            $"{string.Join(" ", RecordId04)}" +
             $"{string.Join(" ", Name04)}" +
            $"{string.Join(" ", Active04)}" +
              $"{string.Join(" ", BettingMarketTypeId)}" +
          $"{string.Join(" ", BettingBetTypeId)}" +
            $"{string.Join(" ", BettingPeriodTypeId)}" +
              $"{string.Join(" ", RecordId05)}" +
            $"{string.Join(" ", Name05)}" +
           $"{string.Join(" ", Active05)}";


            return data01[16];
        }
        private async Task<string> nba_data08(string input)
        {
            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            Nba_Model07.Root results = JsonConvert.DeserializeObject<Nba_Model07.Root>(body);
            Season.Add(results.Season);
            StartYear.Add(results.StartYear);
            EndYear.Add(results.EndYear);
            Description.Add(results.Description);
            RegularSeasonStartDate.Add(results.RegularSeasonStartDate);
            PostSeasonStartDate.Add(results.PostSeasonStartDate);
            SeasonType01.Add(results.SeasonType);
            ApiSeason.Add(results.ApiSeason);

            var collection_set = new Nba_Set_Model08
            {

                Season = results.Season,
                StartYear = results.StartYear,
                EndYear = results.EndYear,
                Description = results.Description,
                RegularSeasonStartDate = results.RegularSeasonStartDate,
                PostSeasonStartDate = results.PostSeasonStartDate,
                SeasonType01 = results.SeasonType,
                ApiSeason = results.ApiSeason,

            };

            collectiondata08.Add(collection_set);

            for (var i = 0; i < Season.Count; i++)
            {
                data01[18] += $"Season: {Season[i]}\n" +
                             $"StartYear: {StartYear[i]}\n" +
                             $"EndYear: {EndYear[i]}\n" +
                             $"Description: {Description[i]}\n" +
                             $"RegularSeasonStartDate: {RegularSeasonStartDate[i]}\n" +
                             $"PostSeasonStartDate: {PostSeasonStartDate[i]}\n" +
                             $"SeasonType: {SeasonType01[i]}\n" +
                             $"ApiSeason: {ApiSeason[i]}\n";


                data01[19] += Sql_Ser02.insert_season(SeasonID[i].ToString(),
                                                           Season[i].ToString(),
                                                           StartYear[i].ToString(),
                                                           EndYear[i].ToString(),
                                                           Description[i].ToString(),
                                                           RegularSeasonStartDate[i].ToString(),
                                                           PostSeasonStartDate[i].ToString(),
                                                           SeasonType01[i].ToString(),
                                                           ApiSeason[i].ToString());

                data01[20] += $"{string.Join(" ", SeasonID)}" +
                             $"{string.Join(" ", Season)}" +
                             $"{string.Join(" ", StartYear)}" +
                             $"{string.Join(" ", EndYear)}" +
                             $"{string.Join(" ", Description)}" +
                             $"{string.Join(" ", RegularSeasonStartDate)}" +
                             $"{string.Join(" ", PostSeasonStartDate)}" +
                             $"{string.Join(" ", SeasonType01)}" +
                             $"{string.Join(" ", ApiSeason)}";

            }
            return $"{data01[18]}\n" +
                   $"{data01[19]}\n" +
                   $"{data01[20]}";
        }
        private async Task<string> nba_data09(string input)
        {


            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nba_Model08.Root> results = JsonConvert.DeserializeObject<List<Nba_Model08.Root>>(body);
            foreach (var item in results)
            {
                SportsbookID.Add(item.SportsbookID);
                Name.Add(item.Name);
            }
            foreach (var item in results)
            {
                var collection_set = new Nba_Set_Model09
                {


                    SportsbookID = item.SportsbookID,
                    Name = item.Name,

                };

                collectiondata09.Add(collection_set);

            }


            for (int i = 0; i < SportsbookID.Count; i++)
            {
                data01[21] += $"SportsbookID: {SportsbookID[i]}\n" +
                             $"Name: {Name[i]}\n";
            }

            data01[22] += $"{string.Join(" ", SportsbookID)}" +
                         $"{string.Join(" ", Name)}";

            return data01[21];
        }
        private async Task<string> nba_data10(string input)
        {


            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nba_Model09.Root> results = JsonConvert.DeserializeObject<List<Nba_Model09.Root>>(body);
            foreach (var item in results)
            {

                GameID.Add(item.GameID);
                Season.Add(item.Season);
                SeasonType.Add(item.SeasonType);
                Status.Add(item.Status);
                Day.Add(item.Day);
                DateTime.Add(item.DateTime);
                AwayTeam.Add(item.AwayTeam);
                HomeTeam.Add(item.HomeTeam);
                AwayTeamID.Add(item.AwayTeamID);
                HomeTeamID.Add(item.HomeTeamID);
                StadiumID.Add(item.StadiumID);
                Channel.Add(item.Channel);
                Attendance.Add(item.Attendance);
                AwayTeamScore.Add(item.AwayTeamScore);
                HomeTeamScore.Add(item.HomeTeamScore);
                Updated.Add(item.Updated);
                Quarter.Add(item.Quarter);
                TimeRemainingMinutes.Add(item.TimeRemainingMinutes);
                TimeRemainingSeconds.Add(item.TimeRemainingSeconds);
                PointSpread.Add(item.PointSpread);
                OverUnder.Add(item.OverUnder);
                AwayTeamMoneyLine.Add(item.AwayTeamMoneyLine);
                HomeTeamMoneyLine.Add(item.HomeTeamMoneyLine);
                GlobalGameID.Add(item.GlobalGameID);
                GlobalAwayTeamID.Add(item.GlobalAwayTeamID);
                GlobalHomeTeamID.Add(item.GlobalHomeTeamID);
                PointSpreadAwayTeamMoneyLine.Add(item.PointSpreadAwayTeamMoneyLine);
                PointSpreadHomeTeamMoneyLine.Add(item.PointSpreadHomeTeamMoneyLine);
                LastPlay.Add(item.LastPlay);
                IsClosed.Add(item.IsClosed);
                GameEndDateTime.Add(item.GameEndDateTime);
                HomeRotationNumber.Add(item.HomeRotationNumber);
                AwayRotationNumber.Add(item.AwayRotationNumber);
                NeutralVenue.Add(item.NeutralVenue);
                OverPayout.Add(item.OverPayout);
                UnderPayout.Add(item.UnderPayout);
                CrewChiefID.Add(item.CrewChiefID);
                UmpireID.Add(item.UmpireID);
                RefereeID.Add(item.RefereeID);
                AlternateID.Add(item.AlternateID);
                DateTimeUTC.Add(item.DateTimeUTC);
                InseasonTournament.Add(item.InseasonTournament);
                SeriesInfo.Add(item.SeriesInfo);
                Quarters.Add(item.Quarters);

                for (int i = 0; i < GameID.Count; i++)
                {
                    data01[23] +=
                  $"GameID: {GameID[i]}\n" +
                    $"Season: {Season[i]}\n" +
                     $"SeasonType: {SeasonType[i]}\n" +
                  $"Status: {Status[i]}\n" +
                 $"Day: {Day[i]}\n" +
               $"DateTime: {DateTime[i]}\n" +
                 $"AwayTeam: {AwayTeam[i]}\n" +
                $"HomeTeam: {HomeTeam[i]}\n" +
                  $"AwayTeamID: {AwayTeamID[i]}\n" +
                $"HomeTeamID: {HomeTeamID[i]}\n" +
                  $"StadiumID: {StadiumID[i]}\n" +
                  $"Channel: {Channel[i]}\n" +
                  $"Attendance: {Attendance[i]}\n" +
                     $"AwayTeamScore: {AwayTeamScore[i]}\n" +
                    $"HomeTeamScore: {HomeTeamScore[i]}\n" +
                  $"Updated: {Updated[i]}\n" +
                    $"Quarter: {Quarter[i]}\n" +
                 $"TimeRemainingMinutes: {TimeRemainingMinutes[i]}\n" +
                    $"TimeRemainingSeconds: {TimeRemainingSeconds[i]}\n" +
                     $"PointSpread: {PointSpread[i]}\n" +
                   $"OverUnder: {OverUnder[i]}\n" +
                  $"AwayTeamMoneyLine: {AwayTeamMoneyLine[i]}\n" +
                    $"HomeTeamMoneyLine: {HomeTeamMoneyLine[i]}\n" +
                     $"GlobalGameID: {GlobalGameID[i]}\n" +
                    $"GlobalAwayTeamID: {GlobalAwayTeamID[i]}\n" +
                    $"GlobalHomeTeamID: {GlobalHomeTeamID[i]}\n" +
                  $"PointSpreadAwayTeamMoneyLine: {PointSpreadAwayTeamMoneyLine[i]}\n" +
                   $"PointSpreadHomeTeamMoneyLine: {PointSpreadHomeTeamMoneyLine[i]}\n" +
                   $"LastPlay: {LastPlay[i]}\n" +
                  $"IsClosed: {IsClosed[i]}\n" +
                  $"GameEndDateTime: {GameEndDateTime[i]}\n" +
                  $"HomeRotationNumber: {HomeRotationNumber[i]}\n" +
                   $"AwayRotationNumber: {AwayRotationNumber[i]}\n" +
                    $"NeutralVenue: {NeutralVenue[i]}\n" +
                   $"OverPayout: {OverPayout[i]}\n" +
                  $"UnderPayout: {UnderPayout[i]}\n" +
                    $"CrewChiefID: {CrewChiefID[i]}\n" +
                    $"UmpireID: {UmpireID[i]}\n" +
                     $"RefereeID: {RefereeID[i]}\n" +
                   $"AlternateID: {AlternateID[i]}\n" +
                   $"DateTimeUTC: {DateTimeUTC[i]}\n" +
                  $"InseasonTournament: {InseasonTournament[i]}\n" +
                  $"SeriesInfo: {SeriesInfo[i]}\n" +
                  $"Quarters: {string.Join(", ", (List<object>)Quarters[i])}\n";

                }

                data01[24] += $"{string.Join(" ", GameID)}" +
                             $"{string.Join(" ", Season)}" +
                             $"{string.Join(" ", SeasonType)}" +
                             $"{string.Join(" ", Status)}" +
                             $"{string.Join(" ", Day)}" +
                             $"{string.Join(" ", DateTime)}" +
                             $"{string.Join(" ", AwayTeam)}" +
                             $"{string.Join(" ", HomeTeam)}" +
                             $"{string.Join(" ", AwayTeamID)}" +
                             $"{string.Join(" ", HomeTeamID)}" +
                             $"{string.Join(" ", StadiumID)}" +
                             $"{string.Join(" ", Channel)}" +
                             $"{string.Join(" ", Attendance)}" +
                             $"{string.Join(" ", AwayTeamScore)}" +
                             $"{string.Join(" ", HomeTeamScore)}" +
                             $"{string.Join(" ", Updated)}" +
                             $"{string.Join(" ", Quarter)}" +
                             $"{string.Join(" ", TimeRemainingMinutes)}" +
                             $"{string.Join(" ", TimeRemainingSeconds)}" +
                             $"{string.Join(" ", PointSpread)}" +
                             $"{string.Join(" ", OverUnder)}" +
                             $"{string.Join(" ", AwayTeamMoneyLine)}" +
                             $"{string.Join(" ", HomeTeamMoneyLine)}" +
                             $"{string.Join(" ", GlobalGameID)}" +
                             $"{string.Join(" ", GlobalAwayTeamID)}" +
                             $"{string.Join(" ", GlobalHomeTeamID)}" +
                             $"{string.Join(" ", PointSpreadAwayTeamMoneyLine)}" +
                             $"{string.Join(" ", PointSpreadHomeTeamMoneyLine)}" +
                             $"{string.Join(" ", LastPlay)}" +
                             $"{string.Join(" ", IsClosed)}" +
                             $"{string.Join(" ", GameEndDateTime)}" +
                             $"{string.Join(" ", HomeRotationNumber)}" +
                             $"{string.Join(" ", AwayRotationNumber)}" +
                             $"{string.Join(" ", NeutralVenue)}" +
                             $"{string.Join(" ", OverPayout)}" +
                             $"{string.Join(" ", UnderPayout)}" +
                             $"{string.Join(" ", CrewChiefID)}" +
                             $"{string.Join(" ", UmpireID)}" +
                             $"{string.Join(" ", RefereeID)}" +
                             $"{string.Join(" ", AlternateID)}" +
                             $"{string.Join(" ", DateTimeUTC)}" +
                             $"{string.Join(" ", InseasonTournament)}" +
                             $"{string.Join(" ", SeriesInfo)}" +
                             $"{string.Join(" | ", Quarters.Select(q => string.Join(",", (q as List<object>) ?? new List<object>())))}";



            }

            foreach (var item in results)
            {
                var collection_set = new Nba_Set_Model10
                {


                    GameID = item.GameID,
                    Season = item.Season,
                    SeasonType = item.SeasonType,
                    Status = item.Status,
                    Day = item.Day,
                    DateTime = item.DateTime,
                    AwayTeam = item.AwayTeam,
                    HomeTeam = item.HomeTeam,
                    AwayTeamID = item.AwayTeamID,
                    HomeTeamID = item.HomeTeamID,
                    StadiumID = item.StadiumID,
                    Channel = item.Channel,
                    Attendance = item.Attendance,
                    AwayTeamScore = item.AwayTeamScore,
                    HomeTeamScore = item.HomeTeamScore,
                    Updated = item.Updated,
                    Quarter = item.Quarter,
                    TimeRemainingMinutes = item.TimeRemainingMinutes,
                    TimeRemainingSeconds = item.TimeRemainingSeconds,
                    PointSpread = item.PointSpread,
                    OverUnder = item.OverUnder,
                    AwayTeamMoneyLine = item.AwayTeamMoneyLine,
                    HomeTeamMoneyLine = item.HomeTeamMoneyLine,
                    GlobalGameID = item.GlobalGameID,
                    GlobalAwayTeamID = item.GlobalAwayTeamID,
                    GlobalHomeTeamID = item.GlobalHomeTeamID,
                    PointSpreadAwayTeamMoneyLine = item.PointSpreadAwayTeamMoneyLine,
                    PointSpreadHomeTeamMoneyLine = item.PointSpreadHomeTeamMoneyLine,
                    LastPlay = item.LastPlay,
                    IsClosed = item.IsClosed,
                    GameEndDateTime = item.GameEndDateTime,
                    HomeRotationNumber = item.HomeRotationNumber,
                    AwayRotationNumber = item.AwayRotationNumber,
                    NeutralVenue = item.NeutralVenue,
                    OverPayout = item.OverPayout,
                    UnderPayout = item.UnderPayout,
                    CrewChiefID = item.CrewChiefID,
                    UmpireID = item.UmpireID,
                    RefereeID = item.RefereeID,
                    AlternateID = item.AlternateID,
                    DateTimeUTC = item.DateTimeUTC,
                    InseasonTournament = item.InseasonTournament,
                    SeriesInfo = item.SeriesInfo,
                    Quarters = item.Quarters,

                };

                collectiondata10.Add(collection_set);

            }


            return data01[24];
        }
        private async Task<string> nba_data11(string input)
        {


            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nba_Model10.Root> results = JsonConvert.DeserializeObject<List<Nba_Model10.Root>>(body);
            foreach (var item in results)
            {

                GameID.Add(item.GameID);
                Season.Add(item.Season);
                SeasonType.Add(item.SeasonType);
                Status.Add(item.Status);
                Day.Add(item.Day);
                DateTime.Add(item.DateTime);
                AwayTeam.Add(item.AwayTeam);
                HomeTeam.Add(item.HomeTeam);
                AwayTeamID.Add(item.AwayTeamID);
                HomeTeamID.Add(item.HomeTeamID);
                StadiumID.Add(item.StadiumID);
                AwayTeamScore.Add(item.AwayTeamScore);
                HomeTeamScore.Add(item.HomeTeamScore);
                Updated.Add(item.Updated);
                GlobalGameID.Add(item.GlobalGameID);
                GlobalAwayTeamID.Add(item.GlobalAwayTeamID);
                GlobalHomeTeamID.Add(item.GlobalHomeTeamID);
                IsClosed.Add(item.IsClosed);
                NeutralVenue.Add(item.NeutralVenue);
                DateTimeUTC.Add(item.DateTimeUTC);
                GameEndDateTIme.Add(item.GameEndDateTIme);
                var collection_set = new Nba_Set_Model11
                {


                    GameID = item.GameID,
                    Season = item.Season,
                    SeasonType = item.SeasonType,
                    Status = item.Status,
                    Day = item.Day,
                    DateTime = item.DateTime,
                    AwayTeam = item.AwayTeam,
                    HomeTeam = item.HomeTeam,
                    AwayTeamID = item.AwayTeamID,
                    HomeTeamID = item.HomeTeamID,
                    StadiumID = item.StadiumID,
                    AwayTeamScore = item.AwayTeamScore,
                    HomeTeamScore = item.HomeTeamScore,
                    Updated = item.Updated,
                    GlobalGameID = item.GlobalGameID,
                    GlobalAwayTeamID = item.GlobalAwayTeamID,
                    GlobalHomeTeamID = item.GlobalHomeTeamID,
                    IsClosed = item.IsClosed,
                    NeutralVenue = item.NeutralVenue,
                    DateTimeUTC = item.DateTimeUTC,
                    GameEndDateTIme = item.GameEndDateTIme,
                };
                collectiondata11.Add(collection_set);
            }
            for (int i = 0; i < GameID.Count; i++)
            {
                data01[25] +=
              $"GameID: {GameID[i]}\n" +
                      $"Season: {Season[i]}\n" +
                   $"SeasonType: {SeasonType[i]}\n" +
                 $"Status: {Status[i]}\n" +
                   $"Day: {Day[i]}\n" +
                  $"DateTime: {DateTime[i]}\n" +
                  $"AwayTeam: {AwayTeam[i]}\n" +
                 $"HomeTeam: {HomeTeam[i]}\n" +
                 $"AwayTeamID: {AwayTeamID[i]}\n" +
                 $"HomeTeamID: {HomeTeamID[i]}\n" +
                $"StadiumID: {StadiumID[i]}\n" +
                 $"AwayTeamScore: {AwayTeamScore[i]}\n" +
                 $"HomeTeamScore: {HomeTeamScore[i]}\n" +
                 $"Updated: {Updated[i]}\n" +
                $"GlobalGameID: {GlobalGameID[i]}\n" +
                $"GlobalAwayTeamID: {GlobalAwayTeamID[i]}\n" +
                $"GlobalHomeTeamID: {GlobalHomeTeamID[i]}\n" +
                $"IsClosed: {IsClosed[i]}\n" +
                $"NeutralVenue: {NeutralVenue[i]}\n" +
                 $"DateTimeUTC: {DateTimeUTC[i]}\n" +
                $"GameEndDateTIme: {GameEndDateTIme[i]}\n";
            }
            data01[26] += $"{string.Join(" ", GameID)}" +
                               $"{string.Join(" ", Season)}" +
                 $"{string.Join(" ", SeasonType)}" +
                $"{string.Join(" ", Status)}" +
               $"{string.Join(" ", Day)}" +
               $"{string.Join(" ", DateTime)}" +
               $"{string.Join(" ", AwayTeam)}" +
               $"{string.Join(" ", HomeTeam)}" +
               $"{string.Join(" ", AwayTeamID)}" +
               $"{string.Join(" ", HomeTeamID)}" +
               $"{string.Join(" ", StadiumID)}" +
                 $"{string.Join(" ", AwayTeamScore)}" +
              $"{string.Join(" ", HomeTeamScore)}" +
                $"{string.Join(" ", Updated)}" +
              $"{string.Join(" ", GlobalGameID)}" +
               $"{string.Join(" ", GlobalAwayTeamID)}" +
               $"{string.Join(" ", GlobalHomeTeamID)}" +
               $"{string.Join(" ", IsClosed)}" +
              $"{string.Join(" ", NeutralVenue)}" +
                 $"{string.Join(" ", DateTimeUTC)}" +
               $"{string.Join(" ", GameEndDateTIme)}";
            return data01[25];
        }
        private async Task<string> nba_data12(string input)
        {


            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nba_Model11.Root> results = JsonConvert.DeserializeObject<List<Nba_Model11.Root>>(body);
            foreach (var item in results)
            {



                GameID.Add(item.GameID);
                Season.Add(item.Season);
                SeasonType.Add(item.SeasonType);
                Status.Add(item.Status);
                Day.Add(item.Day);
                DateTime.Add(item.DateTime);
                AwayTeam.Add(item.AwayTeam);
                HomeTeam.Add(item.HomeTeam);
                AwayTeamID.Add(item.AwayTeamID);
                HomeTeamID.Add(item.HomeTeamID);
                StadiumID.Add(item.StadiumID);
                AwayTeamScore.Add(item.AwayTeamScore);
                HomeTeamScore.Add(item.HomeTeamScore);
                Updated.Add(item.Updated);
                GlobalGameID.Add(item.GlobalGameID);
                GlobalAwayTeamID.Add(item.GlobalAwayTeamID);
                GlobalHomeTeamID.Add(item.GlobalHomeTeamID);
                IsClosed.Add(item.IsClosed);
                NeutralVenue.Add(item.NeutralVenue);
                DateTimeUTC.Add(item.DateTimeUTC);
                var collection_set = new Nba_Set_Model12
                {
                    GameID = item.GameID,
                    Season = item.Season,
                    SeasonType = item.SeasonType,
                    Status = item.Status,
                    Day = item.Day,
                    DateTime = item.DateTime,
                    AwayTeam = item.AwayTeam,
                    HomeTeam = item.HomeTeam,
                    AwayTeamID = item.AwayTeamID,
                    HomeTeamID = item.HomeTeamID,
                    StadiumID = item.StadiumID,
                    AwayTeamScore = item.AwayTeamScore,
                    HomeTeamScore = item.HomeTeamScore,
                    Updated = item.Updated,
                    GlobalGameID = item.GlobalGameID,
                    GlobalAwayTeamID = item.GlobalAwayTeamID,
                    GlobalHomeTeamID = item.GlobalHomeTeamID,
                    IsClosed = item.IsClosed,
                    NeutralVenue = item.NeutralVenue,
                    DateTimeUTC = item.DateTimeUTC,
                };
                collectiondata12.Add(collection_set);
                for (int i = 0; i < GameID.Count; i++)
                {
                    data01[27] +=

                          $"GameEndDateTime: {GameEndDateTime[i]}\n" +
                     $"GameID: {GameID[i]}\n" +
                    $"Season: {Season[i]}\n" +
                    $"SeasonType: {SeasonType[i]}\n" +
                    $"Status: {Status[i]}\n" +
                     $"Day: {Day[i]}\n" +
                    $"DateTime: {DateTime[i]}\n" +
                     $"AwayTeam: {AwayTeam[i]}\n" +
                    $"HomeTeam: {HomeTeam[i]}\n" +
                     $"AwayTeamID: {AwayTeamID[i]}\n" +
                    $"StadiumID: {StadiumID[i]}\n" +
                    $"AwayTeamScore: {AwayTeamScore[i]}\n" +
                    $"HomeTeamScore: {HomeTeamScore[i]}\n" +
                    $"Updated: {Updated[i]}\n" +
                    $"GlobalGameID: {GlobalGameID[i]}\n" +
                    $"GlobalAwayTeamID: {GlobalAwayTeamID[i]}\n" +
                    $"GlobalHomeTeamID: {GlobalHomeTeamID[i]}\n" +
                    $"IsClosed: {IsClosed[i]}\n" +
                    $"NeutralVenue: {NeutralVenue[i]}\n" +
                   $"DateTimeUTC: {DateTimeUTC[i]}\n" +
                    $"GameEndDateTIme: {GameEndDateTIme[i]}\n";

                }
                data01[28] += $"{string.Join(" ", GameID)}" +
                        $"{string.Join(" ", GameEndDateTime)}" +
               $"{string.Join(" ", GameID)}" +
               $"{string.Join(" ", Season)}" +
               $"{string.Join(" ", SeasonType)}" +
               $"{string.Join(" ", Status)}" +
               $"{string.Join(" ", Day)}" +
               $"{string.Join(" ", DateTime)}" +
               $"{string.Join(" ", AwayTeam)}" +
               $"{string.Join(" ", HomeTeam)}" +
               $"{string.Join(" ", AwayTeamID)}" +
               $"{string.Join(" ", HomeTeamID)}" +
               $"{string.Join(" ", StadiumID)}" +
                 $"{string.Join(" ", AwayTeamScore)}" +
              $"{string.Join(" ", HomeTeamScore)}" +
                $"{string.Join(" ", Updated)}" +
              $"{string.Join(" ", GlobalGameID)}" +
               $"{string.Join(" ", GlobalAwayTeamID)}" +
               $"{string.Join(" ", GlobalHomeTeamID)}" +
               $"{string.Join(" ", IsClosed)}" +
              $"{string.Join(" ", NeutralVenue)}" +
                 $"{string.Join(" ", DateTimeUTC)}" +
               $"{string.Join(" ", GameEndDateTIme)}" +
               $"{string.Join(" ", SeriesInfo)}";
            }
            return data01[27];
        }
        private async Task<string> nba_data13(string input)
        {
            data01[29] = await Team_Profiles_All();
            int minCount = new[]
             {
                          TeamID.Count,
                           Key.Count,
                             Active.Count,
                              City.Count,
                             Name.Count,
                                 LeagueID.Count,
                              StadiumID.Count,
                                Conference.Count,
                             Division.Count,
                             PrimaryColor.Count,
                              SecondaryColor.Count,
                             TertiaryColor.Count,
                             QuaternaryColor.Count,
                           WikipediaLogoUrl.Count,
                             WikipediaWordMarkUrl.Count,
                            GlobalTeamID.Count,
                          HeadCoach.Count
        }.Min();
            for (int i = 0; i < minCount; i++)
            {
                if (Name.Contains(input) == true)
                {
                    data01[30] += $"TeamID: {TeamID[i]}\n" +
                                  $"Key: {Key[i]}\n" +
                                  $"Active: {Active[i]}\n" +
                                  $"City: {City[i]}\n" +
                                  $"Name: {Name[i]}\n" +
                                  $"LeagueID: {LeagueID[i]}\n" +
                                  $"StadiumID: {StadiumID[i]}\n" +
                                  $"Conference: {Conference[i]}\n" +
                                  $"Division: {Division[i]}\n" +
                                  $"PrimaryColor: {PrimaryColor[i]}\n" +
                                  $"SecondaryColor: {SecondaryColor[i]}\n" +
                                  $"TertiaryColor: {TertiaryColor[i]}\n" +
                                  $"QuaternaryColor: {QuaternaryColor[i]}\n" +
                                  $"WikipediaLogoUrl: {WikipediaLogoUrl[i]}\n" +
                                  $"WikipediaWordMarkUrl: {WikipediaWordMarkUrl[i]}\n" +
                                  $"GlobalTeamID: {GlobalTeamID[i]}\n" +
                                  $"NbaDotComTeamID: {NbaDotComTeamID[i]}\n" +
                                  $"HeadCoach: {HeadCoach[i]}\n\n";


                }
                else
                {
                    data01[30] = Default_Text01.text02[1];
                }

            }

            return data01[30];
        }
    }
}