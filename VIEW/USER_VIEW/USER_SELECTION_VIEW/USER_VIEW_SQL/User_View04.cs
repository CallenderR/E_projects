using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_USER;

namespace E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQL
{
    internal class User_View04
    {
        private static string[] data01 = new string[100];
        private static Sql_Services01 Sql_Serv01 = new Sql_Services01();
        public User_View04()
        {
            load_User_View05().Wait();
        }
        private async Task load_User_View05()
        {
            data01[0] = $"1.) view_all_usersname\n" +
                        $"2.) view_all_passwords\n" +
                        $"3.) view_all_emails\n" +
                        $"4.) view_all_users\n";

            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    data01[2] = await Sql_Serv01.view_all_uernames();
                    Console.WriteLine(data01[2]);
                    break;
                case 2:
                    data01[3] = await Sql_Serv01.view_all_passwords();
                    Console.WriteLine(data01[3]);
                    break;
                case 3:
                    data01[4] = await Sql_Serv01.view_all_email();
                    Console.WriteLine(data01[4]);
                    break;
                case 4:
                    data01[5] = Sql_Serv01.view_all_users();
                    Console.WriteLine(data01[5]);
                    break;
            }
        }
    }
}