using E_APP02.SERVICES.NBA_SERVICES;


namespace E_APP02.VIEW.NBA_VIEW.NBA_SELECTION_VIEW
{
    internal class Nba_View01
    {
        private static string[] data01 = new string[100];
        private static Nba_Data_Api01 Nba_Data_A01 = new Nba_Data_Api01();
        public Nba_View01()
        {
            load_Nba_View01().Wait();


        }
        private async Task load_Nba_View01()
        {
            data01[0] = "1.)Standings\n" +
"2.)Player_Profiles_by_Active\n" +
"3.)Player_Profiles_by_Free_Agent\n" +
"4.)Players_Profiles_by_Team\n" +
"5.)Team_Profiles_All\n" +
"6.)Team_Profiles_by_Active\n" +
"7.)Team_Profiles_by_Season\n" +
"8.)Referees\n" +
"9.)Stadiums\n" +
"10.)Are_Games_In_Progress\n" +
"11.)Betting_Metadata\n" +
"12.)Season_Current\n" +
"13.)Sportsbooks_by_Active\n" +
"14.)Schedules\n" +
"15.)Schedules_Basic\n" +
"16.)Games_Basic_by_Date_Final\n" +
"17.)sql_get_team_data_01\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine(); 
            switch (int.Parse(data01[1]))
            {
                case 1:

                    data01[1] = "enter a year\n";
                    Console.WriteLine(data01[1]);
                    data01[2] = Console.ReadLine();       
                    data01[3] = $"{await Nba_Data_A01.Standings(data01[2])}";
                    Console.WriteLine(data01[3]);
        
                    break;

                case 2:

           
                    data01[5] = $"{await Nba_Data_A01.Player_Profiles_by_Active()}";
                    Console.WriteLine(data01[5]);

                    break;
                case 3:
        
                    data01[6] = $"{await Nba_Data_A01.Player_Profiles_by_Free_Agent()}";
                    Console.WriteLine(data01[6]);

                    break;
                case 4:
                    data01[7] = "enter a team name\n";
                    data01[8] = Console.ReadLine();
                    data01[9] = $"{await Nba_Data_A01.Players_Profiles_by_Team(data01[8])}";
                    Console.WriteLine(data01[9]);

                    break;
                case 5:
        
                    data01[10] = $"{await Nba_Data_A01.Team_Profiles_All()}";
                    Console.WriteLine(data01[10]);
                    break;
                case 6:

                    data01[11] = $"{await Nba_Data_A01.Team_Profiles_by_Active()}";
                    Console.WriteLine(data01[11]);
                    break;
                case 7:
                    data01[13] = "enter a year\n";
                    data01[14] = Console.ReadLine();
                    data01[15] = $"{await Nba_Data_A01.Team_Profiles_by_Season(data01[14])}";
                    Console.WriteLine(data01[15]);
                    break;
                case 8:
               
                    data01[16] = $"{await Nba_Data_A01.Referees()}";
                    Console.WriteLine(data01[16]);
                    break;
                case 9:
             
                    data01[17] = $"{await Nba_Data_A01.Stadiums()}";
                    Console.WriteLine(data01[17]);
                    break;
                case 10:
               
                    data01[18] = $"{await Nba_Data_A01.Are_Games_In_Progress()}";
                    Console.WriteLine(data01[18]);
                    break;
                case 11:
             
                    data01[19] = $"{await Nba_Data_A01.Betting_Metadata()}";
                    Console.WriteLine(data01[19]);
                    break;
                case 12:
      
                    data01[20] = $"{await Nba_Data_A01.Season_Current()}";
                    Console.WriteLine(data01[20]);
                    break;
                case 13:
          
                    data01[21] = $"{await Nba_Data_A01.Sportsbooks_by_Active()}";
                    Console.WriteLine(data01[21]);
                    break;
                case 14:
                    data01[22] = "enter a year\n";
                    data01[23] = Console.ReadLine();
                    data01[24] = $"{await Nba_Data_A01.Schedules(data01[23])}";
                    Console.WriteLine(data01[24]);
                    break;
                case 15:

                    data01[25] = "enter a year\n";
                    data01[26] = Console.ReadLine();
                    data01[27] = $"{await Nba_Data_A01.Schedules_Basic(data01[26])}";
                    Console.WriteLine(data01[27]);
                    break;
                case 16:
                    data01[28] = "enter a year\n";
                    data01[29] = Console.ReadLine();
                    data01[30] = $"{await Nba_Data_A01.Games_Basic_by_Date_Final(data01[29])}";
                    Console.WriteLine(data01[30]);
                    break;
                case 17:
                    data01[30] = "enter a team name\n";
                    data01[31] = Console.ReadLine();
                    data01[32] = $"{Nba_Data_A01.sql_get_team_data_01(data01[31])}\n";
                    Console.WriteLine(data01[32]);
                    break;
            }
        }
    }
}