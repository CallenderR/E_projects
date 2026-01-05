using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_USER;

namespace E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQL
{
    internal class User_View04
    {

        private static string[] data01 = new string[100];
        private static Sql_Services01 Sql_Serv01 = new Sql_Services01();    
        public User_View04()
        {
            load_User_View05();


        }
        private void load_User_View05()
        {
            data01[0] = Sql_Serv01.view_all_users();
            Console.WriteLine(data01[0]);

        }





    }
}
