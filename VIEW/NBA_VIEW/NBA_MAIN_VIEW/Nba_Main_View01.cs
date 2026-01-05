

using E_APP02.VIEW.NBA_VIEW.NBA_SELECTION_VIEW;
using E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW;

namespace E_APP02.VIEW.NBA_VIEW.NBA_MAIN_VIEW
{
    internal class Nba_Main_View01
    {
        private static string[] data01 = new string[100];
        public Nba_Main_View01()
        {
            load_Nba_Main_View01();


        }
        private void load_Nba_Main_View01()
        {
            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) NBA 01 \n" +
$"2.) NBA 02 \n" +
$"3.) NBA 03 \n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    new Nba_View01();
                    break;
                case 2:
                    new Nba_View02();
                    break;
                case 3:
                    new Nba_View03();
                    break;

            }
        }
    }
}