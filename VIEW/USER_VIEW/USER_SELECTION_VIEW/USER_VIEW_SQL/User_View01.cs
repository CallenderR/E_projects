using E_APP02.SERVICES.LOCATION_SERVICES.LOCATE_EXTERNAL.LOCATE_DEVICES;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_USER;
using E_APP02.SERVICES.TEST_SERVICES;

namespace E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQL
{
    internal class User_View01
    {
        private static string[] data01 = new string[100];
        private static Sql_Services01 Sql_Serv01 = new Sql_Services01();
        private static Locate_Devices01 Locate_Dev01= new Locate_Devices01();
        public User_View01()
        {
            load_User_View01().Wait();


        }
        private async Task load_User_View01()
        {
            data01[0] = $"username:";
            Console.WriteLine(data01[0]);
            data01[1] = Test_Services01.GetRandomUsernameSql.Trim();
            data01[2] = $"Password:";
            Console.WriteLine(data01[2]);
            data01[3] = Test_Services01.GetRandomPasswordSql.Trim();
            data01[4] = $"{Sql_Serv01.find_username_password(data01[1].ToString().Trim(), data01[3].ToString().Trim())}\n";
            data01[5] = Locate_Dev01.get_device_lat_and_lon_data();
            string[] resaults_array = data01[5].Split('\b');
            data01[6] = Sql_Serv01.update_user_location_using_username(data01[1], resaults_array[0].Trim(), resaults_array[1].Trim());
            Console.WriteLine(data01[6]);

        }
    }
}