using Microsoft.Data.SqlClient;

namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_NBA
{
    internal class Sql_Manager02
    {
        private static string[] connectionString_ = {
            @"Data Source=(localdb)\MSSQLLocalDB;
             Initial Catalog=Nba Database01;
             Integrated Security=True;
             Connect Timeout=30;
             Encrypt=True;
             TrustServerCertificate=False;
             ApplicationIntent=ReadWrite;
             MultiSubnetFailover=False;
             Command Timeout=30"
        }; // 0

        private static SqlConnection[] conn_ = {
            new SqlConnection(connectionString_[0]),

        }; // 0

        private static SqlCommand[] cmd_ = {
            new SqlCommand("insert_Leagues", conn_[0]), // 0
            new SqlCommand("view_Leagues", conn_[0]), // 1

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
            insert_Leagues = 0,
            view_Leagues = 1,
        }
    }
}
