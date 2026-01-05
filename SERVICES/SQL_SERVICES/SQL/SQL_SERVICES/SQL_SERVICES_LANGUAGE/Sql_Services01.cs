using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_TEST;
using E_APP02.TEMPLATE.TEXTS;
using Microsoft.Data.SqlClient;
using System.Data;

namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_LANGUAGE
{
    internal class Sql_Services01
    {
        private static string[] data01 = new string[3];
        private static List<string> code = new List<string>();
        private static List<string> language = new List<string>();
        public string[] data_array = {
                                      "Language Code",//0
                                      "Language name",//1
                                      "select language",//2
        
        };
        public string insert_language(string input01, string input02)
        {
            Sql_Manager01.conn[3].Open();
            Sql_Manager01.cmd[21].Parameters.Clear();
            Sql_Manager01.cmd[21].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[21].Parameters.AddWithValue("@code", input01);
            Sql_Manager01.cmd[21].Parameters.AddWithValue("@language", input02);
            int rowsAffected = Sql_Manager01.cmd[21].ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                data01[0] = Default_Text01.text02[3];
            }

            else
            {
                data01[0] = Default_Text01.text02[2];
            }

            Sql_Manager01.conn[3].Close();
            return data01[0];
        }
        public string find_code_using_code(string input)
        {
            Sql_Manager01.conn[3].Open();
            Sql_Manager01.cmd[17].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[17].Parameters.Clear();
            Sql_Manager01.cmd[17].Parameters.AddWithValue("@code", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[17].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["code"].ToString()}";


                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[3].Close();
            return data01[0];
        }
        public string find_code_using_language(string input)
        {
            Sql_Manager01.conn[3].Open();
            Sql_Manager01.cmd[18].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[18].Parameters.Clear();
            Sql_Manager01.cmd[18].Parameters.AddWithValue("@language", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[18].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["code"].ToString()}";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[3].Close();
            return data01[0];
        }
        public string find_language_using_code(string input)
        {
            Sql_Manager01.conn[3].Open();
            Sql_Manager01.cmd[19].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[19].Parameters.Clear();
            Sql_Manager01.cmd[19].Parameters.AddWithValue("@code", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[19].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["language"].ToString()}";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[3].Close();
            return data01[0];
        }
        public string find_language_using_Language(string input)
        {
            Sql_Manager01.conn[3].Open();
            Sql_Manager01.cmd[20].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[20].Parameters.Clear();
            Sql_Manager01.cmd[20].Parameters.AddWithValue("@language", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[20].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["language"].ToString()}";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[3].Close();
            return data01[0];
        }
        public string view_all_data_from_language_table()
        {


            Sql_Manager01.conn[3].Open();
            Sql_Manager01.cmd[22].Parameters.Clear();
            Sql_Manager01.cmd[22].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[22].ExecuteReader())
            {
                while (reader.Read())
                {

                    data01[0] += $"{reader["code"]}\n" +
                                 $"{reader["language"]}\n";
                    code.Add(reader["code"].ToString());
                    language.Add(reader["language"].ToString());
                }
            }
            data01[1] += $"{string.Join(" ", code)}\n" +
                         $"{string.Join(" ", language)}\n";

            Sql_Manager01.conn[3].Close();
            return data01[0];

        }

    }
}
