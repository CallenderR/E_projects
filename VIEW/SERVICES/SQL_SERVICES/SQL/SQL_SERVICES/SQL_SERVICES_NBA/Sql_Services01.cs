using E_APP02.MODELS.NBA_MODEL.NBA_SET_MODEL.NBA_SET_MODEL02;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_NBA;
using E_APP02.TEMPLATE.TEXTS;
using Microsoft.Data.SqlClient;
using System.Data;

namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_NBA
{
    internal class Sql_Services01
    {
        private  List<string> get = new List<string>();
        private  List<object> parameters = new List<object>();
        private  List<object> errors = new List<object>();
        private  List<int> results = new List<int>();
        private  List<string> response01 = new List<string>();

        private  string[] data01 = new string[100];
        public List<Nba_Set_Model01> collectiondata01 = new List<Nba_Set_Model01>();
        public  string insert_Leagues(string input01, string input02,
                                            string input03, string input04,
                                            string input05)
        {
            Sql_Manager02.conn[0].Open();
            Sql_Manager02.cmd[0].Parameters.Clear();
            Sql_Manager02.cmd[0].CommandType = CommandType.StoredProcedure;
            Sql_Manager02.cmd[0].Parameters.AddWithValue("@get01", input01.ToString());
            Sql_Manager02.cmd[0].Parameters.AddWithValue("@parameters01", input02);
            Sql_Manager02.cmd[0].Parameters.AddWithValue("@errors", input03);
            Sql_Manager02.cmd[0].Parameters.AddWithValue("@results", input04);
            Sql_Manager02.cmd[0].Parameters.AddWithValue("@response01", input05);

            object result = Sql_Manager02.cmd[0].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                data01[0] = "Record already exists";
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                data01[0] = Default_Text01.text02[3]; // success text
            }
            else
            {

                data01[0] = "Unknown result from database";
            }

            Sql_Manager02.conn[0].Close();
            return data01[0];
        }

        public string view_all_Leagues()
        {
            collectiondata01.Clear();
            Sql_Manager02.conn[0].Open();
            Sql_Manager02.cmd[1].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager02.cmd[1].ExecuteReader())
            {
                while (reader.Read())
                {
                    get.Add(reader["get01"].ToString());
                    parameters.Add(reader["parameters01"].ToString());
                    errors.Add(reader["errors"].ToString());
                    results.Add(int.Parse(reader["results"].ToString()));
                    response01.Add(reader["response01"].ToString());

                    data01[0] += $"{reader["get01"].ToString()}\n" +
                                 $"{reader["parameters01"].ToString()}\n" +
                                 $"{reader["errors"].ToString()}\n" +
                                 $"{reader["response01"].ToString()}\n";



                    var collection_set = new Nba_Set_Model01
                    {
                        get = (reader["get01"]?.ToString() ?? string.Empty),
                        parameters = new List<object> { reader["parameters01"]?.ToString() ?? string.Empty },
                        errors = new List<object> { reader["errors"]?.ToString() ?? string.Empty },
                        response = new List<string> { reader["response01"]?.ToString() ?? string.Empty },
                    };

                    collectiondata01.Add(collection_set);

                }
            }
            data01[1] += $"{string.Join(" ", get)}\n" +
                         $"{string.Join(" ", parameters)}\n" +
                         $"{string.Join(" ", errors)}\n" +
                         $"{string.Join(" ", results)}\n";
            Sql_Manager02.conn[0].Close();
            return data01[1];
        }


    }
}
