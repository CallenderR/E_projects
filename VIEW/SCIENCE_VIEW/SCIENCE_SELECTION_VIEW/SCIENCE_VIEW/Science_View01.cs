
using E_APP02.SERVICES.SCIENCE_SERVICES.NASA_SERVICES;


namespace E_APP02.VIEW.SCIENCE_VIEW.SCIENCE_SELECTION_VIEW.SCIENCE_VIEW
{
    internal class Science_View01
    {
        private static string[] data01 = new string[100];
        private static Nasa_Services01 Nasa_Serv01 = new Nasa_Services01();
        public Science_View01()
        {
            load_Science_View01().Wait();


        }
        private async Task load_Science_View01()
        {
            data01[0] =

"1.) APOD\n" +
"2.)Asteroids_NeoWs\n" +
"3.)DONKI_Coronal_Mass_Ejection_CME\n" +
"4.)DONKI_Coronal_Mass_Ejection_CME_Analysis\n" +
"5.)DONKI_Geomagnetic_Storm_GST\n" +
"6.)DONKI_Interplanetary_Shock_IPS\n" +
"7.)DONKI_Solar_Flare_FLR\n" +
"8.)DONKI_Solar_Energetic_Particle_SEP\n" +
"9.)DONKI_Magnetopause_Crossing_MPC\n" +
"10.)DONKI_Radiation_Belt_Enhancement_RBE\n" +
"11.)DONKI_Hight_Speed_Stream_HSS\n" +
"12.)DONKI_WSA_EnlilSimulation\n" +
"13.)DONKI_Notifications\n" +
"14.)EPIC01\n" +
"15.)EPIC02\n" +
"16.)EPIC03\n" +
"17.)EPIC04\n" +
"18.)InSight_Mars_Weather_Service_API\n";

            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:

                    data01[1] = $"{await Nasa_Serv01.APOD()}";
                    Console.WriteLine(data01[1]);
                    break;
                case 2:

                    data01[2] = $"{await Nasa_Serv01.APOD()}";
                    Console.WriteLine(data01[2]);
                    break;
                case 4:

                    data01[3] = $"{await Nasa_Serv01.Asteroids_NeoWs()}";
                    Console.WriteLine(data01[3]);
                    break;
                case 5:

                    data01[4] = $"{await Nasa_Serv01.DONKI_Coronal_Mass_Ejection_CME()}";
                    Console.WriteLine(data01[4]);
                    break;
                case 6:

                    data01[5] = $"{await Nasa_Serv01.DONKI_Coronal_Mass_Ejection_CME_Analysis()}";
                    Console.WriteLine(data01[5]);
                    break;
                case 7:

                    data01[6] = $"{await Nasa_Serv01.DONKI_Geomagnetic_Storm_GST()}";
                    Console.WriteLine(data01[6]);
                    break;
                case 8:

                    data01[7] = $"{await Nasa_Serv01.DONKI_Interplanetary_Shock_IPS()}";
                    Console.WriteLine(data01[7]);
                    break;
                case 9:

                    data01[8] = $"{await Nasa_Serv01.DONKI_Solar_Flare_FLR()}";
                    Console.WriteLine(data01[8]);
                    break;
                case 10:

                    data01[9] = $"{await Nasa_Serv01.DONKI_Solar_Energetic_Particle_SEP()}";
                    Console.WriteLine(data01[9]);
                    break;
                case 11:

                    data01[10] = $"{await Nasa_Serv01.DONKI_Magnetopause_Crossing_MPC()}";
                    Console.WriteLine(data01[11]);
                    break;
                case 12:

                    data01[11] = $"{await Nasa_Serv01.DONKI_Radiation_Belt_Enhancement_RBE()}";
                    Console.WriteLine(data01[11]);
                    break;
                case 13:

                    data01[12] = $"{await Nasa_Serv01.DONKI_Hight_Speed_Stream_HSS()}";
                    Console.WriteLine(data01[12]);
                    break;
                case 14:

                    data01[13] = $"{await Nasa_Serv01.DONKI_WSA_EnlilSimulation()}";
                    Console.WriteLine(data01[13]);
                    break;
                case 15:

                    data01[14] = $"{await Nasa_Serv01.DONKI_Notifications()}";
                    Console.WriteLine(data01[14]);
                    break;
                case 16:

                    data01[15] = $"{await Nasa_Serv01.EPIC01()}";
                    Console.WriteLine(data01[15]);
                    break;
                case 17:

                    data01[16] = $"{await Nasa_Serv01.EPIC02()}";
                    Console.WriteLine(data01[16]);
                    break;
                case 18:

                    data01[17] = $"{await Nasa_Serv01.EPIC03()}";
                    Console.WriteLine(data01[17]);
                    break;
                case 19:

                    data01[18] = $"{await Nasa_Serv01.EPIC04()}";
                    Console.WriteLine(data01[18]);
                    break;
                case 20:

                    data01[19] = $"{await Nasa_Serv01.InSight_Mars_Weather_Service_API()}";
                    Console.WriteLine(data01[19]);
                    break;
            }
        }
    }
}