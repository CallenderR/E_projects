using Microsoft.Data.SqlClient;

namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_CLIENTS
{
    internal class Sql_Manager01
    {
        private static string[] connectionString_ = {
                 @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=Clients_Database;
              Integrated Security=True;
              Connect Timeout=30;
              Encrypt=True;
              TrustServerCertificate=False;
              ApplicationIntent=ReadWrite;
              MultiSubnetFailover=False;
              Command Timeout=30",
              @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=Chat_Database;
              Integrated Security=True;
              Connect Timeout=30;
              Encrypt=True;
              TrustServerCertificate=False;
              ApplicationIntent=ReadWrite;
              MultiSubnetFailover=False",

 };
        private static SqlConnection[] conn_ = { new SqlConnection(connectionString_[0]) };
        private static SqlCommand[] cmd_ = { new SqlCommand("view_all_client_data", conn_[0]),                 // 01
                                             new SqlCommand("find_client_data_using_email", conn_[0]),         // 02
                                             new SqlCommand("find_client_data_using_latitude_and_longitude", conn_[0]), // 03
                                             new SqlCommand("find_client_data_using_logo", conn_[0]),          // 04
                                             new SqlCommand("find_client_data_using_name", conn_[0]),          // 05
                                             new SqlCommand("find_client_data_using_number", conn_[0]),        // 06
                                             new SqlCommand("insert_client_data", conn_[0]),                   // 07   
        
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
            User_Connection01 = 0
        }
        public enum command_strings
        {
            view_all_client_data = 0,
            find_client_data_using_email = 1,
            find_client_data_using_latitude_and_longitude = 2,
            find_client_data_using_logo = 3,
            find_client_data_using_name = 4,
            find_client_data_using_number = 5,
            insert_client_data = 6,
        }
    }
}
