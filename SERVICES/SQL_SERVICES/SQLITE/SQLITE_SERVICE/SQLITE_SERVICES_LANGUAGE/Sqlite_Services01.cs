using E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_MANAGER;
using E_APP02.TEMPLATE.TEXTS;


namespace E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_LANGUAGE
{
    internal class Sqlite_Services01
    {
        private static  string[] data01 = new string[100];
        public async Task<string> insert_language_table(
                                 int input01, string input02)
        {

            try
            {
                var user = new MODEL.SQLITE_MODEL.SQLITE_LANGUAGE.SQLITE_GET_MODEL.Sqlite_Get_Model01
                {
                   code = input01,
                    language = input02,
                                   };

                await Sqlite_Manager01.conn[4].InsertAsync(user);

                data01[0] = Default_Text01.text02[4]; // "Inserted Successfully"
                return data01[0];
            }
            catch (Exception ex)
            {
                data01[0] = $"{Default_Text01.text02[2]}\n{ex.Message}";
                return data01[0];
            }

        }
        public async Task<string> view_language_table()
        {

            try
            {
                var resualts = await Sqlite_Manager01.conn[4].Table< MODEL.SQLITE_MODEL.SQLITE_LANGUAGE.SQLITE_GET_MODEL.Sqlite_Get_Model01>().ToListAsync();
                foreach (var a in resualts)
                {
                    data01[2] +=
                                  $"language: {a.code}\n" +
                                   $"language: {a.language}\n";
                }
                return data01[2];
            }
            catch (Exception ex)
            {
                data01[2] = $"{Default_Text01.text02[2]}\n{ex.Message}";
                return data01[2];
            }
        }
    }
}
