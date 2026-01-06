using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_TEST;
using E_APP02.TEMPLATE.TEXTS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_LANGUAGE
{
    internal class Sql_Services02
    {
        private static string[] data01 = new string[3];
        private  List<string> path = new List<string>();
        private  List<string> file_namenguage = new List<string>();
        public string[] data_array = {
                                      "path",//0
                                      "file_name",//1
                                      
        
        };
        public string insert_language(string input01, string input02)
        {
            Sql_Manager01.conn[3].Open();
            Sql_Manager01.cmd[21].Parameters.Clear();
            Sql_Manager01.cmd[21].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[21].Parameters.AddWithValue("@path", input01);
            Sql_Manager01.cmd[21].Parameters.AddWithValue("@file_name", input02);
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
    }
}