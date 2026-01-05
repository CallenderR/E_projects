
using E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_MANAGER;
using E_APP02.VIEW.SCIENCE_VIEW.SCIENCE_SELECTION_VIEW.CHEMISTRY_VIEW;
using E_APP02.VIEW.SCIENCE_VIEW.SCIENCE_SELECTION_VIEW.SCIENCE_VIEW;


namespace E_APP02.VIEW.SCIENCE_VIEW.SCIENCE_MAIN_VIEW
{
    internal class Science_Main_View01
    {
        private static string[] data01 = new string[100];
        public Science_Main_View01()
        {
            load_Science_Main_View01();


        }
        private void load_Science_Main_View01()
        {
            data01[0] = $"Select View\n" +
                        $"-------------------------\n" +
                        $"1.) Chemistry 01 \n" +
                        $"2.) Nasa 02 \n" ;
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
    
                    new Chemistry_View01();
                    break;
                case 2:
                    new Science_View01();
                    break;
                

            }
        }
    }
}