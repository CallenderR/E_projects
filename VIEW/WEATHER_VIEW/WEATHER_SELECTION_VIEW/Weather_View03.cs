using E_APP02.SERVICES.WEATHER_SERVICES;


namespace E_APP02.VIEW.WEATHER_VIEW.WEATHER_SELECTION_VIEW
{
    internal class Weather_View03
    {
        private static string[] data01 = new string[100];
        private static Weather_Services02 Weather_Serv02 = new Weather_Services02();
        public Weather_View03()
        {
            load_Weather_View02().Wait();


        }
        private async Task load_Weather_View02()
        {


            data01[0] =
            "1.) meteostat_GET_Hourly_Station_Data\n" +
            "2.) Current_Weatherby_Latitude_Longitude\n" +
            "3.) three_hour_Forecast_5_days\n";


            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    data01[2] = "search city\n";
                    Console.WriteLine(data01[2]);
                    data01[3] = Console.ReadLine();
                    data01[4] = $"{await Weather_Serv02.meteostat_GET_Hourly_Station_Data(data01[3])}";
                    Console.WriteLine(data01[4]);
                    break;
                case 2:
                    data01[5] = $"{await Weather_Serv02.meteostat_GET_Station_Climate_Dat()}";
                    Console.WriteLine(data01[5]);
                    break;

                case 3:
                    data01[6] = $"{await Weather_Serv02.icon_meteostat_GET_Nearby_Stations()}";
                    Console.WriteLine(data01[6]);
                    break;

            }
        }
    }
}
