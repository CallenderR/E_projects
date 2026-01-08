using Microsoft.Data.SqlClient;

namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_USER
{
    internal class Sql_Manager01
    {


        private static string[] connectionString_ = {
              @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=User_Database;
              Integrated Security=True;
              Connect Timeout=30;
              Encrypt=True;
              TrustServerCertificate=False;
              ApplicationIntent=ReadWrite;
              MultiSubnetFailover=False",

 };
        private static SqlConnection[] conn_ = { new SqlConnection(connectionString_[0]) };
        private static SqlCommand[] cmd_ = {  new SqlCommand("find_email_using_email", conn_[0]),               // 0
                                              new SqlCommand("find_email_using_username", conn_[0]),            // 1
                                              new SqlCommand("find_phonenumber_using_email", conn_[0]),         // 2
                                              new SqlCommand("find_phonenumber_using_username", conn_[0]),      // 3
                                              new SqlCommand("find_user_location_using_email", conn_[0]),       // 4
                                              new SqlCommand("find_user_location_using_username", conn_[0]),    // 5
                                              new SqlCommand("find_username_using_email", conn_[0]),            // 6
                                              new SqlCommand("find_username_using_username", conn_[0]),         // 7
                                              new SqlCommand("find_usernmae_using_username", conn_[0]),         // 8
                                              new SqlCommand("insert_user", conn_[0]),//9
                                              new SqlCommand("update_user_location_using_email", conn_[0]),     // 10
                                              new SqlCommand("update_user_location_using_name", conn_[0]),      // 11
                                              new SqlCommand("update_user_location_using_phonenumber", conn_[0]),//12
                                              new SqlCommand("update_user_location_using_username", conn_[0]),   //13
                                              new SqlCommand("update_email_using_email", conn_[0]),   //14
                                              new SqlCommand("update_email_using_username", conn_[0]),   //15
                                              new SqlCommand("update_password_using_email", conn_[0]),   //16
                                              new SqlCommand("update_password_using_phonenumber", conn_[0]),   //17
                                              new SqlCommand("update_password_using_username", conn_[0]),   //18
                                              new SqlCommand("update_phonenumber_using_email", conn_[0]),   //19
                                              new SqlCommand("update_phonenumber_using_username", conn_[0]),   //20
                                              new SqlCommand("update_username_using_email", conn_[0]),   //21
                                              new SqlCommand("update_username_using_phonenumber", conn_[0]), //22
                                              new SqlCommand("update_username_using_username", conn_[0]), //23
                                              new SqlCommand("delete_user_using_email", conn_[0]), //24
                                              new SqlCommand("delete_user_using_phonenumber", conn_[0]), //25
                                              new SqlCommand("delete_user_using_username", conn_[0]), //26
                                              new SqlCommand("find_phonenumber_using_phonenumber", conn_[0]), //27
                                              new SqlCommand("find_password_using_email", conn_[0]), //28
                                              new SqlCommand("find_password_using_username", conn_[0]), //29
                                              new SqlCommand("find_username_password", conn_[0]), //30
                                              new SqlCommand("view_all_users", conn_[0]), //31     
                                              new SqlCommand("view_all_passwords", conn_[0]), //32
                                              new SqlCommand("view_all_uernames", conn_[0]), //33
                                              new SqlCommand("view_all_emails", conn_[0]), //34
                                              new SqlCommand("view_all_phonenumber", conn_[0]), //35








        };

        public static SqlCommand[] cmd
        {
            get { return cmd_; }
            set { cmd_ = value; }
        }

        public static SqlConnection[] conn
        {
            get { return conn_; }
            set { conn_ = value; }
        }
        public enum Connection_strings
        {
           Connection01 = 0
        }
        public enum command_strings
        {
            find_email_using_email = 0,
            find_email_using_username = 1,
            find_phonenumber_using_email = 2,
            find_phonenumber_using_username = 3,
            find_user_location_using_email = 4,
            find_user_location_using_username = 5,
            find_username_using_email = 6,
            find_username_using_username = 7,
            find_usernmae_using_username = 8,
            insert_user = 9,
            update_user_location_using_email = 10,
            update_user_location_using_name = 11,
            update_user_location_using_phonenumber = 12,
            update_user_location_using_username = 13,
            update_email_using_email = 14,
            update_email_using_username = 15,
            update_password_using_email = 16,
            update_password_using_phonenumber = 17,
            update_password_using_username = 18,
            update_phonenumber_using_email = 19,
            update_phonenumber_using_username = 20,
            update_username_using_email = 21,
            update_username_using_phonenumber = 22,
            update_username_using_username = 23,
            delete_user_using_email = 24,
            delete_user_using_phonenumber = 25,
            delete_user_using_username = 26,
            find_phonenumber_using_phonenumber = 27,
            find_password_using_email = 28,
            find_password_using_username = 29,
            find_username_password = 30,
            view_all_users = 31,
            view_all_passwords = 32,
            view_all_uernames = 33,
            view_all_email = 34,
            view_all_phonenumber=35
        }
    }
}
