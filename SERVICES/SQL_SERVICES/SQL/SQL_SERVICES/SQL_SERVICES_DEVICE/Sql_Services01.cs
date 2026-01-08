using E_APP02.MODELS.DEVICE_MODEL.DEVICE_SET_MODEL;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_TEST;
using E_APP02.TEMPLATE.TEXTS;
using Microsoft.Data.SqlClient;
using System.Data;


namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_DEVICE
{
    internal class Sql_Services01
    {
        private static string[] data01 = new string[3];
        private  List<string> Manufacturer = new List<string>();
        private  List<string> Model = new List<string>();
        private  List<string> Name01 = new List<string>();
        private  List<string> VersionString = new List<string>();
        private  List<string> Platform01 = new List<string>();
        private  List<string> Idiom = new List<string>();
        private  List<string> DeviceType = new List<string>();
        public static List<Device_Set_Model01> collectiondata01 = new List<Device_Set_Model01>();

      
        public async Task<string> insert_device_table(string input01, string input02, string input03, string input04,
                                                      string input05, string input06, string input07)
        {
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[67].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@Manufacturer", input01);
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@Model", input02);
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@Name01", input03);
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@VersionString", input04);
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@Platform01", input05);
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@Idiom", input06);
            Sql_Manager01.cmd[67].Parameters.AddWithValue("@DeviceType", input07);
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
        public async Task<string> view_device_table()
        {
            Sql_Manager01.conn[0].Open();
            Sql_Manager01.cmd[68].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[68].ExecuteReader())
            {
                while (await reader.ReadAsync())
                {
                    data01[0] +=
                                  $"Manufacturer: {reader["Manufacturer"].ToString()}\n" +
                                  $"Model: {reader["Manufacturer"].ToString()}\n" +
                                  $"Name01: {reader["Manufacturer"].ToString()}\n" +
                                  $"VersionString: {reader["Manufacturer"].ToString()}\n" +
                                  $"Platform01 : {reader["Manufacturer"].ToString()}\n" +
                                  $"Idiom: {reader["Manufacturer"].ToString()}\n" +
                                  $"DeviceType: {reader["Manufacturer"].ToString()}\n";


                    Manufacturer.Add(reader["Manufacturer"].ToString());
                    Model.Add(reader["Manufacturer"].ToString());
                    Name01.Add(reader["Manufacturer"].ToString());
                    VersionString.Add(reader["Manufacturer"].ToString());
                    Platform01.Add(reader["Manufacturer"].ToString());
                    Idiom.Add(reader["Manufacturer"].ToString());
                    DeviceType.Add(reader["Manufacturer"].ToString());


                    var collection_set = new Device_Set_Model01
                    {
                        Manufacturer = reader["Manufacturer"].ToString(),
                        Model = reader["Model"].ToString(),
                        Name01 = reader["Name01"].ToString(),
                        VersionString = reader["VersionString"].ToString(),
                        Platform01 = reader["Platform01"].ToString(),
                        Idiom = reader["Idiom"].ToString(),
                        DeviceType = reader["DeviceType"].ToString(),
                    };
                    collectiondata01.Add(collection_set);


                }
            }
            Sql_Manager01.conn[0].Close();
            return data01[0];
        }
    }
}
