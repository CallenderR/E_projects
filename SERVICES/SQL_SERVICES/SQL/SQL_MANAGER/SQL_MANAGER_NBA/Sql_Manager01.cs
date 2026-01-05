using Microsoft.Data.SqlClient;

namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_NBA
{
    internal class Sql_Manager01
    {
        private static string[] connectionString_ = {
                @"Data Source=(localdb)\MSSQLLocalDB;
                  Initial Catalog=Nba Database;
                  Integrated Security=True;
                  Connect Timeout=30;
                  Encrypt=True;
                  TrustServerCertificate=False;
                  ApplicationIntent=ReadWrite;
                  MultiSubnetFailover=False;
                  Command Timeout=30"

 };
        private static SqlConnection[] conn_ = { new SqlConnection(connectionString_[0]) };
        private static SqlCommand[] cmd_ = {  new SqlCommand("find_team_by_name", conn_[0]),                    // 01
                                              new SqlCommand("find_team_by_id", conn_[0]),                      // 02
                                              new SqlCommand("insert_team_standings", conn_[0]),                // 03 
                                              new SqlCommand("find_team_standings_by_teamid", conn_[0]),        // 04
                                              new SqlCommand("find_team_standings_by_name", conn_[0]),          // 05 
                                              new SqlCommand("view_all_team_standing", conn_[0]),               // 06 
                                              new SqlCommand("view_all_players", conn_[0]),                     // 07 
                                              new SqlCommand("find_player_by_first_and_last_name", conn_[0]),   // 08 
                                              new SqlCommand("find_player_by_id", conn_[0]),                    // 09 
                                              new SqlCommand("insert_players", conn_[0]),                       // 10 
                                              new SqlCommand("view_all_Referee", conn_[0]),                     // 11 
                                              new SqlCommand("find_Referee_by_id", conn_[0]),                   // 12 
                                              new SqlCommand("find_Referee_by_name", conn_[0]),                 // 13 
                                              new SqlCommand("insert_Stadium", conn_[0]),                       // 14 
                                              new SqlCommand("find_Stadium_by_name", conn_[0]),                 // 15 
                                              new SqlCommand("find_Stadium_by_id", conn_[0]),                   // 16 
                                              new SqlCommand("find_Stadium_by_City", conn_[0]),                 // 17 
                                              new SqlCommand("find_Stadium_by_Address", conn_[0]),              // 18 
                                              new SqlCommand("insert_Referee", conn_[0]),                       // 19 
                                              new SqlCommand("view_all_Stadium", conn_[0]),                     // 20 
                                              new SqlCommand("insert_season", conn_[0]),                        // 21 
                                              new SqlCommand("view_season", conn_[0]),                          // 22 
                                              new SqlCommand("view_team_names", conn_[0]),                      // 23 
                                              new SqlCommand("insert_team_all", conn_[0]),                      // 24 
        
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
