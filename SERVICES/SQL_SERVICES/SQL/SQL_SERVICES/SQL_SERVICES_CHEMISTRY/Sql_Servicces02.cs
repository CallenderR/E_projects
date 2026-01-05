using E_APP02.MODEL.SQLITE_MODEL.SQLITE_CHEMISTRY.SQLITE_SET_MODEL;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_TEST;
using E_APP02.TEMPLATE.TEXTS;
using Microsoft.Data.SqlClient;
using System.Data;


namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_CHEMISTRY
{
    internal class Sql_Servicces02
    {
        private static string[] data01 = new string[3];
        private static List<string> Alkali_Metals = new List<string>();
        private static List<string> Alkaline_Earth_Metals = new List<string>();
        private static List<string> Transition_Metals = new List<string>();
        private static List<string> Lanthanides_Rare_Earth_Metals = new List<string>();
        private static List<string> Noble_Gases = new List<string>();
        private static List<string> Actinides = new List<string>();
        private static List<string> Nonmetal_Gases_at_Room_Temperature = new List<string>();
        public static List<Sqlite_Set_Model03> collectiondata01 = new List<Sqlite_Set_Model03>();

        public static async Task<string> insert_catagory_type(string input01, string input02, string input03, string input04,
                                                              string input05, string input06, string input07)
        {
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[67].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@Alkali_Metals", input01);
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@Alkaline_Earth_Metals", input02);
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@Transition_Metals", input03);
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@Lanthanides_Rare_Earth_Metals", input04);
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@Noble_Gases", input05);
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@Actinides", input06);
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@Nonmetal_Gases_at_Room_Temperature", input07);
            int rowsAffected = Sql_Manager01.cmd[67].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                data01[0] = Default_Text01.text02[3];
            }

            else
            {
                data01[0] = Default_Text01.text02[2];
            }

            Sql_Manager01.conn[0].Close();
            return data01[0];

        }

        public static async Task<string> find_Alkali_Metals()
        {
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[62].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[62].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {
                    data01[0] += $"Alkali Metals: {reader.GetString(1)}\n";
                    Alkali_Metals.Add(reader["Alkali_Metals"].ToString());
                    var collection_set = new Sqlite_Set_Model03
                    {

                    };
                    collectiondata01.Add(collection_set);
                }

            }
            return data01[0];
        }

        public static async Task<string> Find_Actinides()
        {
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[62].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[62].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {

                    data01[0] += $"Actinides: {reader.GetString(1)}\n";
                    Actinides.Add(reader["Actinides"].ToString());
                    var collection_set = new Sqlite_Set_Model03
                    {

                    };
                    collectiondata01.Add(collection_set);
                }

            }
            return data01[0];
        }

        public static async Task<string> find_Alkaline_Earth_Metals()
        {
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[63].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[63].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {



                    data01[0] += $"Alkaline Earth Metals: {reader.GetString(1)}\n";
                    Alkaline_Earth_Metals.Add(reader["Alkaline_Earth_Metals"].ToString());
                    var collection_set = new Sqlite_Set_Model03
                    {

                    };
                    collectiondata01.Add(collection_set);
                }

            }
            Sql_Manager01.conn[0].Close();
            return data01[0];
        }
        public static async Task<string> find_Lanthanides_Rare_Earth_Metals()
        {
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[64].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[64].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {



                    data01[0] += $"Lanthanides Rare Earth Metals: {reader.GetString(1)}\n";
                    Lanthanides_Rare_Earth_Metals.Add(reader["Lanthanides_Rare_Earth_Metals"].ToString());
                    var collection_set = new Sqlite_Set_Model03
                    {

                    };
                    collectiondata01.Add(collection_set);
                }

            }
            Sql_Manager01.conn[0].Close();
            return data01[0];
        }
        public static async Task<string> find_Noble_Gases()
        {
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[65].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[65].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {

                    data01[0] += $"Noble Gases: {reader.GetString(1)}\n";
                    Noble_Gases.Add(reader["Noble_Gases"].ToString());
                    var collection_set = new Sqlite_Set_Model03
                    {

                    };
                    collectiondata01.Add(collection_set);
                }

            }
            Sql_Manager01.conn[0].Close();
            return data01[0];
        }
        public static async Task<string> find_Nonmetal_Gases_at_Room_Temperature()
        {
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[66].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[66].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {
                    data01[0] += $"Nonmetal Gases at Room Temperature: {reader.GetString(1)}\n";
                    Nonmetal_Gases_at_Room_Temperature.Add(reader["Nonmetal_Gases_at_Room_Temperature"].ToString());
                    var collection_set = new Sqlite_Set_Model03
                    {

                    };
                    collectiondata01.Add(collection_set);
                }

            }
            Sql_Manager01.conn[0].Close();
            return data01[0];
        }
        public static async Task<string> find_Transition_Metals()
        {
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[66].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[66].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {

                    data01[0] += $"Transition Metals: {reader.GetString(1)}\n";
                    Transition_Metals.Add(reader["Transition_Metals"].ToString());
                    var collection_set = new Sqlite_Set_Model03
                    {

                    };
                    collectiondata01.Add(collection_set);
                }

            }
            Sql_Manager01.conn[0].Close();
            return data01[0];
        }
        public static async Task<string> view_catagory_type()
        {
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[68].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[68].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {
                    data01[0] += $"Alkali Metals: {reader.GetString(1)}\n" +
                                 $"Alkaline Earth Metals: {reader.GetString(2)}\n" +
                                 $"Transition Metals: {reader.GetString(3)}\n" +
                                 $"Lanthanides Rare Earth Metals: {reader.GetString(4)}\n" +
                                 $"Noble Gases: {reader.GetString(5)}\n" +
                                 $"Actinides: {reader.GetString(6)}\n" +
                                 $"Nonmetal Gases at Room Temperature: {reader.GetString(7)}\n";
                }
            }
            Sql_Manager01.conn[0].Close();
            return data01[0];
        }
    }
}