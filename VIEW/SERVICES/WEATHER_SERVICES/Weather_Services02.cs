using E_APP02.MODELS.WEATHER_MODEL.WEATHER_GET_MODEL;
using E_APP02.SERVICES.DEVICE_SERVICES;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using Newtonsoft.Json;

//https://rapidapi.com/meteostat/api/meteostat/playground/apiendpoint_5db9ec45-3df4-417b-a481-a037efc8cd9d
namespace E_APP02.SERVICES.WEATHER_SERVICES
{
    internal class Weather_Services02
    {
        private static string[] data01 = new string[100];
        private static List<string> generated = new List<string>();
        private static List<string> time = new List<string>();
        private static List<double> temp = new List<double>();
        private static List<double> dwpt = new List<double>();
        private static List<string> rhum = new List<string>();
        private static List<string> prcp = new List<string>();
        private static List<string?> snow = new List<string?>();
        private static List<string> wdir = new List<string>();
        private static List<double> wspd = new List<double>();
        private static List<string> wpgt = new List<string>();
        private static List<double> pres = new List<double>();
        private static List<int?> tsun = new List<int?>();
        private static List<int> coco = new List<int>();
        private static List<string> id = new List<string>();
        private static List<string> de = new List<string>();
        private static List<string> es = new List<string>();
        private static List<string> en = new List<string>();
        private static List<string> country = new List<string>();
        private static List<string> region = new List<string>();
        private static List<string> national = new List<string>();
        private static List<string> wmo = new List<string>();
        private static List<string> icao = new List<string>();
        private static List<double> latitude = new List<double>();
        private static List<double> longitude = new List<double>();
        private static List<int> elevation = new List<int>();
        private static List<string> timezone = new List<string>();
        private static List<string> start = new List<string>();
        private static List<string> end = new List<string>();
        private static List<string> start01 = new List<string>();
        private static List<string> end01 = new List<string>();
        private static List<string> start02 = new List<string>();
        private static List<string> end02 = new List<string>();
        private static List<int> start03 = new List<int>();
        private static List<int> end03 = new List<int>();
        private static List<int> start04 = new List<int>();
        private static List<int> end04 = new List<int>();
        private static List<double> distance = new List<double>();
        private static List<int> month = new List<int>();
        private static List<double> tavg = new List<double>();
        private static List<double> tmin = new List<double>();
        private static List<double> tmax = new List<double>();
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        private static string[] Headers_ ={ "x-rapidapi-key",READ.api[0].Trim(),
         "x-rapidapi-host", "meteostat.p.rapidapi.com"};

        public async Task<string> meteostat_GET_Hourly_Station_Data(string input03)
        {
            //input date(2020-01-01) formate yyyy-MM-dd
            DateTime dateTime = DateTime.Now;
            string input01 = dateTime.ToString("yyyy-MM-dd");
            string input02 = "America";//countainate America ,
                                       // string input03 = "Dallas";//city
            data01[5] = await weather_data01($"https://meteostat.p.rapidapi.com/stations/hourly?station=10637&start={input01.Trim()}&end={input01.Trim()}&tz={input02.Trim()}%2F{input03.Trim()}");
            return data01[5];
        }

        public async Task<string> meteostat_GET_Daily_Station_Data(string input01)
        {
            DateTime dateTime = DateTime.Now;
            //   string input01 = dateTime.ToString("yyyy-MM-dd");
            data01[6] = await weather_data01($"https://meteostat.p.rapidapi.com/stations/daily?station=10637&start={input01.Trim()}&end={input01.Trim()}");
            return data01[6];
        }
        public async Task<string> meteostat_GET_Station_Climate_Dat()
        {
            string input01 = "1961";
            string input02 = "1990";
            data01[7] = await weather_data04($"https://meteostat.p.rapidapi.com/stations/normals?station=10637&start={input01.Trim()}&end={input02.Trim()}");
            return data01[7];
        }
        public async Task<string> icon_meteostat_GET_Nearby_Stations()
        {

            string lat = Device_Services.get_device_ip().Result.Split(',')[0].Trim();
            string lon = Device_Services.get_device_ip().Result.Split(',')[1].Trim();
            data01[8] = await weather_data03($"https://meteostat.p.rapidapi.com/stations/nearby?lat={lat.Trim()}&lon={lon.Trim()}");
            return data01[8];
        }
        public async Task<string> meteostat_GET_Hourly_Point_Data()
        {
            DateTime dateTime = DateTime.Now;
            string input01 = dateTime.ToString("yyyy-MM-dd");
            string input02 = "America";//region
            string input03 = "Toronto";


            data01[9] = await weather_data04($"https://meteostat.p.rapidapi.com/point/hourly?lat=43.6667&lon=-79.4&alt=113&start={input01.Trim()}&end={input01.Trim()}&tz={input02.Trim()}%2F{input03.Trim()}");
            return data01[9];
        }


        public async Task<string> meteostat_GET_Daily_Point_Data()
        {

            string lat = Device_Services.get_device_ip().Result.Split(',')[0].Trim();
            string lon = Device_Services.get_device_ip().Result.Split(',')[1].Trim();
            DateTime dateTime = DateTime.Now;
            string input01 = dateTime.ToString("yyyy-MM-dd");
            data01[10] = await weather_data04($"https://meteostat.p.rapidapi.com/point/daily?lat={lat.Trim()}&lon={lon.Trim()}&alt=184&start={input01.Trim()}&end={input01.Trim()}");
            return data01[10];
        }


        public async Task<string> meteostat_GET_Monthly_Point_Data()
        {
            string lat = Device_Services.get_device_ip().Result.Split(',')[0].Trim();
            string lon = Device_Services.get_device_ip().Result.Split(',')[1].Trim();
            string start = "2020-01-31";
            string end = "2020-12-31";
            data01[11] = await weather_data04($"https://meteostat.p.rapidapi.com/point/monthly?lat={lat.Trim()}lon={lon.Trim()}&alt=43&start={start.Trim()}&end={end.Trim()}");
            return data01[11];
        }

        public async Task<string> meteostat_GET_Point_Climate_Data()
        {
            string lat = Device_Services.get_device_ip().Result.Split(',')[0].Trim();
            string lon = Device_Services.get_device_ip().Result.Split(',')[1].Trim();
            string start = "2020-01-31";
            string end = "2020-12-31";
            data01[12] = await weather_data04($"https://meteostat.p.rapidapi.com/point/monthly?lat={lat}&lon={lon.Trim()}&alt=43&start={start.Trim()}&end={end.Trim()}");
            return data01[12];
        }




        private async Task<string> weather_data01(string input)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
    {
      { Headers_[0],Headers_[1] },
        { Headers_[2], Headers_[3] },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Weather_Model01.Root results = JsonConvert.DeserializeObject<Weather_Model01.Root>(body);
                try
                {
                    if (results.meta != null)
                    {
                        generated.Add(results.meta.generated);
                    }
                    else
                    {
                        generated.Add(" ");
                    }

                    if (results.data != null)
                    {
                        foreach (var i in results.data)
                        {
                            time.Add(i.time);
                            temp.Add(i.temp);
                            dwpt.Add(i.dwpt);
                            rhum.Add(i.rhum);
                            prcp.Add(i.prcp);
                            snow.Add(i.snow);
                            wdir.Add(i.wdir);
                            wspd.Add(i.wspd);
                            wpgt.Add(i.wpgt);
                            pres.Add(i.pres);
                            tsun.Add(i.tsun);
                            coco.Add(i.coco);
                        }
                    }
                    else
                    {
                        time.Add(" ");
                        temp.Add(0);
                        dwpt.Add(0);
                        rhum.Add(" ");
                        prcp.Add(" ");
                        snow.Add(" ");
                        wdir.Add(" ");
                        wspd.Add(0);
                        wpgt.Add(" ");
                        pres.Add(0);
                        tsun.Add(0);
                        coco.Add(0);
                    }


                }
                catch (Exception ex)
                {
                    data01[0] = $"{ex}\n";
                }


                data01[1] = $"{string.Join(" ", generated)}\n" +
                    $"Time: {string.Join(" ", time)}\n" +
                    $"Temperature: {string.Join(" ", temp)}\n" +
                    $"Dew Point: {string.Join(" ", dwpt)}\n" +
                    $"Relative Humidity: {string.Join(" ", rhum)}\n" +
                    $"Precipitation: {string.Join(" ", prcp)}\n" +
                    $"Snow: {string.Join(" ", snow)}\n" +
                    $"Wind Direction: {string.Join(" ", wdir)}\n" +
                    $"Wind Speed: {string.Join(" ", wspd)}\n" +
                    $"Wind Gust: {string.Join(" ", wpgt)}\n" +
                    $"Pressure: {string.Join(" ", pres)}\n" +
                    $"Total Sunshine: {string.Join(" ", tsun)}\n" +
                    $"Cloud Cover: {string.Join(" ", coco)}\n";
                return data01[1];

            }

        }
        private async Task<string> weather_data02(string input)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
    {
      { Headers_[0],Headers_[1] },
        { Headers_[2], Headers_[3] },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Weather_Model02.Root results = JsonConvert.DeserializeObject<Weather_Model02.Root>(body);
                generated.Add(results.meta.generated);
                id.Add(results.data.id);
                de.Add(results.data.name.de);
                es.Add(results.data.name.es);
                en.Add(results.data.name.en);
                country.Add(results.data.country);
                region.Add(results.data.region);
                national.Add(results.data.identifier.national);
                wmo.Add(results.data.identifier.wmo);
                icao.Add(results.data.identifier.icao);
                latitude.Add(results.data.location.latitude);
                longitude.Add(results.data.location.longitude);
                elevation.Add(results.data.location.elevation);
                timezone.Add(results.data.timezone);
                start.Add(results.data.inventory.model.start);
                end.Add(results.data.inventory.model.end);
                start01.Add(results.data.inventory.hourly.start);
                end01.Add(results.data.inventory.hourly.end);
                start02.Add(results.data.inventory.daily.start);
                end02.Add(results.data.inventory.daily.end);
                start03.Add(results.data.inventory.monthly.start);
                end03.Add(results.data.inventory.monthly.end);
                start04.Add(results.data.inventory.normals.start);
                end04.Add(results.data.inventory.normals.end);

                data01[2] += $"{string.Join(" ", generated)}\n" +
                    $"ID: {string.Join(" ", id)}\n" +
                    $"Name DE: {string.Join(" ", de)}\n" +
                    $"Name ES: {string.Join(" ", es)}\n" +
                    $"Name EN: {string.Join(" ", en)}\n" +
                    $"Country: {string.Join(" ", country)}\n" +
                    $"Region: {string.Join(" ", region)}\n" +
                    $"National Identifier: {string.Join(" ", national)}\n" +
                    $"WMO Identifier: {string.Join(" ", wmo)}\n" +
                    $"ICAO Identifier: {string.Join(" ", icao)}\n" +
                    $"Latitude: {string.Join(" ", latitude)}\n" +
                    $"Longitude: {string.Join(" ", longitude)}\n" +
                    $"Elevation: {string.Join(" ", elevation)}\n" +
                    $"Timezone: {string.Join(" ", timezone)}\n" +
                    $"Model Start: {string.Join(" ", start)}\n" +
                    $"Model End: {string.Join(" ", end)}\n" +
                    $"Hourly Start: {string.Join(" ", start01)}\n" +
                    $"Hourly End: {string.Join(" ", end01)}\n" +
                    $"Daily Start: {string.Join(" ", start02)}\n" +
                    $"Daily End: {string.Join(" ", end02)}\n" +
                    $"Monthly Start: {string.Join(" ", start03)}\n" +
                    $"Monthly End: {string.Join(" ", end03)}\n" +
                    $"Normals Start: {string.Join(" ", start04)}\n" +
                    $"Normals End: {string.Join(" ", end04)}\n";



            }
            return data01[2];
        }
        private async Task<string> weather_data03(string input)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
    {
      { Headers_[0],Headers_[1] },
        { Headers_[2], Headers_[3] },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Weather_Model03.Root results = JsonConvert.DeserializeObject<Weather_Model03.Root>(body);
                if (results.meta.generated != null)
                {
                    generated.Add(results.meta.generated);
                }
                else
                {
                    generated.Add(" ");
                }
                if (results.data != null)
                {
                    foreach (var i in results.data)
                    {
                        id.Add(i.id);
                        en.Add(i.name.en);

                        //  distance.Add();
                    }
                }
                else
                {
                    id.Add(" ");
                    en.Add(" ");
                }

                data01[3] += $"{string.Join(" ", generated)}\n" +
                    $"ID: {string.Join(" ", id)}\n" +
                    $"Name EN: {string.Join(" ", en)}\n" +
                    $"Distance: {string.Join(" ", distance)}\n";
            }
            return data01[3];
        }
        private async Task<string> weather_data04(string input)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
    {
      { Headers_[0],Headers_[1] },
        { Headers_[2], Headers_[3] },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Weather_Model04.Root results = JsonConvert.DeserializeObject<Weather_Model04.Root>(body);

                if (results.meta.generated != null)
                {
                    generated.Add(results.meta.generated);
                }
                else
                {
                    generated.Add(" ");

                }

                if (results.data != null)
                {
                    foreach (var i in results.data)
                    {
                        month.Add(i.month);
                        tavg.Add(conver_celsius_to_fahrenheit(i.tavg));
                        tmin.Add(conver_celsius_to_fahrenheit(i.tmin));
                        tmax.Add(conver_celsius_to_fahrenheit(i.tmax));
                    }
                }
                else
                {
                    tavg.Add(conver_celsius_to_fahrenheit(0));
                    tmin.Add(conver_celsius_to_fahrenheit(0));
                    tmax.Add(conver_celsius_to_fahrenheit(0));

                }


                data01[4] += $"{string.Join(" ", generated)}\n" +
                    $"Month: {string.Join(" ", month)}\n" +
                    $"Average Temperature: {string.Join(" ", tavg)}\n" +
                    $"Minimum Temperature: {string.Join(" ", tmin)}\n" +
                    $"Maximum Temperature: {string.Join(" ", tmax)}\n";
            }
            return data01[4];
        }
        private double conver_celsius_to_fahrenheit(double input)
        {
            double formula = (input * 1.8) + 32;
            return formula;
        }
        private double conver_fahrenheit_to_celsius(double input)
        {
            double formula = (input - 32) / 1.8;
            return formula;
        }
    }
}
