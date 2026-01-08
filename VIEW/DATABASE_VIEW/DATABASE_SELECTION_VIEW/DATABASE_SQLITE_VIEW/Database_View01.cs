
namespace E_APP02.VIEW.DATABASE_VIEW.DATABASE_SELECTION_VIEW.DATABASE_SQLITE_VIEW
{
    internal class Database_View01
    {
        private static string[] data01 = new string[100];
        private static E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_CHEMISTORY.Sqlite_Services01 Sqlite_Serv_elements = new E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_CHEMISTORY.Sqlite_Services01();
        private static E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_DEVICES.Sqlite_Services01 Sqlite_Serv_devices = new E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_DEVICES.Sqlite_Services01();
        private static E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_LANGUAGE.Sqlite_Services01 Sqlite_Serv_language = new E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_LANGUAGE.Sqlite_Services01();
        private static E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_USER.Sqlite_Services01 Sqlite_Serv_user = new E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_USER.Sqlite_Services01();

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
    $"4.) SQL_SERVICES_USER\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))

            {
                case 1:

                    data01[2] = $"{await Sqlite_Serv_elements.view_all_elements()}";
                    Console.WriteLine(data01[2]);
                    break;
                case 2:

                    data01[3] = $"{await Sqlite_Serv_devices.view_device_table()}";
                    Console.WriteLine(data01[3]);
                    break;
                case 3:

                    data01[4] = $"{await Sqlite_Serv_language.view_language_table()}";
                    Console.WriteLine(data01[4]);
                    break;
                case 4:

                    data01[5] = $"{await Sqlite_Serv_user.View_User_Table()}";
                    Console.WriteLine(data01[5]);
                    break;
            }
        }
    }
}