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

            data01[1]+= await Sqlite_Serv01.insert_device_table(
                             $"{root.GetProperty("query")}", 
                             $"{root.GetProperty("country")}",
                             $"{root.GetProperty("regionName")}", 
                             $"{root.GetProperty("city")}",
                             $"{root.GetProperty("isp")}", 
                             $"{root.GetProperty("lat")}",
                             $"{root.GetProperty("lon")}");
         
        }
        public string get_ipaddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var a in host.AddressList)
            {
                if (a.AddressFamily == AddressFamily.InterNetwork) // IPv4
                {
                    data01[2] = $"{a}\n";

                }
                else
                {
                    data01[2] = "cant find";
                }
            }

            return data01[2];
        }
       public string get_device_location_data()
        {
            return data01[0];
        }
        public Locate_Devices01()
        {
            Sqlite_Manager01.InitializeAsync().Wait();
            load_Locate_Devices01().Wait();
        }
        public string view_all_devices_location_sqlite()
        {
            data01[3] = Sqlite_Serv01.view_device_table().Result;
            return data01[3];
        }
        public string find_device_location_by_ip_sqlite(string ip_address)
        {
            data01[4] = Sqlite_Serv01.find_device_by_ip(ip_address).Result;
            return data01[4];
        }
    }
}
