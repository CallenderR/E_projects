using E_APP02.SERVICES.WEATHER_SERVICES;


namespace E_APP02.VIEW.WEATHER_VIEW.WEATHER_SELECTION_VIEW
{
    internal class Weather_View01
    {
        private static string[] data01 = new string[100];
        private static Weather_Services01 Weather_Serv01 = new Weather_Services01();
        public Weather_View01()
        {
            load_Weather_View01().Wait();


        }
        private async Task load_Weather_View01()
        {
            data01[0] =
                 "1.) weather_data01\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    data01[2] = await Weather_Serv01.weather_data01();
                    Console.WriteLine(data01[2]);
                    break;


            }
        }
    }
}
