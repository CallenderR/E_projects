using E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_USER;
using E_APP02.SERVICES.TEST_SERVICES;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_USER;
namespace E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQL
{
    internal class User_View03
    {
        private static string[] data01 = new string[100];
        private static Sql_Services01 Sql_Serv01= new Sql_Services01();         
        public User_View03()
        {
            load_User_View04().Wait();


        }
        private async Task load_User_View04()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write("Username: ");
                data01[0] = Test_Services01.GetRandomUsername.Trim();

                Console.Write("Password: ");
                data01[1] = Test_Services01.GetRandomPasswords.Trim();

                Console.Write("First name: ");
                data01[2] = Test_Services01.GetRandomName.Trim();

                Console.Write("Last name: ");
                data01[3] = Test_Services01.GetRandomLastName.Trim();

                Console.Write("Birthdate: ");
                data01[4] = Test_Services01.GetRandomBirthdates.Trim();

                Console.Write("Email: ");
                data01[5] = Test_Services01.GetRandomEmail.Trim();

                Console.Write("Phone number: ");
                data01[6] = Test_Services01.GetRandomPhoneNumber.Trim();
                data01[7] = Sql_Serv01.insert_user(
                   data01[0], data01[1], data01[2], data01[3], data01[4], data01[5], data01[6]);
                       Console.WriteLine(data01[7]);

            }


        }
    }
}