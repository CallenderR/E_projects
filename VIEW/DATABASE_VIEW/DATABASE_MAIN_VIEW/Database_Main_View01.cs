namespace E_APP02.VIEW.DATABASE_VIEW.DATABASE_MAIN_VIEW
{
    internal class Database_Main_View01
    {
        private static string[] data01 = new string[100];
        public Database_Main_View01()
        {
            load_Database_Main_View01().Wait();
        }
        private async Task load_Database_Main_View01()
        {
            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) DATABASE SQL 01 \n" +
$"2.) DATABASE SQLIE 01 \n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    new E_APP02.VIEW.DATABASE_VIEW.DATABASE_SELECTION_VIEW.DATABASE_SQL_VIEW.Database_View01();
                    break;
                case 2:
                    new E_APP02.VIEW.DATABASE_VIEW.DATABASE_SELECTION_VIEW.DATABASE_SQLITE_VIEW.Database_View01();
                    break;

            }
        }
    }
}
