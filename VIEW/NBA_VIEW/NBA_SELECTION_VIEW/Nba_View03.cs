using E_APP02.SERVICES.NBA_SERVICES;


namespace E_APP02.VIEW.NBA_VIEW.NBA_SELECTION_VIEW
{
    internal class Nba_View03
    {
        private static string[] data01 = new string[100];
        private static Nba_Data_Api03 Nba_Data_A03 = new Nba_Data_Api03();
        public Nba_View03()
        {
            load_Nba_View03().Wait();


        }
        private async Task load_Nba_View03()
        {
            data01[0] = "1.)NBA_League_Info\n" +
"2.)NBA_Sport_Info\n" +
"3.)Seasons_Get_Seasons_Types_List\n" +
"4.)Seasons_Get_Current_Season_Year\n" +
"5.)Seasons_Get_Current_Season\n" +
"6.)Seasons_Get_Seasons_Year_List\n" +
"6.)Seasons_Get_Seasons_List\n" +
"7.)Leagues_Get_Info\n" +
"8.)Scoreboard_Get_by_Date\n" +
"9.)Schedule_Get_by_Date\n" +
"10.)Standings_Conference_Standings\n" +
"11.)Standings_Division_Standings\n" +
"12.)Standings_League_Standings\n" +
"13.)Player_All_List\n" +
"14.)Player_Info\n" +
"15.)Player_Image\n" +
"16.)Player_Status\n" +
"17.)Player_Team\n" +
"18.)Player_Tickets_Info\n" +
"19.)Player_Videos\n" +
"20.)Player_Links\n" +
"21.)Player_Season\n" +
"22.)Player_Splits\n";

            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:


                    data01[2] = $"{await Nba_Data_A03.NBA_League_Info()}";
                    Console.WriteLine(data01[2]);
                    break;
                case 2:


                    data01[3] = $"{await Nba_Data_A03.NBA_Sport_Info()}";
                    Console.WriteLine(data01[3]);
                    break;
                case 3:


                    data01[4] = $"{await Nba_Data_A03.Seasons_Get_Seasons_Types_List()}";
                    Console.WriteLine(data01[4]);
                    break;
                case 4:


                    data01[5] = $"{await Nba_Data_A03.Seasons_Get_Current_Season_Year()}";
                    Console.WriteLine(data01[5]);
                    break;
                case 5:


                    data01[6] = $"{await Nba_Data_A03.Seasons_Get_Current_Season()}";
                    Console.WriteLine(data01[6]);
                    break;
                case 6:


                    data01[7] = $"{await Nba_Data_A03.Seasons_Get_Seasons_Year_List()}";
                    Console.WriteLine(data01[7]);
                    break;
                case 7:


                    data01[8] = $"{await Nba_Data_A03.Seasons_Get_Seasons_List()}";
                    Console.WriteLine(data01[8]);
                    break;
                case 8:


                    data01[9] = $"{await Nba_Data_A03.Leagues_Get_Info()}";
                    Console.WriteLine(data01[9]);
                    break;
                case 9:


                    data01[10] = $"{await Nba_Data_A03.Scoreboard_Get_by_Date()}";
                    Console.WriteLine(data01[10]);
                    break;
                case 10:


                    data01[11] = $"{await Nba_Data_A03.Schedule_Get_by_Date()}";
                    Console.WriteLine(data01[11]);
                    break;
                case 11:


                    data01[12] = $"{await Nba_Data_A03.Standings_Conference_Standings()}";
                    Console.WriteLine(data01[12]);
                    break;
                case 12:


                    data01[13] = $"{await Nba_Data_A03.Standings_Division_Standings()}";
                    Console.WriteLine(data01[13]);
                    break;
                case 13:


                    data01[14] = $"{await Nba_Data_A03.Standings_League_Standings()}";
                    Console.WriteLine(data01[14]);
                    break;
                case 14:


                    data01[15] = $"{await Nba_Data_A03.Player_All_List()}";
                    Console.WriteLine(data01[15]);
                    break;
                case 15:


                    data01[16] = $"{await Nba_Data_A03.Player_Info()}";
                    Console.WriteLine(data01[16]);
                    break;
                case 16:


                    data01[17] = $"{await Nba_Data_A03.Player_Image()}";
                    Console.WriteLine(data01[17]);
                    break;
                case 17:


                    data01[18] = $"{await Nba_Data_A03.Player_Status()}";
                    Console.WriteLine(data01[18]);
                    break;
                case 18:


                    data01[19] = $"{await Nba_Data_A03.Player_Team()}";
                    Console.WriteLine(data01[19]);
                    break;
                case 19:


                    data01[20] = $"{await Nba_Data_A03.Player_Tickets_Info()}";
                    Console.WriteLine(data01[20]);
                    break;
                case 20:


                    data01[21] = $"{await Nba_Data_A03.Player_Videos()}";
                    Console.WriteLine(data01[21]);
                    break;
                case 21:


                    data01[22] = $"{await Nba_Data_A03.Player_Links()}";
                    Console.WriteLine(data01[22]);
                    break;
                case 22:


                    data01[23] = $"{await Nba_Data_A03.Player_Season()}";
                    Console.WriteLine(data01[23]);
                    break;
                case 23:


                    data01[24] = $"{await Nba_Data_A03.Player_Splits()}";
                    Console.WriteLine(data01[24]);
                    break;
            }
        }
    }
}