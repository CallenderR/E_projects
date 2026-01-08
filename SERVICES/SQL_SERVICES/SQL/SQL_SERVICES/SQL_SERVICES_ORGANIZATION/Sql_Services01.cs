using E_APP02.MODELS.CLIENT_MODEL;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_TEST;
using E_APP02.TEMPLATE.TEXTS;
using Microsoft.Data.SqlClient;
using System.Data;


namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_ORGANIZATION
{
    internal class Sql_Services01
    {
        private static string[] data01 = new string[3];
        private  List<string> Organization_logo = new List<string>();
        private  List<string> Organization_name = new List<string>();
        private  List<string> Organization_email = new List<string>();
        private  List<string> Organization_number = new List<string>();
        private  List<string> Organization_address = new List<string>();
        private  List<string> Organization_latitude = new List<string>();
        private  List<string> Organization_longitude = new List<string>();
        private  List<string> Organization_primary_color = new List<string>();
        private  List<string> Organization_secondary_color = new List<string>();
        private  List<string> Organization_tertiary_color = new List<string>();
        private  List<string> Organization_social_media = new List<string>();
        private  List<string> Organization_type = new List<string>();
        public static List<Client_Model01> collectiondata01 = new List<Client_Model01>();
        public string[] data_array = { "Organization email",//0
                                       "Organization name",//1
                                       "Organization number",//2
                                       "Organization address",//3
                                       "Organization logo",//4

        };

 

        public  string find_client_data_using_email(string input01)
        {
            Sql_Manager01.conn[4].Open();
            Sql_Manager01.cmd[18].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[18].Parameters.Clear();
            Sql_Manager01.cmd[18].Parameters.AddWithValue("@Organization_email", input01);
            using (SqlDataReader reader = Sql_Manager01.cmd[18].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] =
                  $"{reader["@Organization_logo"].ToString()}\n" +
                  $"{reader["@Organization_name"].ToString()}\n" +
                  $"{reader["@Organization_email"].ToString()}\n" +
                  $"{reader["@Organization_number"].ToString()}\n" +
                  $"{reader["@Organization_address"].ToString()}\n" +
                  $"{reader["@Organization_latitude"].ToString()}\n" +
                  $"{reader["@Organization_longitude"].ToString()}\n" +
                  $"{reader["@Organization_primary_color"].ToString()}\n" +
                  $"{reader["@Organization_secondary_color"].ToString()}\n" +
                  $"{reader["@Organization_tertiary_color"].ToString()}\n" +
                  $"{reader["@Organization_social_media"].ToString()}\n" +
                  $"{reader["@Organization_type"].ToString()}\n";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[4].Close();
            return data01[0];
        }
        public  string find_client_data_using_latitude_and_longitude(string[] input01)
        {
            Sql_Manager01.conn[4].Open();
            Sql_Manager01.cmd[19].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[19].Parameters.Clear();
            Sql_Manager01.cmd[19].Parameters.AddWithValue("@Organization_email", input01);
            using (SqlDataReader reader = Sql_Manager01.cmd[19].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] =
                  $"{reader["@Organization_logo"].ToString()}\n" +
                  $"{reader["@Organization_name"].ToString()}\n" +
                  $"{reader["@Organization_email"].ToString()}\n" +
                  $"{reader["@Organization_number"].ToString()}\n" +
                  $"{reader["@Organization_address"].ToString()}\n" +
                  $"{reader["@Organization_latitude"].ToString()}\n" +
                  $"{reader["@Organization_longitude"].ToString()}\n" +
                  $"{reader["@Organization_primary_color"].ToString()}\n" +
                  $"{reader["@Organization_secondary_color"].ToString()}\n" +
                  $"{reader["@Organization_tertiary_color"].ToString()}\n" +
                  $"{reader["@Organization_social_media"].ToString()}\n" +
                  $"{reader["@Organization_type"].ToString()}\n";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[19].Close();
            return data01[0];
        }
        public string find_client_data_using_logo(string input01)
        {
            Sql_Manager01.conn[4].Open();
            Sql_Manager01.cmd[20].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[20].Parameters.Clear();
            Sql_Manager01.cmd[20].Parameters.AddWithValue("@Organization_logo", input01);
            using (SqlDataReader reader = Sql_Manager01.cmd[20].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] =
                  $"{reader["@Organization_logo"].ToString()}\n" +
                  $"{reader["@Organization_name"].ToString()}\n" +
                  $"{reader["@Organization_email"].ToString()}\n" +
                  $"{reader["@Organization_number"].ToString()}\n" +
                  $"{reader["@Organization_address"].ToString()}\n" +
                  $"{reader["@Organization_latitude"].ToString()}\n" +
                  $"{reader["@Organization_longitude"].ToString()}\n" +
                  $"{reader["@Organization_primary_color"].ToString()}\n" +
                  $"{reader["@Organization_secondary_color"].ToString()}\n" +
                  $"{reader["@Organization_tertiary_color"].ToString()}\n" +
                  $"{reader["@Organization_social_media"].ToString()}\n" +
                  $"{reader["@Organization_type"].ToString()}\n";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[4].Close();
            return data01[0];
        }
        public  string find_client_data_using_name(string input01)
        {
            Sql_Manager01.conn[4].Open();
            Sql_Manager01.cmd[21].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[21].Parameters.Clear();
            Sql_Manager01.cmd[21].Parameters.AddWithValue("@Organization_name", input01);
            using (SqlDataReader reader = Sql_Manager01.cmd[21].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] =
                  $"{reader["@Organization_logo"].ToString()}\n" +
                  $"{reader["@Organization_name"].ToString()}\n" +
                  $"{reader["@Organization_email"].ToString()}\n" +
                  $"{reader["@Organization_number"].ToString()}\n" +
                  $"{reader["@Organization_address"].ToString()}\n" +
                  $"{reader["@Organization_latitude"].ToString()}\n" +
                  $"{reader["@Organization_longitude"].ToString()}\n" +
                  $"{reader["@Organization_primary_color"].ToString()}\n" +
                  $"{reader["@Organization_secondary_color"].ToString()}\n" +
                  $"{reader["@Organization_tertiary_color"].ToString()}\n" +
                  $"{reader["@Organization_social_media"].ToString()}\n" +
                  $"{reader["@Organization_type"].ToString()}\n";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[21].Close();
            return data01[0];
        }
        public  string find_client_data_using_number(string input01)
        {
            Sql_Manager01.conn[4].Open();
            Sql_Manager01.cmd[22].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[22].Parameters.Clear();
            Sql_Manager01.cmd[22].Parameters.AddWithValue("@Organization_number", input01);
            using (SqlDataReader reader = Sql_Manager01.cmd[22].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] =
                  $"{reader["@Organization_logo"].ToString()}\n" +
                  $"{reader["@Organization_name"].ToString()}\n" +
                  $"{reader["@Organization_email"].ToString()}\n" +
                  $"{reader["@Organization_number"].ToString()}\n" +
                  $"{reader["@Organization_address"].ToString()}\n" +
                  $"{reader["@Organization_latitude"].ToString()}\n" +
                  $"{reader["@Organization_longitude"].ToString()}\n" +
                  $"{reader["@Organization_primary_color"].ToString()}\n" +
                  $"{reader["@Organization_secondary_color"].ToString()}\n" +
                  $"{reader["@Organization_tertiary_color"].ToString()}\n" +
                  $"{reader["@Organization_social_media"].ToString()}\n" +
                  $"{reader["@Organization_type"].ToString()}\n";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[4].Close();
            return data01[0];
        }
        public  string insert_client_data(string[] input01)
        {
            Sql_Manager01.conn[3].Open();
            Sql_Manager01.cmd[23].Parameters.Clear();
            Sql_Manager01.cmd[23].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[23].Parameters.AddWithValue("@Organization_logo", input01[0]);
            Sql_Manager01.cmd[23].Parameters.AddWithValue("@Organization_name", input01[1]);
            Sql_Manager01.cmd[23].Parameters.AddWithValue("@Organization_email", input01[2]);
            Sql_Manager01.cmd[23].Parameters.AddWithValue("@Organization_number", input01[3]);
            Sql_Manager01.cmd[23].Parameters.AddWithValue("@Organization_address", input01[4]);
            Sql_Manager01.cmd[23].Parameters.AddWithValue("@Organization_latitude", input01[5]);
            Sql_Manager01.cmd[23].Parameters.AddWithValue("@Organization_longitude", input01[6]);
            Sql_Manager01.cmd[23].Parameters.AddWithValue("@Organization_primary_color", input01[7]);
            Sql_Manager01.cmd[23].Parameters.AddWithValue("@Organization_secondary_color", input01[8]);
            Sql_Manager01.cmd[23].Parameters.AddWithValue("@Organization_tertiary_color", input01[9]);
            Sql_Manager01.cmd[23].Parameters.AddWithValue("@Organization_social_media", input01[0]);
            Sql_Manager01.cmd[23].Parameters.AddWithValue("@Organization_type", input01[10]);
            int rowsAffected = Sql_Manager01.cmd[23].ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                data01[0] = Default_Text01.text02[3];
            }

            else
            {
                data01[0] = Default_Text01.text02[2];
            }

            Sql_Manager01.conn[4].Close();
            return data01[0];
        }
        public  string view_all_data_from_client_table()
        {
            Sql_Manager01.conn[4].Open();
            Sql_Manager01.cmd[24].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[24].ExecuteReader())
            {
                while (reader.Read())
                {

                    Organization_logo.Add(reader["organization_logo"].ToString());
                    Organization_name.Add(reader["organization_name"].ToString());
                    Organization_email.Add(reader["organization_email"].ToString());
                    Organization_number.Add(reader["organization_number"].ToString());
                    Organization_address.Add(reader["organization_address"].ToString());
                    Organization_latitude.Add(reader["organization_latitude"].ToString());
                    Organization_longitude.Add(reader["organization_longitude"].ToString());
                    Organization_primary_color.Add(reader["organization_primary_color"].ToString());
                    Organization_secondary_color.Add(reader["organization_secondary_color"].ToString());
                    Organization_tertiary_color.Add(reader["organization_tertiary_color"].ToString());
                    Organization_social_media.Add(reader["organization_social_media"].ToString());
                    Organization_type.Add(reader["organization_type"].ToString());

                    data01[0] +=
                                    $"{reader["Organization_logo"].ToString()}\n" +
                                    $"{reader["Organization_name"].ToString()}\n" +
                    $"{reader["Organization_email"].ToString()}\n" +
               $"{reader["Organization_number"].ToString()}\n" +
                    $"{reader["Organization_address"].ToString()}\n" +
                  $"{reader["Organization_latitude"].ToString()}\n" +
                    $"{reader["Organization_longitude"].ToString()}\n" +
               $"{reader["Organization_primary_color"].ToString()}\n" +
                  $"{reader["Organization_secondary_color"].ToString()}\n" +
                 $"{reader["Organization_tertiary_color"].ToString()}\n" +
                 $"{reader["Organization_social_media"].ToString()}\n" +
                $"{reader["Organization_type"].ToString()}\n";


                    var collection_set = new Client_Model01
                    {

                        Organization_logo = reader["Organization_logo"].ToString(),
                        Organization_name = reader["Organization_name"].ToString(),
                        Organization_email = reader["Organization_email"].ToString(),
                        Organization_number = reader["Organization_number"].ToString(),
                        Organization_address = reader["Organization_address"].ToString(),
                        Organization_latitude = reader["Organization_latitude"].ToString(),
                        Organization_longitude = reader["Organization_longitude"].ToString(),
                        Organization_primary_color = reader["Organization_primary_color"].ToString(),
                        Organization_secondary_color = reader["Organization_secondary_color"].ToString(),
                        Organization_tertiary_color = reader["Organization_tertiary_color"].ToString(),
                        Organization_social_media = reader["Organization_social_media"].ToString(),
                        Organization_type = reader["Organization_type"].ToString()

                    };

                    collectiondata01.Add(collection_set);

                }
            }

            data01[1] += $"{string.Join(" ", Organization_logo)}\n" +
            $"{string.Join(" ", Organization_name)}\n" +
            $"{string.Join(" ", Organization_email)}\n" +
            $"{string.Join(" ", Organization_number)}\n" +
            $"{string.Join(" ", Organization_address)}\n" +
            $"{string.Join(" ", Organization_latitude)}\n" +
            $"{string.Join(" ", Organization_longitude)}\n" +
            $"{string.Join(" ", Organization_primary_color)}\n" +
            $"{string.Join(" ", Organization_secondary_color)}\n" +
            $"{string.Join(" ", Organization_tertiary_color)}\n" +
            $"{string.Join(" ", Organization_social_media)}\n" +
            $"{string.Join(" ", Organization_type)}\n";

            return data01[1];
        }
    }
}
