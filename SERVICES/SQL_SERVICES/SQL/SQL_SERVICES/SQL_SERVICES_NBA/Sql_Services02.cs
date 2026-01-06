using E_APP02.MODELS.NBA_MODEL.NBA_SET_MODEL.NBA_SET_MODEL01;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_TEST;
using E_APP02.TEMPLATE.TEXTS;
using Microsoft.Data.SqlClient;
using System.Data;



namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_NBA
{
    internal class Sql_Services02
    {
        private static string[] data01 = new string[10];
        private  List<string> TeamID = new List<string>();
        private  List<string> Key01 = new List<string>();
        private  List<string> Active = new List<string>();
        private  List<string> City = new List<string>();
        private  List<string> Name = new List<string>();
        private  List<string> LeagueID = new List<string>();
        private  List<string> Conference = new List<string>();
        private  List<string> Division = new List<string>();
        private  List<string> PrimaryColor = new List<string>();
        private  List<string> SecondaryColor = new List<string>();
        private  List<string> TertiaryColor = new List<string>();
        private  List<string> QuaternaryColor = new List<string>();
        private  List<string> WikipediaLogoUrl = new List<string>();
        private  List<string> WikipediaWordMarkUrl = new List<string>();
        private  List<string> GlobalTeamID = new List<string>();
        private  List<string> NbaDotComTeamID = new List<string>();
        private  List<string> HeadCoach = new List<string>();
        private  List<int> Season = new List<int>();
        private  List<int> SeasonType = new List<int>();
        private  List<string?> Key = new List<string?>();
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
        private  List<string> BirthDate = new List<string>();
        private  List<string> BirthCity = new List<string>();
        private  List<string> BirthState = new List<string>();
        private  List<string> BirthCountry = new List<string>();
        private  List<string> Height = new List<string>();
        private  List<string> Weight = new List<string>();
        private  List<int> RefereeID = new List<int>();
        private  List<int> Number = new List<int>();
        private  List<string> College = new List<string>();
        private  List<string> Address = new List<string>();
        private  List<string> State = new List<string>();
        private  List<string> Zip = new List<string>();
        private  List<string> Country = new List<string>();
        private  List<int?> Capacity = new List<int?>();
        private  List<double> GeoLat = new List<double>();
        private  List<double> GeoLong = new List<double>();
        private  List<int> StartYear = new List<int>();
        private  List<int> EndYear = new List<int>();
        private  List<string> Description = new List<string>();
        private  List<DateTime> RegularSeasonStartDate = new List<DateTime>();
        private  List<DateTime> PostSeasonStartDate = new List<DateTime>();
        private  List<string> SeasonType01 = new List<string>();
        private  List<string> ApiSeason = new List<string>();
        private List<string> StadiumID = new List<string>();

        public static List<Nba_Set_Model01> collectiondata01 = new List<Nba_Set_Model01>();
        public static List<Nba_Set_Model02> collectiondata02 = new List<Nba_Set_Model02>();
        public static List<Nba_Set_Model03> collectiondata03 = new List<Nba_Set_Model03>();
        public static List<Nba_Set_Model04> collectiondata04 = new List<Nba_Set_Model04>();
        public static List<Nba_Set_Model05> collectiondata05 = new List<Nba_Set_Model05>();
        public static List<Nba_Set_Model06> collectiondata06 = new List<Nba_Set_Model06>();
        public static List<Nba_Set_Model08> collectiondata08 = new List<Nba_Set_Model08>();

        public string[] data_array = {"first name",//0
                                      "last name",//2
                                      "player ID",//3
                                      "Team name",//4
                                      "Team ID",//5
                                      "Referee ID",//6
                                      "Referee Name",//7
                                      "stadium address",//8
                                      "stadium ID",//9
                                      "stadium Name",//10
                                      "city",//11
                                       "year",//12
        };




        public string insert_players(string input01, string input02, string input03, string input04, string input05, string input06,
                                            string input07, string input08, string input09, string input10, string input11, string input12,
                                            string input13, string input14, string input15, string input16, string input17)
        {
            input01 = input01 ?? "";
            input02 = input02 ?? "";
            input03 = input03 ?? "";
            input04 = input04 ?? "";
            input05 = input05 ?? "";
            input06 = input06 ?? "";
            input07 = input07 ?? "";
            input08 = input08 ?? "";
            input09 = input09 ?? "";
            input10 = input10 ?? "";
            input11 = input11 ?? "";
            input12 = input12 ?? "";
            input13 = input13 ?? "";
            input14 = input14 ?? "";
            input15 = input15 ?? "";
            input16 = input16 ?? "";
            input17 = input17 ?? "";

            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[42].Parameters.Clear();
            Sql_Manager01.cmd[42].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@PlayerID", input01);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@SportsDataID", input02);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@Status", input03);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@TeamID", input04);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@Team", input05);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@Jersey", input06);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@PositionCategory", input07);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@Position", input08);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@FirstName", input09);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@LastName", input10);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@BirthDate", input11);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@BirthCity", input12);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@BirthState", input13);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@BirthCountry", input14);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@GlobalTeamID", input15);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@Height", input16);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@Weight", input17);
            object result = Sql_Manager01.cmd[42].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                data01[0] = "Record already exists";
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                data01[0] = Default_Text01.text02[3]; // success text
            }
            else
            {

                data01[0] = "Unknown result from database";
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public string view_all_players()
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[39].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[39].ExecuteReader())
            {
                while (reader.Read())
                {

                    PlayerID.Add(int.Parse(reader["PlayerID"].ToString()));
                    SportsDataID.Add(reader["SportsDataID"].ToString());
                    Status.Add(reader["Status"].ToString());
                    TeamID.Add(reader["TeamID"].ToString());
                    Team.Add(reader["Team"].ToString());
                    Jersey.Add(reader["Jersey"].ToString());
                    PositionCategory.Add(reader["PositionCategory"].ToString());
                    Position.Add(reader["Position"].ToString());
                    FirstName.Add(reader["FirstName"].ToString());
                    LastName.Add(reader["LastName"].ToString());
                    BirthDate.Add(reader["BirthDate"].ToString());
                    BirthCity.Add(reader["BirthCity"].ToString());
                    BirthState.Add(reader["BirthState"].ToString());
                    BirthCountry.Add(reader["BirthCountry"].ToString());
                    GlobalTeamID.Add(reader["GlobalTeamID"].ToString());
                    Height.Add(reader["Height"].ToString());
                    Weight.Add(reader["Weight"].ToString());
                    data01[0] +=
                   $"{reader["PlayerID"].ToString()}\n" +
                   $"{reader["SportsDataID"].ToString()}\n" +
                   $"{reader["Status"].ToString()}\n" +
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Team"].ToString()}\n" +
                   $"{reader["Jersey"].ToString()}\n" +
                   $"{reader["PositionCategory"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["FirstName"].ToString()}\n" +
                   $"{reader["LastName"].ToString()}\n" +
                   $"{reader["BirthDate"].ToString()}\n" +
                   $"{reader["BirthCity"].ToString()}\n" +
                   $"{reader["BirthState"].ToString()}\n" +
                   $"{reader["BirthCountry"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["Height"].ToString()}\n" +
                   $"{reader["Weight"].ToString()}\n";
                    var collection_set = new Nba_Set_Model02
                    {

                        PlayerID = reader["PlayerID"].ToString(),
                        SportsDataID = reader["SportsDataID"].ToString(),
                        Status = reader["Status"].ToString(),
                        TeamID = reader["TeamID"].ToString(),
                        Team = reader["Team"].ToString(),
                        Jersey = (reader["Jersey"].ToString()),
                        PositionCategory = reader["PositionCategory"].ToString(),
                        Position = reader["Position"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        BirthDate = reader["BirthDate"].ToString(),
                        BirthCity = reader["BirthCity"].ToString(),
                        BirthState = reader["BirthState"].ToString(),
                        BirthCountry = reader["BirthCountry"].ToString(),
                        GlobalTeamID = reader["GlobalTeamID"].ToString(),
                        Height = reader["Height"].ToString(),
                        Weight = reader["Weight"].ToString()
                    };

                    collectiondata02.Add(collection_set);

                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public  string find_player_by_first_and_last_name(string input01, string input02)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[40].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[40].Parameters.Clear();
            Sql_Manager01.cmd[40].Parameters.AddWithValue("@FirstName", input01);
            Sql_Manager01.cmd[40].Parameters.AddWithValue("@LastName", input02);
            using (SqlDataReader reader = Sql_Manager01.cmd[40].ExecuteReader())
            {
                if (reader.Read())
                {
                    PlayerID.Add(int.Parse(reader["PlayerID"].ToString()));
                    SportsDataID.Add(reader["SportsDataID"].ToString());
                    Status.Add(reader["Status"].ToString());
                    TeamID.Add(reader["TeamID"].ToString());
                    Team.Add(reader["Team"].ToString());
                    Jersey.Add(reader["Jersey"].ToString());
                    PositionCategory.Add(reader["PositionCategory"].ToString());
                    Position.Add(reader["Position"].ToString());
                    FirstName.Add(reader["FirstName"].ToString());
                    LastName.Add(reader["LastName"].ToString());
                    BirthDate.Add(reader["BirthDate"].ToString());
                    BirthCity.Add(reader["BirthCity"].ToString());
                    BirthState.Add(reader["BirthState"].ToString());
                    BirthCountry.Add(reader["BirthCountry"].ToString());
                    GlobalTeamID.Add(reader["GlobalTeamID"].ToString());
                    Height.Add(reader["Height"].ToString());
                    Weight.Add(reader["Weight"].ToString());
                    data01[0] =
                   $"{reader["@PlayerID"].ToString()}\n" +
                   $"{reader["SportsDataID"].ToString()}\n" +
                   $"{reader["Status"].ToString()}\n" +
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Team"].ToString()}\n" +
                   $"{reader["Jersey"].ToString()}\n" +
                   $"{reader["PositionCategory"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["FirstName"].ToString()}\n" +
                   $"{reader["LastName"].ToString()}\n" +
                   $"{reader["BirthDate"].ToString()}\n" +
                   $"{reader["BirthCity"].ToString()}\n" +
                   $"{reader["BirthState"].ToString()}\n" +
                   $"{reader["BirthCountry"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["Height"].ToString()}\n" +
                   $"{reader["Weight"].ToString()}\n";
                    var collection_set = new Nba_Set_Model02
                    {

                        PlayerID = reader["PlayerID"].ToString(),
                        SportsDataID = reader["SportsDataID"].ToString(),
                        Status = reader["Status"].ToString(),
                        TeamID = reader["TeamID"].ToString(),
                        Team = reader["Team"].ToString(),
                        Jersey = reader["Jersey"].ToString(),
                        PositionCategory = reader["PositionCategory"].ToString(),
                        Position = reader["Position"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        BirthDate = reader["BirthDate"].ToString(),
                        BirthCity = reader["BirthCity"].ToString(),
                        BirthState = reader["BirthState"].ToString(),
                        BirthCountry = reader["BirthCountry"].ToString(),
                        GlobalTeamID = reader["GlobalTeamID"].ToString(),
                        Height = reader["Height"].ToString(),
                        Weight = reader["Weight"].ToString()
                    };

                    collectiondata02.Add(collection_set);

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public  string find_player_by_id(string input01)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[41].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[41].Parameters.Clear();
            Sql_Manager01.cmd[41].Parameters.AddWithValue("@PlayerID", input01);
            using (SqlDataReader reader = Sql_Manager01.cmd[41].ExecuteReader())
            {
                if (reader.Read())
                {
                    PlayerID.Add(int.Parse(reader["PlayerID"].ToString()));
                    SportsDataID.Add(reader["SportsDataID"].ToString());
                    Status.Add(reader["Status"].ToString());
                    TeamID.Add(reader["TeamID"].ToString());
                    Team.Add(reader["Team"].ToString());
                    Jersey.Add(reader["Jersey"].ToString());
                    PositionCategory.Add(reader["PositionCategory"].ToString());
                    Position.Add(reader["Position"].ToString());
                    FirstName.Add(reader["FirstName"].ToString());
                    LastName.Add(reader["LastName"].ToString());
                    BirthDate.Add(reader["BirthDate"].ToString());
                    BirthCity.Add(reader["BirthCity"].ToString());
                    BirthState.Add(reader["BirthState"].ToString());
                    BirthCountry.Add(reader["BirthCountry"].ToString());
                    GlobalTeamID.Add(reader["GlobalTeamID"].ToString());
                    Height.Add(reader["Height"].ToString());
                    Weight.Add(reader["Weight"].ToString());

                    data01[0] =
                   $"{reader["PlayerID"].ToString()}\n" +
                   $"{reader["SportsDataID"].ToString()}\n" +
                   $"{reader["Status"].ToString()}\n" +
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Team"].ToString()}\n" +
                   $"{reader["Jersey"].ToString()}\n" +
                   $"{reader["PositionCategory"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["FirstName"].ToString()}\n" +
                   $"{reader["LastName"].ToString()}\n" +
                   $"{reader["BirthDate"].ToString()}\n" +
                   $"{reader["BirthCity"].ToString()}\n" +
                   $"{reader["BirthState"].ToString()}\n" +
                   $"{reader["BirthCountry"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["Height"].ToString()}\n" +
                   $"{reader["Weight"].ToString()}\n";

                    var collection_set = new Nba_Set_Model02
                    {

                        PlayerID = reader["PlayerID"].ToString(),
                        SportsDataID = reader["SportsDataID"].ToString(),
                        Status = reader["Status"].ToString(),
                        TeamID = reader["TeamID"].ToString(),
                        Team = reader["Team"].ToString(),
                        Jersey = reader["Jersey"].ToString(),
                        PositionCategory = reader["PositionCategory"].ToString(),
                        Position = reader["Position"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        BirthDate = reader["BirthDate"].ToString(),
                        BirthCity = reader["BirthCity"].ToString(),
                        BirthState = reader["BirthState"].ToString(),
                        BirthCountry = reader["BirthCountry"].ToString(),
                        GlobalTeamID = reader["GlobalTeamID"].ToString(),
                        Height = reader["Height"].ToString(),
                        Weight = reader["Weight"].ToString()
                    };

                    collectiondata02.Add(collection_set);

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }

        public  string insert_team_standings(string input01, string input02, string input03, string input04, string input05, string input06,
                                            string input07, string input08, string input09, string input10, string input11, string input12,
                                            string input13, string input14, string input15, string input16, string input17,
                                            string input18, string input19, string input20, string input21, string input22,
                                            string input23, string input24, string input25, string input26, string input27,
                                            string input28, string input29)
        {



            input01 = input01 ?? "";
            input02 = input02 ?? "";
            input03 = input03 ?? "";
            input04 = input04 ?? "";
            input05 = input05 ?? "";
            input06 = input06 ?? "";
            input07 = input07 ?? "";
            input08 = input08 ?? "";
            input09 = input09 ?? "";
            input10 = input10 ?? "";
            input11 = input11 ?? "";
            input12 = input12 ?? "";
            input13 = input13 ?? "";
            input14 = input14 ?? "";
            input15 = input15 ?? "";
            input16 = input16 ?? "";
            input17 = input17 ?? "";
            input18 = input18 ?? "";
            input19 = input19 ?? "";
            input20 = input20 ?? "";
            input21 = input21 ?? "";
            input22 = input22 ?? "";
            input23 = input23 ?? "";
            input24 = input24 ?? "";
            input25 = input25 ?? "";
            input26 = input26 ?? "";
            input27 = input27 ?? "";
            input28 = input28 ?? "";
            input29 = input29 ?? "";

            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[35].Parameters.Clear();
            Sql_Manager01.cmd[35].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Season", input01);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@SeasonType", input02);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@TeamID", input03);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Key", input04);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@City", input05);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Name", input06);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Conference", input07);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Division", input08);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Wins", input09);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Losses", input10);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Percentage", input11);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@ConferenceWins", input12);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@ConferenceLosses", input13);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@DivisionWins", input14);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@DivisionLosses", input15);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@HomeWins", input16);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@HomeLosses", input17);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@AwayWins", input18);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@AwayLosses", input19);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@LastTenWins", input20);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@LastTenLosses", input21);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@PointsPerGameFor", input22);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@PointsPerGameAgainst", input23);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Streak", input24);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@GamesBack", input25);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@StreakDescription", input26);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@GlobalTeamID", input27);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@ConferenceRank", input28);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@DivisionRank", input29);

            object result = Sql_Manager01.cmd[35].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                data01[0] = "Record already exists";
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                data01[0] = Default_Text01.text02[3]; // success text
            }
            else
            {

                data01[0] = "Unknown result from database";
            }

            Sql_Manager01.conn[5].Close();
            return data01[0]; ;
        }



        public  string find_team_standings_by_teamid(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[36].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[36].Parameters.Clear();
            Sql_Manager01.cmd[36].Parameters.AddWithValue("@TeamID", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[36].ExecuteReader())
            {
                if (reader.Read())
                {
                    TeamID.Add(reader["TeamID"].ToString());
                    Season.Add(int.Parse(reader["Season"].ToString()));
                    SeasonType.Add(int.Parse(reader["SeasonType"].ToString()));
                    Key.Add(reader["Keys"].ToString());
                    City.Add(reader["City"].ToString());
                    Name.Add(reader["Name"].ToString());
                    Conference.Add(reader["@Conference"].ToString());
                    Division.Add(reader["@Division"].ToString());
                    Wins.Add(int.Parse(reader["@Wins"].ToString()));
                    Losses.Add(int.Parse(reader["@Losses"].ToString()));
                    Percentage.Add(double.Parse(reader["@Percentage"].ToString()));
                    ConferenceWins.Add(int.Parse(reader["@ConferenceWins"].ToString()));
                    ConferenceLosses.Add(int.Parse(reader["@ConferenceLosses"].ToString()));
                    DivisionWins.Add(int.Parse(reader["@DivisionWins"].ToString()));
                    DivisionLosses.Add(int.Parse(reader["@DivisionLosses"].ToString()));
                    HomeWins.Add(int.Parse(reader["@HomeWins"].ToString()));
                    HomeLosses.Add(int.Parse(reader["@HomeLosses"].ToString()));
                    AwayWins.Add(int.Parse(reader["@AwayWins"].ToString()));
                    AwayLosses.Add(int.Parse(reader["@AwayLosses"].ToString()));
                    LastTenWins.Add(int.Parse(reader["@LastTenWins"].ToString()));
                    LastTenLosses.Add(int.Parse(reader["@LastTenLosses"].ToString()));
                    PointsPerGameFor.Add(int.Parse(reader["@PointsPerGameFor"].ToString()));
                    PointsPerGameAgainst.Add(int.Parse(reader["@PointsPerGameAgainst"].ToString()));
                    Streak.Add(int.Parse(reader["@Streak"].ToString()));
                    GamesBack.Add(int.Parse(reader["@GamesBack"].ToString()));
                    StreakDescription.Add(reader["@StreakDescription"].ToString());
                    GlobalTeamID.Add(reader["@GlobalTeamID"].ToString());
                    ConferenceRank.Add(int.Parse(reader["@ConferenceRank"].ToString()));
                    DivisionRank.Add(int.Parse(reader["@DivisionRank"].ToString()));




                    data01[0] =
                   $"{reader["@TeamID"].ToString()}\n" +
                   $"{reader["@Season"].ToString()}\n" +
                   $"{reader["@SeasonType"].ToString()}\n" +
                   $"{reader["@TeamID"].ToString()}\n" +
                   $"{reader["@Key"].ToString()}\n" +
                   $"{reader["@City"].ToString()}\n" +
                   $"{reader["@Name"].ToString()}\n" +
                   $"{reader["@Conference"].ToString()}\n" +
                   $"{reader["@Division"].ToString()}\n" +
                   $"{reader["@Wins"].ToString()}\n" +
                   $"{reader["@Losses"].ToString()}\n" +
                   $"{reader["@Percentage"].ToString()}\n" +
                   $"{reader["@ConferenceWins"].ToString()}\n" +
                   $"{reader["@ConferenceLosses"].ToString()}\n" +
                   $"{reader["@DivisionWins"].ToString()}\n" +
                   $"{reader["@DivisionLosses"].ToString()}\n" +
                   $"{reader["@HomeWins"].ToString()}\n" +
                   $"{reader["@HomeLosses"].ToString()}\n" +
                   $"{reader["@AwayWins"].ToString()}\n" +
                   $"{reader["@AwayLosses"].ToString()}\n" +
                   $"{reader["@LastTenWins"].ToString()}\n" +
                   $"{reader["@LastTenLosses"].ToString()}\n" +
                   $"{reader["@PointsPerGameFor"].ToString()}\n" +
                   $"{reader["@PointsPerGameAgainst"].ToString()}\n" +
                   $"{reader["@Streak"].ToString()}\n" +
                   $"{reader["@GamesBack"].ToString()}\n" +
                   $"{reader["@StreakDescription"].ToString()}\n" +
                   $"{reader["@GlobalTeamID"].ToString()}\n" +
                   $"{reader["@ConferenceRank"].ToString()}\n" +
                   $"{reader["@DivisionRank"].ToString()}\n";
                    var collection_set = new Nba_Set_Model01
                    {
                        TeamID = int.Parse(reader["TeamID"].ToString()),
                        Season = int.Parse($"{reader["@Season"].ToString()}"),
                        SeasonType = int.Parse($"{reader["@SeasonType"].ToString()}"),
                        Key = $"{reader["@Key"].ToString()}",
                        City = $"{reader["@City"].ToString()}",
                        Name = $"{reader["@Name"].ToString()}",
                        Conference = $"{reader["@Conference"].ToString()}",
                        Division = $"{reader["@Division"].ToString()}",
                        Wins = int.Parse($"{reader["@Wins"].ToString()}"),
                        Losses = int.Parse($"{reader["@Losses"].ToString()}"),
                        Percentage = double.Parse($"{reader["@Percentage"].ToString()}"),
                        ConferenceWins = int.Parse($"{reader["@ConferenceWins"].ToString()}"),
                        ConferenceLosses = int.Parse($"{reader["@ConferenceLosses"].ToString()}"),
                        DivisionWins = int.Parse($"{reader["@DivisionWins"].ToString()}"),
                        DivisionLosses = int.Parse($"{reader["@DivisionLosses"].ToString()}"),
                        HomeWins = int.Parse($"{reader["@HomeWins"].ToString()}"),
                        HomeLosses = int.Parse($"{reader["@HomeLosses"].ToString()}"),
                        AwayWins = int.Parse($"{reader["@AwayWins"].ToString()}"),
                        AwayLosses = int.Parse($"{reader["@AwayLosses"].ToString()}"),
                        LastTenWins = int.Parse($"{reader["@LastTenWins"].ToString()}"),
                        LastTenLosses = int.Parse($"{reader["@LastTenLosses"].ToString()}"),
                        PointsPerGameFor = double.Parse($"{reader["@PointsPerGameFor"].ToString()}"),
                        PointsPerGameAgainst = double.Parse($"{reader["@PointsPerGameAgainst"].ToString()}"),
                        Streak = int.Parse($"{reader["@Streak"].ToString()}"),
                        GamesBack = double.Parse($"{reader["@GamesBack"].ToString()}"),
                        StreakDescription = $"{reader["@StreakDescription"].ToString()}",
                        GlobalTeamID = int.Parse($"{reader["@GlobalTeamID"].ToString()}"),
                        ConferenceRank = int.Parse($"{reader["@ConferenceRank"].ToString()}"),
                        DivisionRank = int.Parse($"{reader["@DivisionRank"].ToString()}"),
                    };

                    collectiondata01.Add(collection_set);
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public  string find_team_standings_by_name(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[37].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[37].Parameters.Clear();
            Sql_Manager01.cmd[37].Parameters.AddWithValue("@Name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[37].ExecuteReader())
            {
                if (reader.Read())
                {
                    TeamID.Add(reader["TeamID"].ToString());
                    Season.Add(int.Parse(reader["Season"].ToString()));
                    SeasonType.Add(int.Parse(reader["SeasonType"].ToString()));
                    Key.Add(reader["Keys"].ToString());
                    City.Add(reader["City"].ToString());
                    Name.Add(reader["Name"].ToString());
                    Conference.Add(reader["Conference"].ToString());
                    Division.Add(reader["Division"].ToString());
                    Wins.Add(int.Parse(reader["Wins"].ToString()));
                    Losses.Add(int.Parse(reader["Losses"].ToString()));
                    Percentage.Add(double.Parse(reader["Percentage"].ToString()));
                    ConferenceWins.Add(int.Parse(reader["ConferenceWins"].ToString()));
                    ConferenceLosses.Add(int.Parse(reader["ConferenceLosses"].ToString()));
                    DivisionWins.Add(int.Parse(reader["DivisionWins"].ToString()));
                    DivisionLosses.Add(int.Parse(reader["DivisionLosses"].ToString()));
                    HomeWins.Add(int.Parse(reader["HomeWins"].ToString()));
                    HomeLosses.Add(int.Parse(reader["HomeLosses"].ToString()));
                    AwayWins.Add(int.Parse(reader["AwayWins"].ToString()));
                    AwayLosses.Add(int.Parse(reader["AwayLosses"].ToString()));
                    LastTenWins.Add(int.Parse(reader["LastTenWins"].ToString()));
                    LastTenLosses.Add(int.Parse(reader["LastTenLosses"].ToString()));
                    PointsPerGameFor.Add(double.Parse(reader["PointsPerGameFor"].ToString()));
                    PointsPerGameAgainst.Add(double.Parse(reader["PointsPerGameAgainst"].ToString()));
                    Streak.Add(int.Parse(reader["Streak"].ToString()));
                    GamesBack.Add(int.Parse(reader["GamesBack"].ToString()));
                    StreakDescription.Add(reader["StreakDescription"].ToString());
                    GlobalTeamID.Add(reader["GlobalTeamID"].ToString());
                    ConferenceRank.Add(int.Parse(reader["ConferenceRank"].ToString()));
                    DivisionRank.Add(int.Parse(reader["DivisionRank"].ToString()));
                    data01[0] =
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Season"].ToString()}\n" +
                   $"{reader["SeasonType"].ToString()}\n" +
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Keys"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Conference"].ToString()}\n" +
                   $"{reader["Division"].ToString()}\n" +
                   $"{reader["Wins"].ToString()}\n" +
                   $"{reader["Losses"].ToString()}\n" +
                   $"{reader["Percentage"].ToString()}\n" +
                   $"{reader["ConferenceWins"].ToString()}\n" +
                   $"{reader["ConferenceLosses"].ToString()}\n" +
                   $"{reader["DivisionWins"].ToString()}\n" +
                   $"{reader["DivisionLosses"].ToString()}\n" +
                   $"{reader["HomeWins"].ToString()}\n" +
                   $"{reader["HomeLosses"].ToString()}\n" +
                   $"{reader["AwayWins"].ToString()}\n" +
                   $"{reader["AwayLosses"].ToString()}\n" +
                   $"{reader["LastTenWins"].ToString()}\n" +
                   $"{reader["LastTenLosses"].ToString()}\n" +
                   $"{reader["PointsPerGameFor"].ToString()}\n" +
                   $"{reader["PointsPerGameAgainst"].ToString()}\n" +
                   $"{reader["Streak"].ToString()}\n" +
                   $"{reader["GamesBack"].ToString()}\n" +
                   $"{reader["StreakDescription"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["ConferenceRank"].ToString()}\n" +
                   $"{reader["DivisionRank"].ToString()}\n";
                    var collection_set = new Nba_Set_Model01
                    {
                        TeamID = int.Parse(reader["TeamID"].ToString()),
                        Season = int.Parse($"{reader["Season"].ToString()}"),
                        SeasonType = int.Parse($"{reader["SeasonType"].ToString()}"),
                        Key = $"{reader["Keys"].ToString()}",
                        City = $"{reader["City"].ToString()}",
                        Name = $"{reader["Name"].ToString()}",
                        Conference = $"{reader["Conference"].ToString()}",
                        Division = $"{reader["Division"].ToString()}",
                        Wins = int.Parse($"{reader["Wins"].ToString()}"),
                        Losses = int.Parse($"{reader["Losses"].ToString()}"),
                        Percentage = double.Parse($"{reader["Percentage"].ToString()}"),
                        ConferenceWins = int.Parse($"{reader["ConferenceWins"].ToString()}"),
                        ConferenceLosses = int.Parse($"{reader["ConferenceLosses"].ToString()}"),
                        DivisionWins = int.Parse($"{reader["DivisionWins"].ToString()}"),
                        DivisionLosses = int.Parse($"{reader["DivisionLosses"].ToString()}"),
                        HomeWins = int.Parse($"{reader["HomeWins"].ToString()}"),
                        HomeLosses = int.Parse($"{reader["HomeLosses"].ToString()}"),
                        AwayWins = int.Parse($"{reader["AwayWins"].ToString()}"),
                        AwayLosses = int.Parse($"{reader["AwayLosses"].ToString()}"),
                        LastTenWins = int.Parse($"{reader["LastTenWins"].ToString()}"),
                        LastTenLosses = int.Parse($"{reader["LastTenLosses"].ToString()}"),
                        PointsPerGameFor = double.Parse($"{reader["PointsPerGameFor"].ToString()}"),
                        PointsPerGameAgainst = double.Parse($"{reader["PointsPerGameAgainst"].ToString()}"),
                        Streak = int.Parse($"{reader["Streak"].ToString()}"),
                        GamesBack = double.Parse($"{reader["GamesBack"].ToString()}"),
                        StreakDescription = $"{reader["StreakDescription"].ToString()}",
                        GlobalTeamID = int.Parse($"{reader["GlobalTeamID"].ToString()}"),
                        ConferenceRank = int.Parse($"{reader["ConferenceRank"].ToString()}"),
                        DivisionRank = int.Parse($"{reader["DivisionRank"].ToString()}"),
                    };

                    collectiondata01.Add(collection_set);
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }


        public string insert_team_all(string input00, string input01, string input02, string input03, string input04, string input05, string input06,
                                            string input07, string input08, string input09, string input10, string input11, string input12,
                                            string input13, string input14, string input15, string input16, string input17)
        {
            input00 = input00 ?? "";
            input01 = input01 ?? "";
            input02 = input02 ?? "";
            input03 = input03 ?? "";
            input04 = input04 ?? "";
            input05 = input05 ?? "";
            input06 = input06 ?? "";
            input07 = input07 ?? "";
            input08 = input08 ?? "";
            input09 = input09 ?? "";
            input10 = input10 ?? "";
            input11 = input11 ?? "";
            input12 = input12 ?? "";
            input13 = input13 ?? "";
            input14 = input14 ?? "";
            input15 = input15 ?? "";
            input16 = input16 ?? "";
            input17 = input17 ?? "";
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[56].Parameters.Clear();
            Sql_Manager01.cmd[56].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@TeamID", input00);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@Keys", input01);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@Active", input02);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@City", input03);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@Name", input04);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@LeagueID", input05);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@StadiumID", input06);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@Conference", input07);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@Division", input08);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@PrimaryColor", input09);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@SecondaryColor", input10);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@TertiaryColor", input11);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@QuaternaryColor", input12);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@WikipediaLogoUrl", input13);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@WikipediaWordMarkUrl", input14);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@GlobalTeamID", input15);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@NbaDotComTeamID", input16);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@HeadCoach", input17);
            object result = Sql_Manager01.cmd[56].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                data01[0] = "Record already exists";
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                data01[0] = Default_Text01.text02[3]; // success text
            }
            else
            {

                data01[0] = "Unknown result from database";
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }


        public string find_team_by_id(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[34].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[34].Parameters.Clear();
            Sql_Manager01.cmd[34].Parameters.AddWithValue("@TeamID", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[34].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] =
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Keys"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["LeagueID"].ToString()}\n" +
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Conference"].ToString()}\n" +
                   $"{reader["Division"].ToString()}\n" +
                   $"{reader["PrimaryColor"].ToString()}\n" +
                   $"{reader["SecondaryColor"].ToString()}\n" +
                   $"{reader["TertiaryColor"].ToString()}\n" +
                   $"{reader["QuaternaryColor"].ToString()}\n" +
                   $"{reader["WikipediaLogoUrl"].ToString()}\n" +
                   $"{reader["WikipediaWordMarkUrl"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["NbaDotComTeamID"].ToString()}\n" +
                   $"{reader["HeadCoach"].ToString()}\n";
                    var collection_set = new Nba_Set_Model03
                    {
                        TeamID = int.Parse(reader["TeamID"].ToString()),
                        Key = reader["Keys"].ToString(),
                        Active = bool.Parse(reader["Active"].ToString()),
                        City = reader["City"].ToString(),
                        Name = reader["Name"].ToString(),
                        LeagueID = int.Parse(reader["LeagueID"].ToString()),
                        StadiumID = int.Parse(reader["StadiumID"].ToString()),
                        Conference = reader["Conference"].ToString(),
                        Division = reader["Division"].ToString(),
                        PrimaryColor = reader["PrimaryColor"].ToString(),
                        SecondaryColor = reader["SecondaryColor"].ToString(),
                        TertiaryColor = reader["TertiaryColor"].ToString(),
                        QuaternaryColor = reader["QuaternaryColor"].ToString(),
                        WikipediaLogoUrl = reader["WikipediaLogoUrl"].ToString(),
                        WikipediaWordMarkUrl = reader["WikipediaWordMarkUrl"].ToString(),
                        GlobalTeamID = int.Parse(reader["GlobalTeamID"].ToString()),
                        NbaDotComTeamID = int.Parse(reader["NbaDotComTeamID"].ToString()),
                        HeadCoach = reader["HeadCoach"].ToString(),

                    };

                    collectiondata03.Add(collection_set);
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public string find_team_by_name(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[33].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[33].Parameters.Clear();
            Sql_Manager01.cmd[33].Parameters.AddWithValue("@Name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[33].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] =
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["@Keys"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["LeagueID"].ToString()}\n" +
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Conference"].ToString()}\n" +
                   $"{reader["Division"].ToString()}\n" +
                   $"{reader["PrimaryColor"].ToString()}\n" +
                   $"{reader["SecondaryColor"].ToString()}\n" +
                   $"{reader["TertiaryColor"].ToString()}\n" +
                   $"{reader["QuaternaryColor"].ToString()}\n" +
                   $"{reader["WikipediaLogoUrl"].ToString()}\n" +
                   $"{reader["WikipediaWordMarkUrl"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["NbaDotComTeamID"].ToString()}\n" +
                   $"{reader["HeadCoach"].ToString()}\n";
                    var collection_set = new Nba_Set_Model03
                    {
                        TeamID = int.Parse(reader["TeamID"].ToString()),
                        Key = reader["Keys"].ToString(),
                        Active = bool.Parse(reader["Active"].ToString()),
                        City = reader["City"].ToString(),
                        Name = reader["Name"].ToString(),
                        LeagueID = int.Parse(reader["LeagueID"].ToString()),
                        StadiumID = int.Parse(reader["StadiumID"].ToString()),
                        Conference = reader["Conference"].ToString(),
                        Division = reader["Division"].ToString(),
                        PrimaryColor = reader["PrimaryColor"].ToString(),
                        SecondaryColor = reader["SecondaryColor"].ToString(),
                        TertiaryColor = reader["TertiaryColor"].ToString(),
                        QuaternaryColor = reader["QuaternaryColor"].ToString(),
                        WikipediaLogoUrl = reader["WikipediaLogoUrl"].ToString(),
                        WikipediaWordMarkUrl = reader["WikipediaWordMarkUrl"].ToString(),
                        GlobalTeamID = int.Parse(reader["GlobalTeamID"].ToString()),
                        NbaDotComTeamID = int.Parse(reader["NbaDotComTeamID"].ToString()),
                        HeadCoach = reader["HeadCoach"].ToString(),

                    };

                    collectiondata03.Add(collection_set);
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public string view_team_names()
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[55].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[55].ExecuteReader())
            {
                while (reader.Read())
                {


                    TeamID.Add(reader["TeamID"].ToString());
                    Key01.Add(reader["Keys"].ToString());
                    Active.Add(reader["Active"].ToString());
                    City.Add(reader["City"].ToString());
                    Name.Add(reader["Name"].ToString());
                    LeagueID.Add(reader["LeagueID"].ToString());
                    StadiumID.Add(reader["StadiumID"].ToString());
                    Conference.Add(reader["Conference"].ToString());
                    Division.Add(reader["Division"].ToString());
                    PrimaryColor.Add(reader["PrimaryColor"].ToString());
                    SecondaryColor.Add(reader["SecondaryColor"].ToString());
                    TertiaryColor.Add(reader["TertiaryColor"].ToString());
                    QuaternaryColor.Add(reader["QuaternaryColor"].ToString());
                    WikipediaLogoUrl.Add(reader["WikipediaLogoUrl"].ToString());
                    WikipediaWordMarkUrl.Add(reader["WikipediaWordMarkUrl"].ToString());
                    GlobalTeamID.Add(reader["GlobalTeamID"].ToString());
                    NbaDotComTeamID.Add(reader["NbaDotComTeamID"].ToString());
                    HeadCoach.Add(reader["HeadCoach"].ToString());

                    data01[0] +=
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Keys"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["LeagueID"].ToString()}\n" +
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Conference"].ToString()}\n" +
                   $"{reader["Division"].ToString()}\n" +
                   $"{reader["PrimaryColor"].ToString()}\n" +
                   $"{reader["SecondaryColor"].ToString()}\n" +
                   $"{reader["TertiaryColor"].ToString()}\n" +
                   $"{reader["QuaternaryColor"].ToString()}\n" +
                   $"{reader["WikipediaLogoUrl"].ToString()}\n" +
                   $"{reader["WikipediaWordMarkUrl"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["NbaDotComTeamID"].ToString()}\n" +
                   $"{reader["HeadCoach"].ToString()}\n";
                    var collection_set = new Nba_Set_Model03
                    {
                        TeamID = int.Parse(reader["TeamID"].ToString()),
                        Key = reader["Keys"].ToString(),
                        Active = bool.Parse(reader["Active"].ToString()),
                        City = reader["City"].ToString(),
                        Name = reader["Name"].ToString(),
                        LeagueID = int.Parse(reader["LeagueID"].ToString()),
                        StadiumID = int.Parse(reader["StadiumID"].ToString()),
                        Conference = reader["Conference"].ToString(),
                        Division = reader["Division"].ToString(),
                        PrimaryColor = reader["PrimaryColor"].ToString(),
                        SecondaryColor = reader["SecondaryColor"].ToString(),
                        TertiaryColor = reader["TertiaryColor"].ToString(),
                        QuaternaryColor = reader["QuaternaryColor"].ToString(),
                        WikipediaLogoUrl = reader["WikipediaLogoUrl"].ToString(),
                        WikipediaWordMarkUrl = reader["WikipediaWordMarkUrl"].ToString(),
                        GlobalTeamID = int.Parse(reader["GlobalTeamID"].ToString()),
                        NbaDotComTeamID = int.Parse(reader["NbaDotComTeamID"].ToString()),
                        HeadCoach = reader["HeadCoach"].ToString(),

                    };

                    collectiondata03.Add(collection_set);

                }
            }


            data01[1] +=

           $"{string.Join(" ", TeamID)}\n" +
           $"{string.Join(" ", Key01)}\n" +
           $"{string.Join(" ", Active)}\n" +
           $"{string.Join(" ", City)}\n" +
           $"{string.Join(" ", Name)}\n" +
           $"{string.Join(" ", LeagueID)}\n" +
           $"{string.Join(" ", StadiumID)}\n" +
           $"{string.Join(" ", Conference)}\n" +
           $"{string.Join(" ", Division)}\n" +
           $"{string.Join(" ", PrimaryColor)}\n" +
           $"{string.Join(" ", SecondaryColor)}\n" +
           $"{string.Join(" ", TertiaryColor)}\n" +
           $"{string.Join(" ", QuaternaryColor)}\n" +
           $"{string.Join(" ", WikipediaLogoUrl)}\n" +
           $"{string.Join(" ", WikipediaWordMarkUrl)}\n" +
           $"{string.Join(" ", GlobalTeamID)}\n" +
           $"{string.Join(" ", NbaDotComTeamID)}\n" +
           $"{string.Join(" ", HeadCoach)}\n";

            return data01[1];
        }


        public string find_Referee_by_id(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[44].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[44].Parameters.Clear();
            Sql_Manager01.cmd[44].Parameters.AddWithValue("@RefereeID", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[44].ExecuteReader())
            {
                if (reader.Read())
                {
                    RefereeID.Add(int.Parse(reader["RefereeID"].ToString()));
                    Name.Add(reader["Name"].ToString());
                    Number.Add(int.Parse(reader["Number"].ToString()));
                    Position.Add(reader["Position"].ToString());
                    College.Add(reader["College"].ToString());

                    data01[0] =
                   $"{reader["RefereeID"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Number"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["College"].ToString()}\n";

                    var collection_set = new Nba_Set_Model04
                    {
                        RefereeID = int.Parse(reader["RefereeID"].ToString()),
                        Name = reader["Name"].ToString(),
                        Number = int.Parse(reader["Number"].ToString()),
                        Position = reader["Position"].ToString(),
                        College = reader["College"].ToString(),
                    };
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public string find_Referee_by_name(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[45].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[45].Parameters.Clear();
            Sql_Manager01.cmd[45].Parameters.AddWithValue("@Name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[45].ExecuteReader())
            {
                if (reader.Read())
                {
                    RefereeID.Add(int.Parse(reader["RefereeID"].ToString()));
                    Name.Add(reader["Name"].ToString());
                    Number.Add(int.Parse(reader["Number"].ToString()));
                    Position.Add(reader["Position"].ToString());
                    College.Add(reader["College"].ToString());

                    data01[0] =
                   $"{reader["RefereeID"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Number"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["College"].ToString()}\n";

                    var collection_set = new Nba_Set_Model04
                    {
                        RefereeID = int.Parse(reader["RefereeID"].ToString()),
                        Name = reader["Name"].ToString(),
                        Number = int.Parse(reader["Number"].ToString()),
                        Position = reader["Position"].ToString(),
                        College = reader["College"].ToString(),
                    };
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
                return data01[0];
            }
        }
        public string insert_Referee(string input00, string input01, string input02, string input03, string input04)
        {
            input00 = input00 ?? "";
            input01 = input01 ?? "";
            input02 = input02 ?? "";
            input03 = input03 ?? "";
            input04 = input04 ?? "";

            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[51].Parameters.Clear();
            Sql_Manager01.cmd[51].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[51].Parameters.AddWithValue("@RefereeID", input00);
            Sql_Manager01.cmd[51].Parameters.AddWithValue("@Name", input01);
            Sql_Manager01.cmd[51].Parameters.AddWithValue("@Number", input02);
            Sql_Manager01.cmd[51].Parameters.AddWithValue("@Position", input03);
            Sql_Manager01.cmd[51].Parameters.AddWithValue("@College", input04);
            object result = Sql_Manager01.cmd[51].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                data01[0] = "Record already exists";
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                data01[0] = Default_Text01.text02[3]; // success text
            }
            else
            {

                data01[0] = "Unknown result from database";
            }

            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public string view_all_Referee()
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[44].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[44].ExecuteReader())
            {
                while (reader.Read())
                {
                    RefereeID.Add(int.Parse(reader["RefereeID"].ToString()));
                    Name.Add(reader["Name"].ToString());
                    Number.Add(int.Parse(reader["Number"].ToString()));
                    Position.Add(reader["Position"].ToString());
                    College.Add(reader["College"].ToString());

                    data01[0] +=
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["RefereeID"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Number"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["College"].ToString()}\n";
                    var collection_set = new Nba_Set_Model04
                    {

                        RefereeID = int.Parse(reader["TeamID"].ToString()),
                        Name = reader["TeamID"].ToString(),
                        Number = int.Parse(reader["TeamID"].ToString()),
                        Position = reader["TeamID"].ToString(),
                        College = reader["TeamID"].ToString(),

                    };

                    collectiondata04.Add(collection_set);

                }
            }


            data01[1] +=
                      $"{string.Join(" ", TeamID)}\n" +
                      $"{string.Join(" ", RefereeID)}\n" +
                      $"{string.Join(" ", Name)}\n" +
                      $"{string.Join(" ", Number)}\n" +
                      $"{string.Join(" ", Position)}\n" +
                      $"{string.Join(" ", College)}\n";


            return data01[1];
        }








        public string find_Stadium_by_Address(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[50].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[50].Parameters.Clear();
            Sql_Manager01.cmd[50].Parameters.AddWithValue("@Address", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[51].ExecuteReader())
            {
                if (reader.Read())
                {

                    StadiumID.Add(reader["StadiumID"]?.ToString() ?? string.Empty);
                    Active.Add(reader["Active"]?.ToString() ?? string.Empty);
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Address.Add(reader["Address"]?.ToString() ?? string.Empty);
                    City.Add(reader["City"]?.ToString() ?? string.Empty);
                    State.Add(reader["State"]?.ToString() ?? string.Empty);
                    Zip.Add(reader["Zip"]?.ToString() ?? string.Empty);
                    Country.Add(reader["Country"]?.ToString() ?? string.Empty);
                    Capacity.Add(int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal) ? capacityVal : (int?)null);
                    GeoLat.Add(double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal) ? geoLatVal : 0.0);
                    GeoLong.Add(double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal) ? geoLongVal : 0.0);

                    data01[0] =
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Address"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["State"].ToString()}\n" +
                   $"{reader["Zip"].ToString()}\n" +
                   $"{reader["Country"].ToString()}\n" +
                   $"{reader["Capacity"].ToString()}\n" +
                   $"{reader["GeoLat"].ToString()}\n" +
                   $"{reader["GeoLong"].ToString()}\n";
                    var collection_set = new Nba_Set_Model05
                    {
                        StadiumID = int.TryParse(reader["StadiumID"]?.ToString(), out var stadiumIdVal) ? stadiumIdVal : 0,
                        Active = bool.TryParse(reader["Active"]?.ToString(), out var activeVal) ? activeVal : false,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Address = reader["Address"]?.ToString() ?? string.Empty,
                        City = reader["City"]?.ToString() ?? string.Empty,
                        State = reader["State"]?.ToString() ?? string.Empty,
                        Zip = reader["Zip"]?.ToString() ?? string.Empty,
                        Country = reader["Country"]?.ToString() ?? string.Empty,
                        Capacity = int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal2) ? capacityVal2 : (int?)null,
                        GeoLat = double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal2) ? geoLatVal2 : 0.0,
                        GeoLong = double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal2) ? geoLongVal2 : 0.0,
                    };
                    collectiondata05.Add(collection_set);
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }

        public string find_Stadium_by_City(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[50].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[50].Parameters.Clear();
            Sql_Manager01.cmd[50].Parameters.AddWithValue("@City", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[50].ExecuteReader())
            {
                if (reader.Read())
                {

                    StadiumID.Add(reader["StadiumID"]?.ToString() ?? string.Empty);
                    Active.Add(reader["Active"]?.ToString() ?? string.Empty);
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Address.Add(reader["Address"]?.ToString() ?? string.Empty);
                    City.Add(reader["City"]?.ToString() ?? string.Empty);
                    State.Add(reader["State"]?.ToString() ?? string.Empty);
                    Zip.Add(reader["Zip"]?.ToString() ?? string.Empty);
                    Country.Add(reader["Country"]?.ToString() ?? string.Empty);
                    Capacity.Add(int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal) ? capacityVal : (int?)null);
                    GeoLat.Add(double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal) ? geoLatVal : 0.0);
                    GeoLong.Add(double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal) ? geoLongVal : 0.0);

                    data01[0] =
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Address"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["State"].ToString()}\n" +
                   $"{reader["Zip"].ToString()}\n" +
                   $"{reader["Country"].ToString()}\n" +
                   $"{reader["Capacity"].ToString()}\n" +
                   $"{reader["GeoLat"].ToString()}\n" +
                   $"{reader["GeoLong"].ToString()}\n";
                    var collection_set = new Nba_Set_Model05
                    {
                        StadiumID = int.TryParse(reader["StadiumID"]?.ToString(), out var stadiumIdVal) ? stadiumIdVal : 0,
                        Active = bool.TryParse(reader["Active"]?.ToString(), out var activeVal) ? activeVal : false,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Address = reader["Address"]?.ToString() ?? string.Empty,
                        City = reader["City"]?.ToString() ?? string.Empty,
                        State = reader["State"]?.ToString() ?? string.Empty,
                        Zip = reader["Zip"]?.ToString() ?? string.Empty,
                        Country = reader["Country"]?.ToString() ?? string.Empty,
                        Capacity = int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal2) ? capacityVal2 : (int?)null,
                        GeoLat = double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal2) ? geoLatVal2 : 0.0,
                        GeoLong = double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal2) ? geoLongVal2 : 0.0,
                    };
                    collectiondata05.Add(collection_set);
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }


        public string find_Stadium_by_id(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[49].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[49].Parameters.Clear();
            Sql_Manager01.cmd[49].Parameters.AddWithValue("@StadiumID", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[49].ExecuteReader())
            {
                if (reader.Read())
                {

                    StadiumID.Add(reader["StadiumID"]?.ToString() ?? string.Empty);
                    Active.Add(reader["Active"]?.ToString() ?? string.Empty);
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Address.Add(reader["Address"]?.ToString() ?? string.Empty);
                    City.Add(reader["City"]?.ToString() ?? string.Empty);
                    State.Add(reader["State"]?.ToString() ?? string.Empty);
                    Zip.Add(reader["Zip"]?.ToString() ?? string.Empty);
                    Country.Add(reader["Country"]?.ToString() ?? string.Empty);
                    Capacity.Add(int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal) ? capacityVal : (int?)null);
                    GeoLat.Add(double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal) ? geoLatVal : 0.0);
                    GeoLong.Add(double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal) ? geoLongVal : 0.0);

                    data01[0] =
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Address"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["State"].ToString()}\n" +
                   $"{reader["Zip"].ToString()}\n" +
                   $"{reader["Country"].ToString()}\n" +
                   $"{reader["Capacity"].ToString()}\n" +
                   $"{reader["GeoLat"].ToString()}\n" +
                   $"{reader["GeoLong"].ToString()}\n";
                    var collection_set = new Nba_Set_Model05
                    {
                        StadiumID = int.TryParse(reader["StadiumID"]?.ToString(), out var stadiumIdVal) ? stadiumIdVal : 0,
                        Active = bool.TryParse(reader["Active"]?.ToString(), out var activeVal) ? activeVal : false,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Address = reader["Address"]?.ToString() ?? string.Empty,
                        City = reader["City"]?.ToString() ?? string.Empty,
                        State = reader["State"]?.ToString() ?? string.Empty,
                        Zip = reader["Zip"]?.ToString() ?? string.Empty,
                        Country = reader["Country"]?.ToString() ?? string.Empty,
                        Capacity = int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal2) ? capacityVal2 : (int?)null,
                        GeoLat = double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal2) ? geoLatVal2 : 0.0,
                        GeoLong = double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal2) ? geoLongVal2 : 0.0,
                    };
                    collectiondata05.Add(collection_set);
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }

        public string find_Stadium_by_name(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[48].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[48].Parameters.Clear();
            Sql_Manager01.cmd[48].Parameters.AddWithValue("@Name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[48].ExecuteReader())
            {
                if (reader.Read())
                {

                    StadiumID.Add(reader["StadiumID"]?.ToString() ?? string.Empty);
                    Active.Add(reader["Active"]?.ToString() ?? string.Empty);
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Address.Add(reader["Address"]?.ToString() ?? string.Empty);
                    City.Add(reader["City"]?.ToString() ?? string.Empty);
                    State.Add(reader["State"]?.ToString() ?? string.Empty);
                    Zip.Add(reader["Zip"]?.ToString() ?? string.Empty);
                    Country.Add(reader["Country"]?.ToString() ?? string.Empty);
                    Capacity.Add(int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal) ? capacityVal : (int?)null);
                    GeoLat.Add(double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal) ? geoLatVal : 0.0);
                    GeoLong.Add(double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal) ? geoLongVal : 0.0);

                    data01[0] =
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Address"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["State"].ToString()}\n" +
                   $"{reader["Zip"].ToString()}\n" +
                   $"{reader["Country"].ToString()}\n" +
                   $"{reader["Capacity"].ToString()}\n" +
                   $"{reader["GeoLat"].ToString()}\n" +
                   $"{reader["GeoLong"].ToString()}\n";
                    var collection_set = new Nba_Set_Model05
                    {
                        StadiumID = int.TryParse(reader["StadiumID"]?.ToString(), out var stadiumIdVal) ? stadiumIdVal : 0,
                        Active = bool.TryParse(reader["Active"]?.ToString(), out var activeVal) ? activeVal : false,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Address = reader["Address"]?.ToString() ?? string.Empty,
                        City = reader["City"]?.ToString() ?? string.Empty,
                        State = reader["State"]?.ToString() ?? string.Empty,
                        Zip = reader["Zip"]?.ToString() ?? string.Empty,
                        Country = reader["Country"]?.ToString() ?? string.Empty,
                        Capacity = int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal2) ? capacityVal2 : (int?)null,
                        GeoLat = double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal2) ? geoLatVal2 : 0.0,
                        GeoLong = double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal2) ? geoLongVal2 : 0.0,
                    };
                    collectiondata05.Add(collection_set);
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }

        public string insert_Stadium(string input01, string input02, string input03, string input04, string input05, string input06,
                                            string input07, string input08, string input09, string input10, string input11)
        {

            input01 = input01 ?? "";
            input02 = input02 ?? "";
            input03 = input03 ?? "";
            input04 = input04 ?? "";
            input05 = input05 ?? "";
            input06 = input06 ?? "";
            input07 = input07 ?? "";
            input08 = input08 ?? "";
            input09 = input09 ?? "";
            input10 = input10 ?? "";
            input11 = input11 ?? "";
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[46].Parameters.Clear();
            Sql_Manager01.cmd[46].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@StadiumID", input01);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@Active", input02);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@Name", input03);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@Address", input04);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@City", input05);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@State", input06);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@Zip", input07);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@Country", input08);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@Capacity", input09);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@GeoLat", input10);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@GeoLong", input11);
            object result = Sql_Manager01.cmd[46].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                data01[0] = "Record already exists";
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                data01[0] = Default_Text01.text02[3]; // success text
            }
            else
            {

                data01[0] = "Unknown result from database";
            }

            Sql_Manager01.conn[5].Close();
            return data01[0];
            ;
        }
        public string view_all_Stadium()
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[53].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[53].ExecuteReader())
            {
                while (reader.Read())
                {
                    StadiumID.Add(reader["StadiumID"]?.ToString() ?? string.Empty);
                    Active.Add(reader["Active"]?.ToString() ?? string.Empty);
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Address.Add(reader["Address"]?.ToString() ?? string.Empty);
                    City.Add(reader["City"]?.ToString() ?? string.Empty);
                    State.Add(reader["State"]?.ToString() ?? string.Empty);
                    Zip.Add(reader["Zip"]?.ToString() ?? string.Empty);
                    Country.Add(reader["Country"]?.ToString() ?? string.Empty);
                    Capacity.Add(int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal) ? capacityVal : (int?)null);
                    GeoLat.Add(double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal) ? geoLatVal : 0.0);
                    GeoLong.Add(double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal) ? geoLongVal : 0.0);

                    data01[0] =
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Address"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["State"].ToString()}\n" +
                   $"{reader["Zip"].ToString()}\n" +
                   $"{reader["Country"].ToString()}\n" +
                   $"{reader["Capacity"].ToString()}\n" +
                   $"{reader["GeoLat"].ToString()}\n" +
                   $"{reader["GeoLong"].ToString()}\n";
                    var collection_set = new Nba_Set_Model05
                    {
                        StadiumID = int.TryParse(reader["StadiumID"]?.ToString(), out var stadiumIdVal) ? stadiumIdVal : 0,
                        Active = bool.TryParse(reader["Active"]?.ToString(), out var activeVal) ? activeVal : false,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Address = reader["Address"]?.ToString() ?? string.Empty,
                        City = reader["City"]?.ToString() ?? string.Empty,
                        State = reader["State"]?.ToString() ?? string.Empty,
                        Zip = reader["Zip"]?.ToString() ?? string.Empty,
                        Country = reader["Country"]?.ToString() ?? string.Empty,
                        Capacity = int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal2) ? capacityVal2 : (int?)null,
                        GeoLat = double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal2) ? geoLatVal2 : 0.0,
                        GeoLong = double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal2) ? geoLongVal2 : 0.0,
                    };
                    collectiondata05.Add(collection_set);
                }
            }
            return data01[0];
        }

        public string find_Season(string input01)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[53].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[53].Parameters.Clear();
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@Season", input01);
            using (SqlDataReader reader = Sql_Manager01.cmd[53].ExecuteReader())
            {
                if (reader.Read())
                {

                    Season.Add(int.Parse(reader["Season"].ToString()));
                    StartYear.Add(int.Parse(reader["StartYear"].ToString()));
                    EndYear.Add(int.Parse(reader["EndYear"].ToString()));
                    Description.Add(reader["Description"].ToString());
                    RegularSeasonStartDate.Add(DateTime.Parse(reader["RegularSeasonStartDate"].ToString()));
                    PostSeasonStartDate.Add(DateTime.Parse(reader["PostSeasonStartDate"].ToString()));
                    SeasonType01.Add(reader["SeasonType01"].ToString());
                    ApiSeason.Add(reader["ApiSeason"].ToString());
                    data01[0] =
                   $"{reader["SeasonID"].ToString()}\n" +
                   $"{reader["Season"].ToString()}\n" +
                   $"{reader["StartYear"].ToString()}\n" +
                   $"{reader["EndYear"].ToString()}\n" +
                   $"{reader["Description"].ToString()}\n" +
                   $"{reader["RegularSeasonStartDate"].ToString()}\n" +
                   $"{reader["PostSeasonStartDate"].ToString()}\n" +
                   $"{reader["SeasonType01"].ToString()}\n" +
                   $"{reader["ApiSeason"].ToString()}\n";
                    var collection_set = new Nba_Set_Model08
                    {
                        Season = (int.Parse(reader["Season"].ToString())),
                        StartYear = (int.Parse(reader["StartYear"].ToString())),
                        EndYear = (int.Parse(reader["EndYear"].ToString())),
                        Description = (reader["Description"].ToString()),
                        RegularSeasonStartDate = (DateTime.Parse(reader["RegularSeasonStartDate"].ToString())),
                        PostSeasonStartDate = (DateTime.Parse(reader["PostSeasonStartDate"].ToString())),
                        SeasonType01 = (reader["SeasonType01"].ToString()),
                        ApiSeason = (reader["ApiSeason"].ToString()),
                    };
                    collectiondata08.Add(collection_set);
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public string insert_season(string input00, string input01, string input02, string input03, string input04, string input05, string input06,
                                            string input07, string input08)
        {
            input00 = input00 ?? "";
            input01 = input01 ?? "";
            input02 = input02 ?? "";
            input03 = input03 ?? "";
            input04 = input04 ?? "";
            input05 = input05 ?? "";
            input06 = input06 ?? "";
            input07 = input07 ?? "";
            input08 = input08 ?? "";

            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[53].Parameters.Clear();
            Sql_Manager01.cmd[53].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@SeasonID", input00);
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@Season", input01);
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@StartYear", input02);
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@EndYear", input03);
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@Description", input04);
            Sql_Manager01.cmd[54].Parameters.AddWithValue("@RegularSeasonStartDate", input05);
            Sql_Manager01.cmd[54].Parameters.AddWithValue("@PostSeasonStartDate", input06);
            Sql_Manager01.cmd[54].Parameters.AddWithValue("@SeasonType01", input07);
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@ApiSeason", input08);
            object result = Sql_Manager01.cmd[53].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                data01[0] = "Record already exists";
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                data01[0] = Default_Text01.text02[3]; // success text
            }
            else
            {

                data01[0] = "Unknown result from database";
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public string view_season()
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[54].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[54].ExecuteReader())
            {
                while (reader.Read())
                {
                    Season.Add(int.Parse(reader["Season"].ToString()));
                    StartYear.Add(int.Parse(reader["StartYear"].ToString()));
                    EndYear.Add(int.Parse(reader["EndYear"].ToString()));
                    Description.Add(reader["Description"].ToString());
                    RegularSeasonStartDate.Add(DateTime.Parse(reader["RegularSeasonStartDate"].ToString()));
                    PostSeasonStartDate.Add(DateTime.Parse(reader["PostSeasonStartDate"].ToString()));
                    SeasonType01.Add(reader["SeasonType01"].ToString());
                    ApiSeason.Add(reader["ApiSeason"].ToString());
                    data01[0] +=
                   $"{reader["SeasonID"].ToString()}\n" +
                   $"{reader["Season"].ToString()}\n" +
                   $"{reader["StartYear"].ToString()}\n" +
                   $"{reader["EndYear"].ToString()}\n" +
                   $"{reader["Description"].ToString()}\n" +
                   $"{reader["RegularSeasonStartDate"].ToString()}\n" +
                   $"{reader["PostSeasonStartDate"].ToString()}\n" +
                   $"{reader["SeasonType01"].ToString()}\n" +
                   $"{reader["ApiSeason"].ToString()}\n";
                    var collection_set = new Nba_Set_Model08
                    {
                        Season = int.Parse(reader["Season"].ToString()),
                        StartYear = int.Parse(reader["StartYear"].ToString()),
                        EndYear = int.Parse(reader["EndYear"].ToString()),
                        Description = reader["Description"].ToString(),
                        RegularSeasonStartDate = DateTime.Parse(reader["RegularSeasonStartDate"].ToString()),
                        PostSeasonStartDate = DateTime.Parse(reader["PostSeasonStartDate"].ToString()),
                        SeasonType01 = reader["SeasonType01"].ToString(),
                        ApiSeason = reader["ApiSeason"].ToString(),
                    };
                    collectiondata08.Add(collection_set);
                }
                return data01[0];
            }
        }
    }
}



