
namespace E_APP02.VIEW.DATABASE_VIEW.DATABASE_SELECTION_VIEW.DATABASE_SQL_VIEW
{
    internal class Database_View01
    {
        private static string[] data01 = new string[100];
        private static E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_CHEMISTRY.Sql_Services02 Sql_Serv_elements = new E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_CHEMISTRY.Sql_Services02();
        private static E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_DEVICE.Sql_Services01 Sql_Serv_devices = new E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_DEVICE.Sql_Services01();
        private static E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_LANGUAGE.Sql_Services01 Sql_Serv_language = new E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_LANGUAGE.Sql_Services01();
        private static E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_NBA.Sql_Services01 Sql_Serv_nba = new E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_NBA.Sql_Services01();
        private static E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_ORGANIZATION.Sql_Services01 Sql_Serv_organizaiton = new E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_ORGANIZATION.Sql_Services01();
        private static E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_USER.Sql_Services01 Sql_Serv_user = new E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_USER.Sql_Services01();
        public Database_View01()
        {
            load_Database_View01().Wait();


        }
        private async Task load_Database_View01()
        {
            data01[0] = $"Select View\n" +
    $"-------------------------\n" +
    $"1.) SQL CHEMISTRY\n" +
    $"2.) SQL DEVICE\n" +
    $"3.) SQL LANGUAGE\n" +
    $"4.) SQ NBA\n" +
    $"5.) SQL_SERVICES_ORGANIZATION\n" +
    $"6.) SQL_SERVICES_USER\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))

            {
                case 1:

                    data01[2] = $"{Sql_Serv_elements.view_all_elements()}";
                    Console.WriteLine(data01[2]);
                    break;
                case 2:

                    data01[3] = $"{Sql_Serv_devices.view_device_table()}";
                    Console.WriteLine(data01[3]);
                    break;
                case 3:

                    data01[4] = $"{Sql_Serv_language.view_all_data_from_language_table()}";
                    Console.WriteLine(data01[4]);
                    break;
                case 4:

                    data01[5] = $"{Sql_Serv_nba.view_all_Leagues()}";
                    Console.WriteLine(data01[5]);
                    break;
                case 5:

                    data01[6] = $"{Sql_Serv_organizaiton.view_all_data_from_client_table()}";
                    Console.WriteLine(data01[6]);
                    break;
                case 6:

                    data01[7] = $"{Sql_Serv_user.view_all_users()}";
                    Console.WriteLine(data01[7]);
                    break;
            }
        }
    }
}