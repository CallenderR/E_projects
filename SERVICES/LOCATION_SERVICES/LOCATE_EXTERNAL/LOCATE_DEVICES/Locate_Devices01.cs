using E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_MANAGER;
using E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_DEVICES;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
namespace E_APP02.SERVICES.LOCATION_SERVICES.LOCATE_EXTERNAL.LOCATE_DEVICES
{
    internal class Locate_Devices01
    {

        private  string[] data01 = new string[100];
        private static Sqlite_Services01 Sqlite_Serv01=new Sqlite_Services01();
        public static string[] data_array = {"enter ip address" };
        public Locate_Devices01()
        {
            Sqlite_Manager01.InitializeAsync().Wait();
            load_Locate_Devices01().Wait();
        }
        private enum assign_data
        {
            get_ipaddress = 0,
            get_device_location_data = 2,
            find_device_location_by_ip_sqlite = 3,
            get_device_lat_and_lon_data = 4,
            view_all_devices_location_sqlite= 5,    
        }
        private async Task load_Locate_Devices01()
        {
            string ip = ""; // or leave empty for your own IP
            string url = string.IsNullOrEmpty(ip)
                ? "http://ip-api.com/json/"
                : $"http://ip-api.com/json/{ip}";

            using HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);

            using JsonDocument doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            data01[0] =
            $"IP: {root.GetProperty("query")}\n" +
            $"Country: {root.GetProperty("country")}\n" +
            $"Region: {root.GetProperty("regionName")}\n" +
            $"City: {root.GetProperty("city")}\n" +
            $"ISP: {root.GetProperty("isp")}\n" +
            $"Lat: {root.GetProperty("lat")}\n" +
            $"Lon: {root.GetProperty("lon")}\n";

            data01[(int)assign_data.get_device_location_data] += await Sqlite_Serv01.insert_device_table(
                             $"{root.GetProperty("query")}", 
                             $"{root.GetProperty("country")}",
                             $"{root.GetProperty("regionName")}", 
                             $"{root.GetProperty("city")}",
                             $"{root.GetProperty("isp")}", 
                             $"{root.GetProperty("lat")}",
                             $"{root.GetProperty("lon")}");
            data01[(int)assign_data.get_device_lat_and_lon_data] += $"{root.GetProperty("lat")}\n"+
                         $"{root.GetProperty("lon")}\n";
        }
        public string get_ipaddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var a in host.AddressList)
            {
                if (a.AddressFamily == AddressFamily.InterNetwork) // IPv4
                {
                    data01[(int)assign_data.get_ipaddress] = $"{a}\n";

                }
                else
                {
                    data01[(int)assign_data.get_ipaddress] = "cant find";
                }
            }

            return data01[(int)assign_data.get_ipaddress];
        }
       public string get_device_location_data()
        {
            return data01[(int)assign_data.get_device_location_data];
        }
        public string get_device_lat_and_lon_data()
        {
            return data01[(int)assign_data.get_device_lat_and_lon_data];
        }
        public string view_all_devices_location_sqlite()
        {
            data01[(int)assign_data.view_all_devices_location_sqlite] = Sqlite_Serv01.view_device_table().Result;
            return data01[(int)assign_data.view_all_devices_location_sqlite];
        }
        public string find_device_location_by_ip_sqlite(string ip_address)
        {
            data01[(int)assign_data.find_device_location_by_ip_sqlite] = Sqlite_Serv01.find_device_by_ip(ip_address).Result;
            return data01[(int)assign_data.find_device_location_by_ip_sqlite];
        }
    }
}
