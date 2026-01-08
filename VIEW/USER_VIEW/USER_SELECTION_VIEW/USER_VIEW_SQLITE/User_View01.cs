using E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_USER;
using E_APP02.SERVICES.TEST_SERVICES;
namespace E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQLITE
{
    internal class User_View01
    {
        private static string[] data01 = new string[100];
        private static Sqlite_Services01 Sqlite_Serv01 = new Sqlite_Services01();
        public User_View01()
        {
            load_User_View01().Wait();


        }
        private async Task load_User_View01()
        {
            data01[0] = $"username:";
            Console.WriteLine(data01[0]);
            data01[1] = Test_Services01.GetRandomUsernameSqlite.Trim();
            data01[2] = $"Password:";
            Console.WriteLine(data01[2]);
            data01[3] = Test_Services01.GetRandomPasswordSqlite.Trim();
            data01[4] = $"{await Sqlite_Serv01.Login(data01[1].ToString().Trim(), data01[3].ToString().Trim())}\n";

            Console.WriteLine(data01[4]);

        }
    }
}