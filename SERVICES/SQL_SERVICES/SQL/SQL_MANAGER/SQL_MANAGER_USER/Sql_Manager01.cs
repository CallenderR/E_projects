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

    }
}
