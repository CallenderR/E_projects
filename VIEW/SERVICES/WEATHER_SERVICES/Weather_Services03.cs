
using E_APP02.MODELS.WEATHER_MODEL.WEATHER_GET_MODEL;
using E_APP02.MODELS.WEATHER_MODEL.WEATHER_SET_MODEL;
using E_APP02.SERVICES.DEVICE_SERVICES;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using Newtonsoft.Json;


//https://rapidapi.com/worldapi/api/open-weather13/playground/apiendpoint_408f5596-3013-482b-bd47-b4487d4e989e


namespace E_APP02.SERVICES.WEATHER_SERVICES
{
    internal class Weather_Services03
    {

        private static string[] data01 = new string[100];

        private static List<double> lon = new List<double>();
        private static List<double> lat = new List<double>();
        private static List<int> id = new List<int>();
        private static List<string> main = new List<string>();
        private static List<string> description = new List<string>();
        private static List<string> icon = new List<string>();
        private static List<string> @base = new List<string>();
        private static List<double> temp = new List<double>();
        private static List<double> feels_like = new List<double>();
        private static List<double> temp_min = new List<double>();
        private static List<double> temp_max = new List<double>();
        private static List<int> pressure = new List<int>();
        private static List<int> humidity = new List<int>();
        private static List<int> sea_level = new List<int>();
        private static List<int> grnd_level = new List<int>();
        private static List<int> visibility = new List<int>();
        private static List<double> speed = new List<double>();
        private static List<int> deg = new List<int>();
        private static List<int> all = new List<int>();
        private static List<int> dt = new List<int>();
        private static List<int> type = new List<int>();
        private static List<int> id01 = new List<int>();
        private static List<string> country = new List<string>();
        private static List<int> sunrise = new List<int>();
        private static List<int> sunset = new List<int>();
        private static List<int> timezone = new List<int>();
        private static List<int> id02 = new List<int>();
        private static List<string> name = new List<string>();
        private static List<int> cod = new List<int>();
        public List<Weather_Set_Model01> collectiondata01 = new List<Weather_Set_Model01>();
        public List<Weather_Set_Model02> collectiondata02 = new List<Weather_Set_Model02>();
        private static HttpClient client = new HttpClient();
        private static List<string> cod01 = new List<string>();
        private static List<int> message = new List<int>();
        private static List<int> cnt = new List<int>();
        private static List<double> temp_kf = new List<double>();
        private static List<double> gust = new List<double>();
        private static List<double> pop = new List<double>();
        private static List<string> pod = new List<string>();
        private static List<string> dt_txt = new List<string>();
        private static List<double?> _3h = new List<double?>();
        private static List<int> population = new List<int>();
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        private static string[] Headers_ ={ "x-rapidapi-key",READ.api[0].Trim(),
         "x-rapidapi-host", "open-weather13.p.rapidapi.com" };
        public string[] data_array = {"City Name"};

        public async Task<string> Current_Weather_by_city_name(string input)
        {

            data01[2] = await weather_data01($"https://open-weather13.p.rapidapi.com/city?city={input}&lang=EN");
            return data01[2];
        }
        public async Task<string> Current_Weatherby_Latitude_Longitude()
        {
            string info = await Device_Services.get_device_ip();
            string lat = info.Split(',')[0].Trim();
            string lon = info.Split(',')[1].Trim();
            data01[3] = await weather_data01($"https://open-weather13.p.rapidapi.com/latlon?latitude={lat}&longitude={lon}&lang=EN");
            return data01[3];
        }
        public async Task<string> three_hour_Forecast_5_days()//needs work
        {
            string info = await Device_Services.get_device_ip();
            string lat = info.Split(',')[0].Trim();
            string lon = info.Split(',')[1].Trim();
            data01[4] = await weather_data02($"https://open-weather13.p.rapidapi.com/fivedaysforcast?latitude={lat}&longitude={lon}&lang=EN");
            return data01[4];
        }
        private async Task<string> weather_data01(string input)
        {
            try
            {
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
                    Weather_Model05.Root results = JsonConvert.DeserializeObject<Weather_Model05.Root>(body);
                    if (results != null)
                    {
                        lon.Add(results.coord.lon);
                        lat.Add(results.coord.lat);
                        if (results.weather != null)
                        {
                            foreach (var a in results.weather)
                            {
                                id.Add(a.id);
                                main.Add(a.main);
                                description.Add(a.description);
                                icon.Add(a.icon);
                            }
                        }
                        else
                        {
                            id.Add(0);
                            main.Add(" ");
                            description.Add(" ");
                            icon.Add(" ");
                        }

                        @base.Add(results.@base);
                        temp.Add(results.main.temp);
                        feels_like.Add(results.main.feels_like);
                        temp_min.Add(results.main.temp_min);
                        temp_max.Add(results.main.temp_max);
                        pressure.Add(results.main.pressure);
                        humidity.Add(results.main.humidity);
                        sea_level.Add(results.main.sea_level);
                        grnd_level.Add(results.main.grnd_level);
                        visibility.Add(results.visibility);
                        speed.Add(results.visibility);
                        deg.Add(results.visibility);
                        all.Add(results.clouds.all);
                        dt.Add(results.dt);
                        type.Add(results.sys.type);
                        id01.Add(results.sys.id);
                        country.Add(results.sys.country);
                        sunrise.Add(results.sys.sunrise);
                        sunset.Add(results.sys.sunset);
                        timezone.Add(results.timezone);
                        id02.Add(results.id);
                        name.Add(results.name);
                        cod.Add(results.cod);
                    }
                    else
                    {
                        lon.Add(0);
                        lat.Add(0);
                        @base.Add(" ");
                        temp.Add(0);
                        feels_like.Add(0);
                        temp_min.Add(0);
                        temp_max.Add(0);
                        pressure.Add(0);
                        humidity.Add(0);
                        sea_level.Add(0);
                        grnd_level.Add(0);
                        visibility.Add(0);
                        speed.Add(0);
                        deg.Add(0);
                        all.Add(0);
                        dt.Add(0);
                        type.Add(0);
                        id01.Add(0);
                        country.Add(" ");
                        sunrise.Add(0);
                        sunset.Add(0);
                        timezone.Add(0);
                        id02.Add(0);
                        name.Add(" ");
                        cod.Add(0);
                    }


                    var collection_set = new Weather_Set_Model01
                    {

                        Lon = lon.Count > 0 ? lon[0] : 0,
                        Lat = lat.Count > 0 ? lat[0] : 0,
                        Id = id.Count > 0 ? id[0] : 0,
                        Main = main.Count > 0 ? main[0] : null,
                        Description = description.Count > 0 ? description[0] : null,
                        Icon = icon.Count > 0 ? icon[0] : null,
                        Base = @base.Count > 0 ? @base[0] : null,
                        Temp = temp.Count > 0 ? temp[0] : 0,
                        Feels_like = feels_like.Count > 0 ? feels_like[0] : 0,
                        Temp_min = temp_min.Count > 0 ? temp_min[0] : 0,
                        Temp_max = temp_max.Count > 0 ? temp_max[0] : 0,
                        Pressure = pressure.Count > 0 ? pressure[0] : 0,
                        Humidity = humidity.Count > 0 ? humidity[0] : 0,
                        Sea_level = sea_level.Count > 0 ? sea_level[0] : 0,
                        Grnd_level = grnd_level.Count > 0 ? grnd_level[0] : 0,
                        Visibility = visibility.Count > 0 ? visibility[0] : 0,
                        Speed = speed.Count > 0 ? speed[0] : 0,
                        Deg = deg.Count > 0 ? deg[0] : 0,
                        All = all.Count > 0 ? all[0] : 0,
                        Dt = dt.Count > 0 ? dt[0] : 0,
                        Type = type.Count > 0 ? type[0] : 0,
                        Id01 = id01.Count > 0 ? id01[0] : 0,
                        Country = country.Count > 0 ? country[0] : null,
                        Sunrise = sunrise.Count > 0 ? sunrise[0] : 0,
                        Sunset = sunset.Count > 0 ? sunset[0] : 0,
                        Timezone = timezone.Count > 0 ? timezone[0] : 0,
                        Id02 = id02.Count > 0 ? id02[0] : 0,
                        Name = name.Count > 0 ? name[0] : null,
                        Cod = cod.Count > 0 ? cod[0] : 0,
                    }
                ;
                    collectiondata01.Add(collection_set);
                    data01[0] =
                  $"{string.Join(" ", lon)}\n" +
                        $"{string.Join(" ", lat)}\n" +
                        $"{string.Join(" ", id)}\n" +
                        $"{string.Join(" ", main)}\n" +
                        $"{string.Join(" ", description)}\n" +
                        $"{string.Join(" ", icon)}\n" +
                        $"{string.Join(" ", @base)}\n" +
                        $"{string.Join(" ", temp)}\n" +
                        $"{string.Join(" ", feels_like)}\n" +
                        $"{string.Join(" ", temp_min)}\n" +
                        $"{string.Join(" ", temp_max)}\n" +
                        $"{string.Join(" ", pressure)}\n" +
                        $"{string.Join(" ", humidity)}\n" +
                        $"{string.Join(" ", sea_level)}\n" +
                        $"{string.Join(" ", grnd_level)}\n" +
                        $"{string.Join(" ", visibility)}\n" +
                        $"{string.Join(" ", speed)}\n" +
                        $"{string.Join(" ", deg)}\n" +
                        $"{string.Join(" ", all)}\n" +
                        $"{string.Join(" ", dt)}\n" +
                        $"{string.Join(" ", type)}\n" +
                        $"{string.Join(" ", id01)}\n" +
                        $"{string.Join(" ", country)}\n" +
                        $"{string.Join(" ", sunrise)}\n" +
                        $"{string.Join(" ", sunset)}\n" +
                        $"{string.Join(" ", timezone)}\n" +
                        $"{string.Join(" ", id02)}\n" +
                        $"{string.Join(" ", name)}\n" +
                        $"{string.Join(" ", cod)}\n";

                }
            }
            catch (Exception ex)
            {
                data01[0] = ex.ToString();
            }

            return data01[0];
        }
        private async Task<string> weather_data02(string input)
        {
            try
            {
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
                    Weather_Model06.Root results = JsonConvert.DeserializeObject<Weather_Model06.Root>(body);
                    if (results != null)
                    {
                        cod01.Add(results.cod);
                        message.Add(results.message);
                        cnt.Add(results.cnt);
                        if (results.list != null)
                        {
                            foreach (var a in results.list)
                            {
                                dt.Add(a.dt);
                                temp.Add(a.main.temp);
                                feels_like.Add(a.main.feels_like);
                                temp_min.Add(a.main.temp_min);
                                temp_max.Add(a.main.temp_max);
                                pressure.Add(a.main.pressure);
                                sea_level.Add(a.main.sea_level);
                                grnd_level.Add(a.main.grnd_level);
                                humidity.Add(a.main.humidity);
                                temp_kf.Add(a.main.temp_kf);
                                if (a.weather != null)
                                {
                                    foreach (var b in a.weather)
                                    {
                                        id.Add(b.id);
                                        main.Add(b.main);
                                        description.Add(b.description);
                                        icon.Add(b.icon);
                                    }
                                }
                                else
                                {
                                    id.Add(0);
                                    main.Add(" ");
                                    description.Add(" ");
                                    icon.Add(" ");

                                }

                                all.Add(a.clouds.all);
                                speed.Add(a.wind.speed);
                                deg.Add(a.wind.deg);
                                gust.Add(a.wind.gust);
                                visibility.Add(a.visibility);
                                pop.Add(a.pop);
                                pod.Add(a.sys.pod);
                                dt_txt.Add(a.dt_txt);
                                _3h.Add(a.rain?._3h ?? 0);
                            }
                        }
                        else
                        {
                            dt.Add(0);
                            temp.Add(0);
                            feels_like.Add(0);
                            temp_min.Add(0);
                            temp_max.Add(0);
                            pressure.Add(0);
                            sea_level.Add(0);
                            grnd_level.Add(0);
                            humidity.Add(0);
                            temp_kf.Add(0);
                            all.Add(0);
                            speed.Add(0);
                            deg.Add(0);
                            gust.Add(0);
                            visibility.Add(0);
                            pop.Add(0);
                            pod.Add(" ");
                            dt_txt.Add(" ");
                            _3h.Add(0);

                        }




                        id.Add(results.city.id);
                        name.Add(results.city.name);
                        country.Add(results.city.country);
                        population.Add(results.city.population);
                        timezone.Add(results.city.timezone);
                        sunrise.Add(results.city.sunrise);
                        sunset.Add(results.city.sunset);

                    }
                    else
                    {
                        cod01.Add("");
                        message.Add(0);
                        cnt.Add(0);
                        id.Add(0);
                        name.Add("");
                        country.Add(" ");
                        population.Add(0);
                        timezone.Add(0);
                        sunrise.Add(0);
                        sunset.Add(0);

                    }


                    var collection_set = new Weather_Set_Model02
                    {


                        Cod01 = cod01.Count > 0 ? cod01[0] : null,
                        Message = message.Count > 0 ? message[0] : 0,
                        Cnt = cnt.Count > 0 ? cnt[0] : 0,
                        Dt = dt.Count > 0 ? dt[0] : 0,
                        Temp = temp.Count > 0 ? temp[0] : 0,
                        Feels_like = feels_like.Count > 0 ? feels_like[0] : 0,
                        Temp_min = temp_min.Count > 0 ? temp_min[0] : 0,
                        Temp_max = temp_max.Count > 0 ? temp_max[0] : 0,
                        Pressure = pressure.Count > 0 ? pressure[0] : 0,
                        Sea_level = sea_level.Count > 0 ? sea_level[0] : 0,
                        Grnd_level = grnd_level.Count > 0 ? grnd_level[0] : 0,
                        Humidity = humidity.Count > 0 ? humidity[0] : 0,
                        Temp_kf = temp_kf.Count > 0 ? temp_kf[0] : 0,
                        Id = id.Count > 0 ? id[0] : 0,
                        Main = main.Count > 0 ? main[0] : null,
                        Description = description.Count > 0 ? description[0] : null,
                        Icon = icon.Count > 0 ? icon[0] : null,
                        All = all.Count > 0 ? all[0] : 0,
                        Speed = speed.Count > 0 ? speed[0] : 0,
                        Deg = deg.Count > 0 ? deg[0] : 0,
                        Gust = gust.Count > 0 ? gust[0] : 0,
                        Visibility = visibility.Count > 0 ? visibility[0] : 0,
                        Pop = pop.Count > 0 ? pop[0] : 0,
                        Pod = pod.Count > 0 ? pod[0] : null,
                        Dt_txt = dt_txt.Count > 0 ? dt_txt[0] : null,
                        _3h = _3h.Count > 0 ? _3h[0] : 0,
                        Id01 = id.Count > 0 ? id[0] : 0,
                        Name = name.Count > 0 ? name[0] : null,
                        Country = country.Count > 0 ? country[0] : null,
                        Population = population.Count > 0 ? population[0] : 0,
                        Timezone = timezone.Count > 0 ? timezone[0] : 0,
                        Sunrise = sunrise.Count > 0 ? sunrise[0] : 0,
                        Sunset = sunset.Count > 0 ? sunset[0] : 0,

                    };
                    collectiondata02.Add(collection_set);
                    data01[1] = $"{string.Join(" ", cod01)}\n" +
                                     $"{string.Join(" ", message)}\n" +
                                     $"{string.Join(" ", cnt)}\n" +
                                      $"{string.Join(" ", dt)}\n" +
                     $"{string.Join(" ", temp)}\n" +
                      $"{string.Join(" ", feels_like)}\n" +
                      $"{string.Join(" ", temp_min)}\n" +
                       $"{string.Join(" ", temp_max)}\n" +
                       $"{string.Join(" ", pressure)}\n" +
                    $"{string.Join(" ", sea_level)}\n" +
                     $"{string.Join(" ", grnd_level)}\n" +
                     $"{string.Join(" ", humidity)}\n" +
                     $"{string.Join(" ", temp_kf)}\n" +
                        $"{string.Join(" ", id)}\n" +
                       $"{string.Join(" ", main)}\n" +
                       $"{string.Join(" ", description)}\n" +
                      $"{string.Join(" ", icon)}\n" +
                      $"{string.Join(" ", all)}\n" +
                      $"{string.Join(" ", speed)}\n" +
                      $"{string.Join(" ", deg)}\n" +
                      $"{string.Join(" ", gust)}\n" +
                      $"{string.Join(" ", visibility)}\n" +
                      $"{string.Join(" ", pop)}\n" +
                     $"{string.Join(" ", pod)}\n" +
                     $"{string.Join(" ", dt_txt)}\n" +
                     $"{string.Join(" ", _3h)}\n" +
                 $"{string.Join(" ", id)}\n" +
                $"{string.Join(" ", name)}\n" +
                  $"{string.Join(" ", country)}\n" +
                 $"{string.Join(" ", population)}\n" +
                 $"{string.Join(" ", timezone)}\n" +
                 $"{string.Join(" ", sunrise)}\n" +
                  $"{string.Join(" ", sunset)}\n";

                }
            }
            catch (Exception ex)
            {
                data01[1] = ex.ToString();
            }
            return data01[1];

        }
    }

}
