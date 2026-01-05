using E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_USER;

namespace E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQLITE
{
    internal class User_View04
    {
        private static string[] data01 = new string[100];
        private static Sqlite_Services01 Sqlite_Serv01 = new Sqlite_Services01();
        public User_View04()
        {
            load_User_View05().Wait();


        }
        private async Task load_User_View05()
        {
            data01[0] = await Sqlite_Serv01.View_User_Table();
            Console.WriteLine(data01[0]);

        }





    }
}
