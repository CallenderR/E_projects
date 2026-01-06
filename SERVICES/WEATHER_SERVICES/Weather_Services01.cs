using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
//https://home.openweathermap.org/subscriptions
namespace E_APP02.SERVICES.WEATHER_SERVICES
{
    internal class Weather_Services01
    {
        private static HttpClient Client = new HttpClient();
        private  string[] data01 = new string[100];
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        public  string[] data_array = {"City Name"};

        public async Task<string> weather_data01()//needs payment
        {
            //   string lat = Device_Services.get_device_ip().Result.Split(',')[0].Trim();
            //   string lon = Device_Services.get_device_ip().Result.Split(',')[1].Trim();

            string url = $"https://api.openweathermap.org/data/2.5/weather?lat=44.34&lon=10.99&appid={READ.api[5].Trim()}";
            using var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            data01[0] = body;
            data01[0] = "NEEDS PAYMENT";
            return data01[0];
        }

    }
}
