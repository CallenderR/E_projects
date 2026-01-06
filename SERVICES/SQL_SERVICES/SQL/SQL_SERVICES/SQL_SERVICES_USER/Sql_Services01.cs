using E_APP02.SERVICES.DEVICE_SERVICES;
using E_APP02.TEMPLATE.TEXTS;
using Microsoft.Data.SqlClient;
using System.Data;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_USER;

namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_USER
{
    internal class Sql_Services01
    {
        private static string[] data01 = new string[100];

        public string[] data_array = {"username","firstname","lastname",
                                             "birthdate", "email","phonenumber",
                                             "password","longitude","latitude",
                                             "creation_date"};


     

        public string insert_user(string input01, string input02, string input03,
                                          string input04, string input05, string input06,
                                          string input07)
        {

            DateTime dateTime = DateTime.Now;
            data01[0] = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string[] results = Device_Services.get_device_ip().Result.Split(',');
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@username", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@firstname", input02);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@lastname", input03);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@birthdate", input04);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@email", input05);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@phonenumber", input06);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@password", input07);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@longitude", results[0]);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@latitude", results[1]);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@creation_date", data01[0]);
            int rowsAffected = Sql_Manager01.cmd[9].ExecuteNonQuery();
            if (Sql_Manager01.cmd[9].ExecuteNonQuery() == null)
            {
                if (rowsAffected > 0)
                {
                    data01[1] = Default_Text01.text02[3];
                }

                else
                {
                    data01[1] = Default_Text01.text02[2];
                }
            }
            else
            {
                data01[1] = Default_Text01.text02[5];
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[1];

        }
        public string find_email_using_email(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["email"].ToString()}";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];

        }

        public string find_email_using_username(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["email"].ToString()}";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public string find_phonenumber_using_email(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["phonenumber"].ToString()}";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public string find_phonenumber_using_username(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["phonenumber"].ToString()}";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public string find_phonenumber_using_phonenumber(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].Parameters.AddWithValue("@phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["phonenumber"].ToString()}";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public string find_user_location_using_email(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["latitude"].ToString()}" +
                                $"{reader["longitude"].ToString()}";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public string find_user_location_using_username(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["latitude"].ToString()}" +
                                $"{reader["longitude"].ToString()}";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public string find_username_using_email(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["username"].ToString()}";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public string find_username_using_username(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["username"].ToString()}";

                }
                else
                {
                    data01[0] = Default_Text01.text02[2];

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public string find_password_using_email(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["password"].ToString()}";
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public string find_password_using_username(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["password"].ToString()}";
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public string find_username_password(string input, string input01)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_password].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_password].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_password].Parameters.AddWithValue("@username", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_password].Parameters.AddWithValue("@password", input01);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_password].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["username"].ToString()}\n" +
                                $"{reader["password"].ToString()}\n";
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public string update_user_location_using_email(string input01, string input02, string input03)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_email].Parameters.AddWithValue("@email", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_email].Parameters.AddWithValue("@Latitude", input02);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_email].Parameters.AddWithValue("@Longitude", input03);

            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_email].ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                data01[0] = "Location updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that email.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public string update_user_location_using_name(string input01, string input02, string input03)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].Parameters.AddWithValue("@firstname", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].Parameters.AddWithValue("@lastname", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].Parameters.AddWithValue("@Latitude", input02);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].Parameters.AddWithValue("@Longitude", input03);

            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                data01[0] = "Location updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that email.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public string update_user_location_using_phonenumber(string input01, string input02, string input03)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_phonenumber].Parameters.AddWithValue("@phonenumber", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_phonenumber].Parameters.AddWithValue("@Latitude", input02);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_phonenumber].Parameters.AddWithValue("@Longitude", input03);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_phonenumber].ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                data01[0] = "Location updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that phone number.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public string update_user_location_using_username(string input01, string input02, string input03)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_username].Parameters.AddWithValue("@username", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_username].Parameters.AddWithValue("@Latitude", input02);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_username].Parameters.AddWithValue("@Longitude", input03);

            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_username].ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                data01[0] = "Location updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that username.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }



        public string view_all_users()
        {
            data01[0] = "";
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_users].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_users].ExecuteReader())
            {
                while (reader.Read())
                {
                    data01[0] += $"Username: {reader["username"].ToString()}, " +
                                 $"Firstname: {reader["firstname"].ToString()}, " +
                                 $"Lastname: {reader["lastname"].ToString()}, " +
                                 $"Birthdate: {reader["birthdate"].ToString()}, " +
                                 $"Email: {reader["email"].ToString()}, " +
                                 $"Phonenumber: {reader["phonenumber"].ToString()}, " +
                                 $"Creation Date: {reader["creation_date"].ToString()}\n";
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public async Task<string> update_phonenumber_using_email(string input01, string input02)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_email].Parameters.AddWithValue("@email", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_email].Parameters.AddWithValue("@phonenumber", input02);
            int rowsAffected = await Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_email].ExecuteNonQueryAsync();
            if (rowsAffected > 0)
            {
                data01[0] = "Phonenumber updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that email.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public async Task<string> update_phonenumber_using_username(string input01, string input02)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_username].Parameters.AddWithValue("@username", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_username].Parameters.AddWithValue("@phonenumber", input02);
            int rowsAffected = await Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_username].ExecuteNonQueryAsync();
            if (rowsAffected > 0)
            {
                data01[0] = "Phonenumber updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that username.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public async Task<string> update_email_using_username(string input01, string input02)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_username].Parameters.AddWithValue("@username", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_username].Parameters.AddWithValue("@email", input02);
            int rowsAffected = await Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_username].ExecuteNonQueryAsync();
            if (rowsAffected > 0)
            {
                data01[0] = "Email updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that username.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public async Task<string> update_email_using_email(string input01, string input02)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_email].Parameters.AddWithValue("@email", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_email].Parameters.AddWithValue("@new_email", input02);
            int rowsAffected = await Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_email].ExecuteNonQueryAsync();
            if (rowsAffected > 0)
            {
                data01[0] = "Email updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that email.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public async Task<string> update_username_using_email(string input01, string input02)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_email].Parameters.AddWithValue("@email", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_email].Parameters.AddWithValue("@username", input02);
            int rowsAffected = await Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_email].ExecuteNonQueryAsync();
            if (rowsAffected > 0)
            {
                data01[0] = "Username updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that email.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public async Task<string> update_username_using_username(string input01, string input02)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_username].Parameters.AddWithValue("@username", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_username].Parameters.AddWithValue("@new_username", input02);
            int rowsAffected = await Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_username].ExecuteNonQueryAsync();
            if (rowsAffected > 0)
            {
                data01[0] = "Username updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that username.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public async Task<string> update_username_using_phonenumber(string input01, string input02)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_phonenumber].Parameters.AddWithValue("@phonenumber", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_phonenumber].Parameters.AddWithValue("@username", input02);
            int rowsAffected = await Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_phonenumber].ExecuteNonQueryAsync();
            if (rowsAffected > 0)
            {
                data01[0] = "Username updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that phone number.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public async Task<string> update_password_using_username(string input01, string input02)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_username].Parameters.AddWithValue("@username", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_username].Parameters.AddWithValue("@password", input02);
            int rowsAffected = await Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_username].ExecuteNonQueryAsync();
            if (rowsAffected > 0)
            {
                data01[0] = "Password updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that username.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public async Task<string> update_password_using_email(string input01, string input02)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_email].Parameters.AddWithValue("@email", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_email].Parameters.AddWithValue("@password", input02);
            int rowsAffected = await Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_email].ExecuteNonQueryAsync();
            if (rowsAffected > 0)
            {
                data01[0] = "Password updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that email.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public async Task<string> update_password_using_phonenumber(string input01, string input02)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_phonenumber].Parameters.AddWithValue("@phonenumber", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_phonenumber].Parameters.AddWithValue("@password", input02);
            int rowsAffected = await Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_phonenumber].ExecuteNonQueryAsync();
            if (rowsAffected > 0)
            {
                data01[0] = "Password updated successfully.";
            }
            else
            {
                data01[0] = "No user found with that phone number.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public async Task<string> delete_user_using_email(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_email].Parameters.AddWithValue("@email", input);
            int rowsAffected = await Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_email].ExecuteNonQueryAsync();
            if (rowsAffected > 0)
            {
                data01[0] = "User deleted successfully.";
            }
            else
            {
                data01[0] = "No user found with that email.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public async Task<string> delete_user_using_username(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_username].Parameters.AddWithValue("@username", input);
            int rowsAffected = await Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_username].ExecuteNonQueryAsync();
            if (rowsAffected > 0)
            {
                data01[0] = "User deleted successfully.";
            }
            else
            {
                data01[0] = "No user found with that username.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public async Task<string> delete_user_using_phonenumber(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_phonenumber].Parameters.AddWithValue("@phonenumber", input);
            int rowsAffected = await Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_phonenumber].ExecuteNonQueryAsync();
            if (rowsAffected > 0)
            {
                data01[0] = "User deleted successfully.";
            }
            else
            {
                data01[0] = "No user found with that phone number.";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
    }
}


    