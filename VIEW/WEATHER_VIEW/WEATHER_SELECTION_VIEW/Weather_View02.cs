
using E_APP02.SERVICES.WEATHER_SERVICES;


namespace E_APP02.VIEW.WEATHER_VIEW.WEATHER_SELECTION_VIEW
{
    internal class Weather_View02
    {
        private static string[] data01 = new string[100];
        private static Weather_Services02 Weather_Serv02 = new Weather_Services02();
        public Weather_View02()
        {
            load_Weather_View01().Wait();


        }
        private async Task load_Weather_View01()
        {


            data01[0] =
            "1.) meteostat_GET_Hourly_Station_Data\n" +
            "2.) meteostat_GET_Daily_Station_Data\n" +
            "3.) meteostat_GET_Station_Climate_Dat\n" +
            "4.) icon_meteostat_GET_Nearby_Stations\n" +
            "5.) meteostat_GET_Hourly_Point_Data\n" +
            "6.) meteostat_GET_Daily_Point_Data\n" +
            "7.) meteostat_GET_Monthly_Point_Data\n" +
            "8.) meteostat_GET_Point_Climate_Data\n" +
            "9.) weather_data01\n";


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
                    data01[2] = "search city\n";
                    Console.WriteLine(data01[2]);
                    data01[3] = Console.ReadLine();
                    data01[4] = $"{await Weather_Serv02.meteostat_GET_Daily_Station_Data(data01[3])}";
                    Console.WriteLine(data01[4]);
                    break;

                case 3:
                    data01[5] = $"{await Weather_Serv02.meteostat_GET_Station_Climate_Dat()}";
                    Console.WriteLine(data01[5]);
                    break;
                case 4:
                    data01[6] = $"{await Weather_Serv02.icon_meteostat_GET_Nearby_Stations()}";
                    Console.WriteLine(data01[6]);
                    break;
                case 5:

                    data01[7] = $"{await Weather_Serv02.meteostat_GET_Hourly_Point_Data()}";
                    Console.WriteLine(data01[7]);
                    break;
                case 6:

                    data01[8] = $"{await Weather_Serv02.meteostat_GET_Daily_Point_Data()}";
                    Console.WriteLine(data01[8]);
                    break;
                case 7:

                    data01[9] = $"{await Weather_Serv02.meteostat_GET_Monthly_Point_Data()}";
                    Console.WriteLine(data01[9]);
                    break;
                case 8:

                    data01[10] = $"{await Weather_Serv02.meteostat_GET_Point_Climate_Data()}";
                    Console.WriteLine(data01[10]);
                    break;
            }
        }
    }
}