using E_APP02.VIEW.TEST_VIEW.TEST_SELECTION_VIEW;
namespace E_APP02.VIEW.TEST_VIEW.TEST_MAIN_VOEW
{
    internal class Test_Main_View01
    {
        private static string[] data01 = new string[100];
        public Test_Main_View01()
        {
            load_Test_Main_View01().Wait();


        }
        private async Task load_Test_Main_View01()
        {
            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) test 01 \n" +
$"2.) test 02 \n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    new Test_View01();
                    break;

            }
        }
    }
}