using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_USER;
using E_APP02.SERVICES.TEST_SERVICES;

namespace E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQL
{
    internal class User_View02
    {
        private static string[] data01 = new string[100];
        private static Sql_Services01 Sql_Serv01 = new Sql_Services01();
        public User_View02()
        {
            load_User_View03();
        }
        private void load_User_View03()
        {
            data01[0] = $"1.) find_email_using_email\n" +
                        $"2.)find_email_using_email\n" +
                        $"3.)find_phonenumber_using_email\n" +
                        $"4.)find_phonenumber_using_username\n" +
                        $"5.)find_phonenumber_using_phonenumber\n" +
                        $"6.)find_user_location_using_email\n" +
                        $"7.)find_user_location_using_username\n" +
                        $"8.)find_username_using_email\n" +
                        $"9.)find_username_using_username\n" +
                        $"10.)find_password_using_email\n" +
                        $"11.)find_password_using_username\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    data01[1] = "Email address\n";
                    Console.WriteLine(data01[1]);
                    data01[2] = Test_Services01.GetRandomEmailSql.Trim();
                    data01[3] = $"{Sql_Serv01.find_email_using_email(data01[2])}";
                    Console.WriteLine(data01[3]);
                    break;
                case 2:
                    data01[4] = "Email address\n";
                    Console.WriteLine(data01[4]);
                    data01[5] = Test_Services01.GetRandomEmailSql.Trim();
                    data01[6] = $"{Sql_Serv01.find_email_using_email(data01[5])}";
                    Console.WriteLine(data01[6]);
                    break;
                case 3:
                    data01[7] = "Email address\n";
                    Console.WriteLine(data01[7]);
                    data01[8] = Test_Services01.GetRandomEmailSql.Trim();
                    data01[9] = $"{Sql_Serv01.find_phonenumber_using_email(data01[8])}";
                    Console.WriteLine(data01[9]);
                    break;
                case 4:
                    data01[10] = "Username\n";
                    Console.WriteLine(data01[10]);
                    data01[11] = Test_Services01.GetRandomUsernameSql.Trim();
                    data01[12] = $"{Sql_Serv01.find_phonenumber_using_username(data01[11])}";
                    Console.WriteLine(data01[12]);
                    break;
                case 5:
                    data01[13] = "Phone Number\n";
                    Console.WriteLine(data01[13]);
                    data01[14] = Test_Services01.GetRandomPhonenumberSql.Trim();
                    data01[15] = $"{Sql_Serv01.find_phonenumber_using_phonenumber(data01[14])}";
                    Console.WriteLine(data01[15]);
                    break;
                case 6:
                    data01[16] = "Email address\n";
                    Console.WriteLine(data01[16]);
                    data01[17] = Test_Services01.GetRandomEmailSql.Trim();
                    data01[18] = $"{Sql_Serv01.find_user_location_using_email(data01[17])}";
                    Console.WriteLine(data01[19]);
                    break;
                case 7:
                    data01[20] = "username\n";
                    Console.WriteLine(data01[20]);
                    data01[21] = Test_Services01.GetRandomUsernameSql.Trim();
                    data01[22] = $"{Sql_Serv01.find_user_location_using_username(data01[21])}";
                    Console.WriteLine(data01[22]);
                    break;
                case 8:
                    data01[23] = "Email address\n";
                    Console.WriteLine(data01[24]);
                    data01[25] = Test_Services01.GetRandomEmailSql.Trim();
                    data01[26] = $"{Sql_Serv01.find_username_using_email(data01[24])}";
                    Console.WriteLine(data01[26]);
                    break;
                case 9:
                    data01[27] = "username\n";
                    Console.WriteLine(data01[27]);
                    data01[29] = Test_Services01.GetRandomUsernameSql.Trim();
                    data01[30] = $"{Sql_Serv01.find_username_using_username(data01[29])}";
                    Console.WriteLine(data01[30]);
                    break;
                case 10:
                    data01[31] = "Email address\n";
                    Console.WriteLine(data01[31]);
                    data01[32] = Test_Services01.GetRandomEmailSql.Trim();
                    data01[33] = $"{Sql_Serv01.find_password_using_email(data01[32])}";
                    Console.WriteLine(data01[33]);
                    break;
                case 11:
                    data01[34] = "username\n";
                    Console.WriteLine(data01[34]);
                    data01[35] = Test_Services01.GetRandomUsernameSql.Trim();
                    data01[36] = $"{Sql_Serv01.find_password_using_username(data01[35])}";
                    Console.WriteLine(data01[36]);
                    break;
            }
        }
    }
}