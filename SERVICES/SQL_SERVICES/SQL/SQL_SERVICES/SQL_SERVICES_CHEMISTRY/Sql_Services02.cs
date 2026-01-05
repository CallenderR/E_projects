using E_APP02.MODELS.SCIENCE_MODEL.CHEMISTRY_MODEL.CHEMISTRY_SET_MODEL;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_TEST;
using E_APP02.TEMPLATE.TEXTS;
using Microsoft.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data;



namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_CHEMISTRY
{
    internal class Sql_Services02
    {
        private static string[] data01 = new string[3];
        private static List<int> atomic_number = new List<int>();
        private static List<string> element_name = new List<string>();
        private static List<string> element_symboles = new List<string>();
        private static List<string> atomic_mass = new List<string>();
        private static List<int> protons = new List<int>();
        private static List<int> electons = new List<int>();
        private static List<int> neutrons = new List<int>();
        public List<Chemistry_Set_Model01> collectiondata01 = new List<Chemistry_Set_Model01>();
        public static string insert_element(int input01, string input02,
                                            string input03, string input04,
                                            int input05, int input06, int input07)
        {
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[0].Parameters.Clear();
            Sql_Manager01.cmd[0].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[0].Parameters.AddWithValue("@atomic_number", input01.ToString());
            Sql_Manager01.cmd[0].Parameters.AddWithValue("@element_name", input02);
            Sql_Manager01.cmd[0].Parameters.AddWithValue("@element_symboles", input03);
            Sql_Manager01.cmd[0].Parameters.AddWithValue("@atomic_mass", input04);
            Sql_Manager01.cmd[0].Parameters.AddWithValue("@protons ", input05);
            Sql_Manager01.cmd[0].Parameters.AddWithValue("@electons", input06);
            Sql_Manager01.cmd[0].Parameters.AddWithValue("@neutrons", input07);
            object result = Sql_Manager01.cmd[0].ExecuteScalar();

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

            Sql_Manager01.conn[0].Close();
            return data01[0];
        }
        public string find_element_using_name(string input)
        {
            collectiondata01.Clear();
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[1].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[1].Parameters.Clear();
            Sql_Manager01.cmd[1].Parameters.AddWithValue("@element_name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[1].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["atomic_number"].ToString()}\n" +
                                $"{reader["element_name"].ToString()}\n" +
                                $"{reader["element_symboles"].ToString()}\n" +
                                $"{reader["atomic_mass"].ToString()}\n" +
                                $"{reader["protons"].ToString()}\n" +
                                $"{reader["electons"].ToString()}\n" +
                                $"{reader["neutrons"].ToString()}\n";
                    var collection_set = new Chemistry_Set_Model01
                    {

                        Atomic_number = (int.Parse(reader["atomic_number"].ToString())),
                        Element_name = (reader["element_name"].ToString()),
                        Element_symboles = (reader["element_symboles"].ToString()),
                        Atomic_mass = (reader["atomic_mass"].ToString()),

                    };

                    collectiondata01.Add(collection_set);

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[0].Close();
            return data01[0];
        }

        public string find_element_using_atomic_number(string input)
        {
            collectiondata01.Clear();
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[2].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[2].Parameters.Clear();
            Sql_Manager01.cmd[2].Parameters.AddWithValue("@atomic_number", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[2].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["atomic_number"].ToString()}\n" +
                                $"{reader["element_name"].ToString()}\n" +
                                $"{reader["element_symboles"].ToString()}\n" +
                                $"{reader["atomic_mass"].ToString()}\n" +
                                $"{reader["protons"].ToString()}\n" +
                                $"{reader["electons"].ToString()}\n" +
                                $"{reader["neutrons"].ToString()}\n";
                    var collection_set = new Chemistry_Set_Model01
                    {

                        Atomic_number = (int.Parse(reader["atomic_number"].ToString())),
                        Element_name = (reader["element_name"].ToString()),
                        Element_symboles = (reader["element_symboles"].ToString()),
                        Atomic_mass = (reader["atomic_mass"].ToString()),
                        Protons = (int.Parse(reader["protons"].ToString())),
                        Electons = (int.Parse(reader["electons"].ToString())),
                        Neutrons = (int.Parse(reader["neutrons"].ToString())),
                    };

                    collectiondata01.Add(collection_set);

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[0].Close();
            return data01[0];
        }

        public string find_element_using_symbol(string input)
        {
            collectiondata01.Clear();
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[3].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[3].Parameters.Clear();
            Sql_Manager01.cmd[3].Parameters.AddWithValue("@element_symboles", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[3].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["atomic_number"].ToString()}\n" +
                                $"{reader["element_name"].ToString()}\n" +
                                $"{reader["element_symboles"].ToString()}\n" +
                                $"{reader["atomic_mass"].ToString()}\n" +
                                $"{reader["protons"].ToString()}\n" +
                                $"{reader["electons"].ToString()}\n" +
                                $"{reader["neutrons"].ToString()}\n";
                    var collection_set = new Chemistry_Set_Model01
                    {

                        Atomic_number = (int.Parse(reader["atomic_number"].ToString())),
                        Element_name = (reader["element_name"].ToString()),
                        Element_symboles = (reader["element_symboles"].ToString()),
                        Atomic_mass = (reader["atomic_mass"].ToString()),
                        Protons = (int.Parse(reader["protons"].ToString())),
                        Electons = (int.Parse(reader["electons"].ToString())),
                        Neutrons = (int.Parse(reader["neutrons"].ToString())),
                    };

                    collectiondata01.Add(collection_set);

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[0].Close();
            return data01[0];
        }
        public string view_all_elements()
        {
            collectiondata01.Clear();
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[4].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[4].ExecuteReader())
            {
                while (reader.Read())
                {
                    atomic_number.Add(int.Parse(reader["atomic_number"].ToString()));
                    element_name.Add(reader["element_name"].ToString());
                    element_symboles.Add(reader["element_symboles"].ToString());
                    atomic_mass.Add(reader["atomic_mass"].ToString());
                    protons.Add(int.Parse(reader["protons"].ToString()));
                    electons.Add(int.Parse(reader["electons"].ToString()));
                    neutrons.Add(int.Parse(reader["neutrons"].ToString()));
                    data01[0] += $"{reader["atomic_number"].ToString()}\n" +
                                 $"{reader["element_name"].ToString()}\n" +
                                 $"{reader["element_symboles"].ToString()}\n" +
                                 $"{reader["atomic_mass"].ToString()}\n" +
                                 $"{reader["protons"].ToString()}\n" +
                                 $"{reader["electons"].ToString()}\n" +
                                 $"{reader["neutrons"].ToString()}\n";




                    var collection_set = new Chemistry_Set_Model01
                    {

                        Atomic_number = (int.Parse(reader["atomic_number"].ToString())),
                        Element_name = (reader["element_name"].ToString()),
                        Element_symboles = (reader["element_symboles"].ToString()),
                        Atomic_mass = (reader["atomic_mass"].ToString()),
                        Protons = (int.Parse(reader["protons"].ToString())),
                        Electons = (int.Parse(reader["electons"].ToString())),
                        Neutrons = (int.Parse(reader["neutrons"].ToString())),
                    };

                    collectiondata01.Add(collection_set);

                }
            }
            data01[1] += $"{string.Join(" ", atomic_number)}\n" +
                         $"{string.Join(" ", element_name)}\n" +
                         $"{string.Join(" ", element_symboles)}\n" +
                         $"{string.Join(" ", atomic_mass)}\n" +
                         $"{string.Join(" ", protons)}\n" +
                         $"{string.Join(" ", electons)}\n" +
                         $"{string.Join(" ", neutrons)}\n";
            Sql_Manager01.conn[0].Close();
            return data01[1];
        }

    }
}
