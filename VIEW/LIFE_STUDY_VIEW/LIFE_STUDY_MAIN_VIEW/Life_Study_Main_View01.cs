
using E_APP02.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_SELECTION_VIEW;
namespace E_APP02.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_MAIN_VIEW
{
    internal class Life_Study_Main_View01
    {
        private static string[] data01 = new string[100];
        public Life_Study_Main_View01()
        {
            load_Life_Study_Main_View01().Wait();


        }
        private async Task load_Life_Study_Main_View01()
        {
            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) Bible study \n" +
$"2.) Enoch study \n" +
$"3.) jubilees study\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    new Life_Study_View01();
                    break;
                case 2:
                    new Life_Study_View02();
                    break;
                case 3:
                    new Life_Study_View03();
                    break;
            }
        }
    }
}
