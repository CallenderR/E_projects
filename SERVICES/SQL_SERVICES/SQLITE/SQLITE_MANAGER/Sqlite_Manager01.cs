using SQLite;

namespace E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_MANAGER
{
    internal class Sqlite_Manager01
    {
        private static readonly string[] connectionString_ = { "users.db3",
                                                               "Element_table01.db3",
                                                               "Element_category_type_table01.db3",
                                                               "Device_table.db3",
                                                               "Language_table.db3"};
        private static readonly SQLiteAsyncConnection[] database01 = {new SQLiteAsyncConnection(connectionString_[0]),
                                                                      new SQLiteAsyncConnection(connectionString_[1]),
                                                                      new SQLiteAsyncConnection(connectionString_[2]),
                                                                      new SQLiteAsyncConnection(connectionString_[3]),
                                                                      new SQLiteAsyncConnection(connectionString_[4]),
        };
        public static async Task InitializeAsync()
        {
            await database01[0].CreateTableAsync<MODEL.SQLITE_MODEL.SQLITE_USERS.SQLITE_GET_MODEL.Sqlite_Get_Model01>();
            await database01[1].CreateTableAsync<MODEL.SQLITE_MODEL.SQLITE_CHEMISTRY.SQLITE_GET_MODEL.Sqlite_Get_Model01>();
            await database01[2].CreateTableAsync<MODEL.SQLITE_MODEL.SQLITE_CHEMISTRY.SQLITE_GET_MODEL.Sqlite_Get_Model02>();
            await database01[3].CreateTableAsync<MODEL.SQLITE_MODEL.SQLITE_DEVICES.SQLITE_GET_MODEL.Sqlite_Model01>();
            await database01[4].CreateTableAsync<MODEL.SQLITE_MODEL.SQLITE_LANGUAGE.SQLITE_GET_MODEL.Sqlite_Get_Model01>();
        }


        public static SQLiteAsyncConnection[] conn => database01;   
    }
}
