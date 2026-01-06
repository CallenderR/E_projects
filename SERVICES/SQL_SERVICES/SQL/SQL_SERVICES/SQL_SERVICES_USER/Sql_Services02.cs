using E_APP02.MODELS.CHAT_MODEL.CHAT_SET_MODEL;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_TEST;
using E_APP02.TEMPLATE.TEXTS;
using Microsoft.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data;


namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_USER
{
    internal class Sql_Services02
    {
        private static string[] data01 = new string[10];
        private static List<string> username = new List<string>();
        private static List<string> name = new List<string>();
        private static List<string> text = new List<string>();
        private static List<string> date = new List<string>();

        public ObservableCollection<Chat_Set_Model01> collectiondata01 = new ObservableCollection<Chat_Set_Model01>();

        public string[] data_array = {"chat","View chat"};
        public string insert_chat(string input01, string input02, string input03)
        {
            DateTime dateTime = DateTime.Now;
            data01[0] = dateTime.ToString("yyyy-MM-dd HH:mm:ss");

            Sql_Manager01.conn[1].Open();
            Sql_Manager01.cmd[5].Parameters.Clear();
            Sql_Manager01.cmd[5].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[5].Parameters.AddWithValue("@username", input01);
            Sql_Manager01.cmd[5].Parameters.AddWithValue("@name", input02);
            Sql_Manager01.cmd[5].Parameters.AddWithValue("@text", input03);
            Sql_Manager01.cmd[5].Parameters.AddWithValue("@date", data01[0]);
            int rowsAffected = Sql_Manager01.cmd[5].ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                data01[1] = Default_Text01.text02[3];
            }

            else
            {
                data01[1] = Default_Text01.text02[2];
            }

            Sql_Manager01.conn[1].Close();
            return data01[1];
        }
        public string view_chat()
        {
            collectiondata01.Clear();
            Sql_Manager01.conn[1].Open();
            Sql_Manager01.cmd[6].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[6].ExecuteReader())
            {
                while (reader.Read())
                {
                    username.Add(reader["username"].ToString());
                    name.Add(reader["name"].ToString());
                    name.Add(reader["text"].ToString());
                    date.Add(reader["date"].ToString());

                    data01[1] += $"{reader["username"].ToString()}\n" +
                                 $"{reader["name"].ToString()}\n" +
                                 $"{reader["text"].ToString()}\n" +
                                 $"{reader["date"].ToString()}\n";
                    var collection_set = new Chat_Set_Model01
                    {

                        Username = reader["username"].ToString(),
                        Name = reader["name"].ToString(),
                        Text = reader["text"].ToString(),
                        Date = reader["date"].ToString()
                    };



                    collectiondata01.Add(collection_set);
                }
            }
            data01[2] += $"{string.Join(" ", username)}\n" +
                         $"{string.Join(" ", name)}\n" +
                         $"{string.Join(" ", text)}\n" +
                         $"{string.Join(" ", date)}\n";



            Sql_Manager01.conn[1].Close();
            return data01[1];
        }
        public string view_latest_message()
        {
            collectiondata01.Clear();
            Sql_Manager01.conn[1].Open();
            Sql_Manager01.cmd[57].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[57].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[3] += $"{reader["username"].ToString()}\n" +
                                 $"{reader["name"].ToString()}\n" +
                                 $"{reader["text"].ToString()}\n" +
                                 $"{reader["date"].ToString()}\n";
                    var collection_set = new Chat_Set_Model01
                    {

                        Username = reader["username"].ToString(),
                        Name = reader["name"].ToString(),
                        Text = reader["text"].ToString(),
                        Date = reader["date"].ToString()
                    };
                    collectiondata01.Add(collection_set);
                }
                else
                {
                    data01[3] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[1].Close();
            return data01[3];
        }
    }
}

