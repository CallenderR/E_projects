using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_USER;

namespace E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQL
{
    internal class User_View01
    {
        private static string[] data01 = new string[100];
        private static Sql_Services01 Sql_Serv01 = new Sql_Services01();
        public User_View01()
        {
            load_User_View01().Wait();


        }
        private async Task load_User_View01()
        {
            data01[0] = $"username:";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            data01[2] = $"Password:";
            Console.WriteLine(data01[2]);
            data01[3] = Console.ReadLine();
            data01[4] = $"{Sql_Serv01.find_username_password(data01[1].ToString().Trim(), data01[3].ToString().Trim())}\n";
            Console.WriteLine(data01[4]);

        }
    }
}