
using E_APP02.SERVICES.WEATHER_SERVICES;


namespace E_APP02.VIEW.WEATHER_VIEW.WEATHER_SELECTION_VIEW
{
    internal class Weather_View04
    {
        private static string[] data01 = new string[100];
        private static Weather_Services03 Weather_Serv03=new Weather_Services03();  
        public Weather_View04()
        {
            load_Weather_View03().Wait();
        }
        private async Task load_Weather_View03()
        {
            data01[0] =
            "1.) Current_Weather_by_city_name\n" +
            "2.) Current_Weatherby_Latitude_Longitude\n" +
            "3.) three_hour_Forecast_5_days\n";

            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    data01[2] = Weather_Serv03.data_array[0];
                    Console.WriteLine(data01[2]);
                    data01[3] = Console.ReadLine();
                    data01[4] = $"{await Weather_Serv03.Current_Weather_by_city_name(data01[3])}";
                    Console.WriteLine(data01[4]);
                    break;
                case 2:                  
                    data01[5] = $"{await Weather_Serv03.Current_Weatherby_Latitude_Longitude()}";
                    Console.WriteLine(data01[5]);
                    break;
                case 3:
                    data01[6] = $"{await Weather_Serv03.three_hour_Forecast_5_days()}";
                    Console.WriteLine(data01[6]);
                    break;


            }
        }
    }
}
