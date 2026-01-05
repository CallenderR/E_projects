using E_APP02.VIEW.WEATHER_VIEW.WEATHER_SELECTION_VIEW;

namespace E_APP02.VIEW.WEATHER_VIEW.WEATHER_MAIN_VIEW
{
    internal class Weather_Main_View01
    {
        private static string[] data01 = new string[100];
        public Weather_Main_View01()
        {
            load_Weather_Main_View01().Wait();


        }
        private async Task load_Weather_Main_View01()
        {
            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) Weather 01 \n" +
$"2.) Weather 02 \n" +
$"3.) Weather 03 \n" +
$"4.) Weather 04 \n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    new Weather_View01();
                    break;
                case 2:
                    new Weather_View02();
                    break;
                case 3:
                    new Weather_View03();
                    break;
                case 4:
                    new Weather_View04();
                    break;


            }
        }
    }
}