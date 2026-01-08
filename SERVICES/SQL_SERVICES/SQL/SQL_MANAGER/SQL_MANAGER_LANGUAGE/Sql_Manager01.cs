using Microsoft.Data.SqlClient;

namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_LANGUAGE
{
    internal class Sql_Manager01
    {
        private static string[] connectionString_ = {
            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=Language_Database;
              Integrated Security=True;
              Connect Timeout=30;
              Encrypt=True;
              TrustServerCertificate=False;
              ApplicationIntent=ReadWrite;
              MultiSubnetFailover=False;
              Command Timeout=30"

 };
        private static SqlConnection[] conn_ = { new SqlConnection(connectionString_[0]) };
        private static SqlCommand[] cmd_ = {   new SqlCommand("find_code_using_code", conn_[0]),                 // 0
                                               new SqlCommand("find_code_using_language", conn_[0]),             // 1
                                               new SqlCommand("find_language_using_code", conn_[0]),             // 2
                                               new SqlCommand("find_language_using_Language", conn_[0]),         // 3
                                               new SqlCommand("insert_language", conn_[0]),                      // 4
                                               new SqlCommand("view_all_data_from_language_table", conn_[0]),    // 5
        
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
            find_code_using_code = 0,
            find_code_using_language = 1,
            find_language_using_code = 2,
            find_language_using_Language = 3,
            insert_language = 4,
            view_all_data_from_language_table = 5,
        }
    }
}
