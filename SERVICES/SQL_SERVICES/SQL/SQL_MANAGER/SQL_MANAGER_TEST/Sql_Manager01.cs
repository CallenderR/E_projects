using Microsoft.Data.SqlClient;

namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_TEST
{
    internal class Sql_Manager01
    {
        private static string[] connectionString_ = {
            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=Chemistry_Database;
              Integrated Security=True;
              Connect Timeout=30;
              Encrypt=True;
              TrustServerCertificate=False;
              ApplicationIntent=ReadWrite;
              MultiSubnetFailover=False",

            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=Chat_Database;
              Integrated Security=True;
              Connect Timeout=30;
              Encrypt=True;
              TrustServerCertificate=False;
              ApplicationIntent=ReadWrite;
              MultiSubnetFailover=False",

            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=User_Database;
              Integrated Security=True;
              Connect Timeout=30;
              Encrypt=True;
              TrustServerCertificate=False;
              ApplicationIntent=ReadWrite;
              MultiSubnetFailover=False",

            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=Language_Database;
              Integrated Security=True;
              Connect Timeout=30;
              Encrypt=True;
              TrustServerCertificate=False;
              ApplicationIntent=ReadWrite;
              MultiSubnetFailover=False;
              Command Timeout=30",

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
                  Initial Catalog=Nba Database;
                  Integrated Security=True;
                  Connect Timeout=30;
                  Encrypt=True;
                  TrustServerCertificate=False;
                  ApplicationIntent=ReadWrite;
                  MultiSubnetFailover=False;
                  Command Timeout=30"
        }; // 5

        private static SqlConnection[] conn_ = {
            new SqlConnection(connectionString_[0]),
            new SqlConnection(connectionString_[1]),
            new SqlConnection(connectionString_[2]),
            new SqlConnection(connectionString_[3]),
            new SqlConnection(connectionString_[4]),
            new SqlConnection(connectionString_[5])
        }; // 5

        private static SqlCommand[] cmd_ = {
            new SqlCommand("insert_element", conn_[0]),                       // 0
            new SqlCommand("find_element_using_name", conn_[0]),              // 1
            new SqlCommand("find_element_using_atomic_number", conn_[0]),     // 2
            new SqlCommand("find_element_using_symbol", conn_[0]),            // 3
            new SqlCommand("view_all_elements", conn_[0]),                    // 4
            new SqlCommand("insert_chat", conn_[1]),                          // 5
            new SqlCommand("view_chat", conn_[1]),                            // 6
            new SqlCommand("find_email_using_email", conn_[2]),               // 7
            new SqlCommand("find_email_using_username", conn_[2]),            // 8
            new SqlCommand("find_phonenumber_using_email", conn_[2]),         // 9
            new SqlCommand("find_phonenumber_using_username", conn_[2]),      // 10
            new SqlCommand("find_user_location_using_email", conn_[2]),       // 11
            new SqlCommand("find_user_location_using_username", conn_[2]),    // 12
            new SqlCommand("find_username_using_email", conn_[2]),            // 13
            new SqlCommand("find_username_using_username", conn_[2]),         // 14
            new SqlCommand("find_usernmae_using_username", conn_[2]),         // 15
            new SqlCommand("insert_user", conn_[2]),                          // 16
            new SqlCommand("find_code_using_code", conn_[3]),                 // 17
            new SqlCommand("find_code_using_language", conn_[3]),             // 18
            new SqlCommand("find_language_using_code", conn_[3]),             // 19
            new SqlCommand("find_language_using_Language", conn_[3]),         // 20
            new SqlCommand("insert_language", conn_[3]),                      // 21
            new SqlCommand("view_all_data_from_language_table", conn_[3]),    // 22
            new SqlCommand("find_username_password", conn_[2]),               // 23
            new SqlCommand("view_all_client_data", conn_[4]),                 // 24
            new SqlCommand("find_client_data_using_email", conn_[4]),         // 25
            new SqlCommand("find_client_data_using_latitude_and_longitude", conn_[4]), // 26
            new SqlCommand("find_client_data_using_logo", conn_[4]),          // 27
            new SqlCommand("find_client_data_using_name", conn_[4]),          // 28
            new SqlCommand("find_client_data_using_number", conn_[4]),        // 29
            new SqlCommand("insert_client_data", conn_[4]),                   // 30
            new SqlCommand("find_password_using_username", conn_[2]),         // 31
            new SqlCommand("find_password_using_email", conn_[2]),            // 32
            new SqlCommand("find_team_by_name", conn_[5]),                    // 33
            new SqlCommand("find_team_by_id", conn_[5]),                      // 34
            new SqlCommand("insert_team_standings", conn_[5]),                // 35 
            new SqlCommand("find_team_standings_by_teamid", conn_[5]),        // 36
            new SqlCommand("find_team_standings_by_name", conn_[5]),          // 37 
            new SqlCommand("view_all_team_standing", conn_[5]),               // 38 
            new SqlCommand("view_all_players", conn_[5]),                     // 39 
            new SqlCommand("find_player_by_first_and_last_name", conn_[5]),   // 40 
            new SqlCommand("find_player_by_id", conn_[5]),                    // 41 
            new SqlCommand("insert_players", conn_[5]),                       // 42 
            new SqlCommand("view_all_Referee", conn_[5]),                     // 43 
            new SqlCommand("find_Referee_by_id", conn_[5]),                   // 44 
            new SqlCommand("find_Referee_by_name", conn_[5]),                 // 45 
            new SqlCommand("insert_Stadium", conn_[5]),                       // 46 
            new SqlCommand("find_Stadium_by_name", conn_[5]),                 // 47 
            new SqlCommand("find_Stadium_by_id", conn_[5]),                   // 48 
            new SqlCommand("find_Stadium_by_City", conn_[5]),                 // 49 
            new SqlCommand("find_Stadium_by_Address", conn_[5]),              // 50 
            new SqlCommand("insert_Referee", conn_[5]),                       // 51 
            new SqlCommand("view_all_Stadium", conn_[5]),                     // 52 
            new SqlCommand("insert_season", conn_[5]),                        // 53 
            new SqlCommand("view_season", conn_[5]),                          // 54 
            new SqlCommand("view_team_names", conn_[5]),                      // 55 
            new SqlCommand("insert_team_all", conn_[5]),                      // 56 
            new SqlCommand("view_latest_message", conn_[1]),                  // 57
            new SqlCommand("update_user_location_using_email", conn_[2]),     // 58
            new SqlCommand("update_user_location_using_name", conn_[2]),      // 59
            new SqlCommand("update_user_location_using_phonenumber", conn_[2]),//60
            new SqlCommand("update_user_location_using_username", conn_[2]),   //61
            new SqlCommand("Find_Actinides", conn_[0]), //62
            new SqlCommand("find_Alkaline_Earth_Metals", conn_[0]), //63
            new SqlCommand("find_Lanthanides_Rare_Earth_Metals", conn_[0]), //64
            new SqlCommand("find_Noble_Gases", conn_[0]), //65
            new SqlCommand("find_Nonmetal_Gases_at_Room_Temperature", conn_[0]), //66
            new SqlCommand("find_Transition_Metals", conn_[0]), //67
            new SqlCommand("view_catagory_type", conn_[0]), //68   
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

        }
    }
}
