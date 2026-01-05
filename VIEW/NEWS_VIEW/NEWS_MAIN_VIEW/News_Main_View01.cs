using E_APP02.VIEW.NBA_VIEW.NBA_SELECTION_VIEW;
using E_APP02.VIEW.NEWS_VIEW.NEWS_SELECTION_VIEW;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_APP02.VIEW.NEWS_VIEW.NEWS_MAIN_VIEW
{
    internal class News_Main_View01
    {
        private static string[] data01 = new string[100];
        public News_Main_View01()
        {
            load_Nba_Main_View01().Wait();


        }
        private async Task load_Nba_Main_View01()
        {
            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) News 01 \n" ;
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    new News_View01();
                    break;


            }
        }
    }
}