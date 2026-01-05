using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_TEST;
using Microsoft.Data.SqlClient;

namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_HELPER
{
    internal class Sql_Helper01
    {
        private static string[] data01 = new string[3];

        public static string[] get_stored_procedures()
        {
            data01[0] = sql_data01();
            return data01;
        }
        private static string sql_data01()
        {
            int count = 0;
            for (int i = 0; i < Sql_Manager01.conn.Length; i++)
            {
                var conn = Sql_Manager01.conn[i];
                var cmd = new SqlCommand(@"
SELECT 
    SCHEMA_NAME(schema_id) + '.' + name AS ProcedureName
FROM sys.procedures
ORDER BY name", conn);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    data01[0] += ($"Stored Procedures in Database {conn.Database}\n");

                    while (reader.Read())
                    {
                        count++;
                        data01[0] += $"{count}.) {reader["ProcedureName"]}\n";
                    }
                }
                conn.Close();
            }
            return data01[0];
        }
        private static string Helper01()
        {
            string resualts = sql_data01();


            return data01[0];
        }

    }
}

