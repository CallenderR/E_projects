using E_APP02.SERVICES.LOCATION_SERVICES.LOCATE_EXTERNAL.LOCATE_DEVICES;
using E_APP02.SERVICES.LOCATION_SERVICES.LOCATE_EXTERNAL.LOCATE_PERSON;

namespace E_APP02.VIEW.LOCATION_VIEW.LOCATION_SELECTION_VIEW
{
    internal class Location_View02
    {
        private static string[] data01 = new string[100];
        private static Locate_Devices01 Device_Serv = new Locate_Devices01();
        public Location_View02()
        {
            load_Location_View02().Wait();


        }
        private async Task load_Location_View02()
        {
            data01[0] =
                        "1.) Device ipaddress\n" +
                        "2.) view_all_devices_location_sqlite\n" +
                        "3.) find_device_location_by_ip_sqlite\n" +
                        "4.) get_device_location_data\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {

                case 1:
                    data01[3] += $"{Device_Serv.get_ipaddress()}\n";
                    Console.WriteLine(data01[3]);
                    break;
                case 2:
                    data01[4] += $"{Device_Serv.view_all_devices_location_sqlite()}\n";
                    Console.WriteLine(data01[4]);
                    break;
                case 3:
                    data01[5] = Locate_Devices01.data_array[0];
                    Console.WriteLine(data01[5]);
                    data01[6] = Console.ReadLine();
                    data01[7] += $"{Device_Serv.find_device_location_by_ip_sqlite(data01[6])}\n";
                    Console.WriteLine(data01[7]);
                    break;
                case 4:
                    data01[4] += $"{Device_Serv.get_device_location_data()}\n";
                    Console.WriteLine(data01[4]);
                    break;

            }
        }
    }
}