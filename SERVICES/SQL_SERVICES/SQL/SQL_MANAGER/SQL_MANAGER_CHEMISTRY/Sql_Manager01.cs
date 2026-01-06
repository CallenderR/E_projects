using Microsoft.Data.SqlClient;

namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_CHEMISTRY
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
              MultiSubnetFailover=False" };
        private static SqlConnection[] conn_ = { new SqlConnection(connectionString_[0]) };
        private static SqlCommand[] cmd_ = {  new SqlCommand("insert_element", conn_[0]),                       // 0
                                              new SqlCommand("find_element_using_name", conn_[0]),              // 1
                                              new SqlCommand("find_element_using_atomic_number", conn_[0]),     // 2
                                              new SqlCommand("find_element_using_symbol", conn_[0]),            // 3
                                              new SqlCommand("Find_Actinides", conn_[0]), //04
                                              new SqlCommand("find_Alkaline_Earth_Metals", conn_[0]), //05
                                              new SqlCommand("find_Lanthanides_Rare_Earth_Metals", conn_[0]), //06
                                              new SqlCommand("find_Noble_Gases", conn_[0]), //07
                                              new SqlCommand("find_Nonmetal_Gases_at_Room_Temperature", conn_[0]), //08
                                              new SqlCommand("find_Transition_Metals", conn_[0]), //09
                                              new SqlCommand("view_catagory_type", conn_[0]), //10
                                              new SqlCommand("view_all_elements", conn_[0]),  //11        
                                              new SqlCommand("insert_catagory_type", conn_[0]),  //12
                                              new SqlCommand("find_Alkali_Metals", conn_[0]),  //13



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
            insert_element = 0,
            find_element_using_name = 1,
            find_element_using_atomic_number = 2,
            find_element_using_symbol = 3,
            Find_Actinides = 4,
            find_Alkaline_Earth_Metals = 5,
            find_Lanthanides_Rare_Earth_Metals = 6,
            find_Noble_Gases = 7,
            find_Nonmetal_Gases_at_Room_Temperature = 8,
            find_Transition_Metals = 9,
            view_catagory_type = 10,
            view_all_elements = 11,
            insert_catagory_type = 12,
            find_Alkali_Metals = 13,
        }


    }
}
