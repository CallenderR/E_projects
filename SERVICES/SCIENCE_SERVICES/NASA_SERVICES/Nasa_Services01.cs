using E_APP02.MODELS.SCIENCE_MODEL.NASA_MODEL.NASA_GET_MODEL;
using E_APP02.MODELS.SCIENCE_MODEL.NASA_MODEL.NASA_GET_MODEL;
using E_APP02.MODELS.SCIENCE_MODEL.NASA_MODEL.NASA_SET_MODEL;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using Newtonsoft.Json;




namespace E_APP02.SERVICES.SCIENCE_SERVICES.NASA_SERVICES
{
    internal class Nasa_Services01
    {
        private  string[] data01 = new string[100];
        private static HttpClient client = new HttpClient();
        private  List<string> copyright = new List<string>();
        private  List<string> date = new List<string>();
        private  List<string> explanation = new List<string>();
        private  List<string> hdurl = new List<string>();
        private  List<string> media_type = new List<string>();
        private  List<string> service_version = new List<string>();
        private  List<string> title = new List<string>();
        private  List<string> url = new List<string>();


        //link
        private  List<string> next = new List<string>();
        private  List<string> previous = new List<string>();
        private  List<string> self = new List<string>();
        private  List<int> element_count = new List<int>();
        private  List<string> next01 = new List<string>();
        private  List<string> previous01 = new List<string>();
        private  List<string> self01 = new List<string>();
        private  List<string> id = new List<string>();
        private  List<string> neo_reference_id = new List<string>();
        private  List<string> name = new List<string>();
        private  List<string> nasa_jpl_url = new List<string>();
        private  List<double> absolute_magnitude_h = new List<double>();
        private  List<double> estimated_diameter_min = new List<double>();
        private  List<double> estimated_diameter_max = new List<double>();
        private  List<double> estimated_diameter_min01 = new List<double>();
        private  List<double> estimated_diameter_max01 = new List<double>();
        private  List<double> estimated_diameter_min02 = new List<double>();
        private  List<double> estimated_diameter_max02 = new List<double>();
        private  List<double> estimated_diameter_min03 = new List<double>();
        private  List<double> estimated_diameter_max03 = new List<double>();
        private  List<bool> is_potentially_hazardous_asteroid = new List<bool>();
        private  List<string> close_approach_date = new List<string>();
        private  List<string> close_approach_date_full = new List<string>();
        private  List<object> epoch_date_close_approach = new List<object>();
        private  List<string> kilometers_per_second = new List<string>();
        private  List<string> kilometers_per_hour = new List<string>();

        private  List<string> miles_per_hour = new List<string>();
        private  List<string> astronomical = new List<string>();
        private  List<string> lunar = new List<string>();
        private  List<string> kilometers = new List<string>();
        private  List<string> miles = new List<string>();
        private  List<string> orbiting_body = new List<string>();
        private  List<bool> is_sentry_object = new List<bool>();



        private  List<string> activityID = new List<string>();
        private  List<string> catalog = new List<string>();
        private  List<string> startTime = new List<string>();
        private  List<string> displayName = new List<string>();
        private  List<string> sourceLocation = new List<string>();
        private  List<object> activeRegionNum = new List<object>();
        private  List<string> note = new List<string>();
        private  List<string> submissionTime = new List<string>();
        private  List<int> versionId = new List<int>();
        private  List<string> link = new List<string>();
        private  List<bool?> isMostAccurate = new List<bool?>();
        private  List<string> time21_5 = new List<string>();
        private  List<double> latitude = new List<double>();
        private  List<double> longitude = new List<double>();
        private  List<double> halfAngle = new List<double>();
        private  List<double> speed = new List<double>();
        private  List<string> type = new List<string>();
        private  List<string> featureCode = new List<string>();
        private  List<object> imageType = new List<object>();
        private  List<string> measurementTechnique = new List<string>();
        private  List<string> note01 = new List<string>();
        private  List<int> levelOfData = new List<int>();
        private  List<object> tilt = new List<object>();
        private  List<object> minorHalfWidth = new List<object>();
        private  List<object> speedMeasuredAtHeight = new List<object>();
        private  List<string> submissionTime01 = new List<string>();
        private  List<string> link01 = new List<string>();
        private  List<string> modelCompletionTime = new List<string>();
        private  List<double> au = new List<double>();
        private  List<object> estimatedShockArrivalTime = new List<object>();
        private  List<object> estimatedDuration = new List<object>();
        private  List<object> rmin_re = new List<object>();
        private  List<object> kp_18 = new List<object>();
        private  List<object> kp_90 = new List<object>();
        private  List<object> kp_135 = new List<object>();
        private  List<object> kp_180 = new List<object>();
        private  List<bool?> isEarthGB = new List<bool?>();
        private  List<bool?> isEarthMinorImpact = new List<bool?>();
        private  List<string> link02 = new List<string>();
        private  List<bool?> isGlancingBlow = new List<bool?>();
        private  List<bool?> isMinorImpact = new List<bool?>();
        private  List<string> location = new List<string>();
        private  List<string> arrivalTime = new List<string>();
        private  List<string> cmeIDs = new List<string>();
        private  List<object> linkedEvents = new List<object>();
        private  List<string> messageID = new List<string>();
        private  List<string> messageIssueTime = new List<string>();
        private  List<string> messageURL = new List<string>();
        private  List<string> gstID = new List<string>();
        private  List<string> observedTime = new List<string>();
        private  List<double> kpIndex = new List<double>();
        private  List<string> source = new List<string>();
        private  List<string> flrID = new List<string>();
        private  List<string> beginTime = new List<string>();
        private  List<string> peakTime = new List<string>();
        private  List<string> endTime = new List<string>();
        private  List<string> classType = new List<string>();
        private  List<object> sentNotifications = new List<object>();
        private  List<string> sepID = new List<string>();
        private  List<string> eventTime = new List<string>();
        private  List<string> mpcID = new List<string>();
        private  List<string> rbeID = new List<string>();




        private static List<string> identifier = new List<string>();
        private static List<string> caption = new List<string>();
        private static List<string> image = new List<string>();
        private static List<string> version = new List<string>();
        private static List<double> lat = new List<double>();
        private static List<double> lon = new List<double>();
        private static List<double> x = new List<double>();
        private static List<double> y = new List<double>();
        private static List<double> z = new List<double>();
        private static List<double> x1 = new List<double>();
        private static List<double> y1 = new List<double>();
        private static List<double> z1 = new List<double>();
        private static List<double> x2 = new List<double>();
        private static List<double> y2 = new List<double>();
        private static List<double> z2 = new List<double>();
        private static List<double> q0 = new List<double>();
        private static List<double> q1 = new List<double>();
        private static List<double> q2 = new List<double>();
        private static List<double> q3 = new List<double>();
        private static List<string> date1 = new List<string>();
        private static List<double> lat1 = new List<double>();
        private static List<double> lon1 = new List<double>();
        private static List<double> x3 = new List<double>();
        private static List<double> y3 = new List<double>();
        private static List<double> z3 = new List<double>();
        private static List<double> x4 = new List<double>();
        private static List<double> y4 = new List<double>();
        private static List<double> z4 = new List<double>();

        private static List<double> q00 = new List<double>();
        private static List<double> q11 = new List<double>();
        private static List<double> q22 = new List<double>();
        private static List<double> q33 = new List<double>();







        private  List<double> av = new List<double>();
        private  List<int> ct = new List<int>();
        private  List<double> mn = new List<double>();
        private  List<double> mx = new List<double>();
        private  List<int> sol_hours_with_data = new List<int>();
        private  List<bool> valid = new List<bool>();
        private  List<DateTime> First_UTC = new List<DateTime>();
        private  List<double> av01 = new List<double>();
        private  List<int> ct01 = new List<int>();
        private  List<double> mn01 = new List<double>();
        private  List<double> mx01 = new List<double>();
        private  List<int> sol_hours_with_data01 = new List<int>();
        private  List<bool> valid01 = new List<bool>();
        private  List<DateTime> Last_UTC = new List<DateTime>();
        private  List<int> Month_ordinal = new List<int>();
        private  List<string> Northern_season = new List<string>();
        private  List<double> av02 = new List<double>();
        private  List<int> ct02 = new List<int>();
        private  List<double> mn02 = new List<double>();
        private  List<double> mx02 = new List<double>();
        private  List<int> sol_hours_with_data02 = new List<int>();
        private  List<bool> valid02 = new List<bool>();
        private  List<string> Season = new List<string>();
        private  List<string> Southern_season = new List<string>();
        private  List<double> compass_degrees = new List<double>();
        private  List<string> compass_point = new List<string>();
        private  List<double> compass_right = new List<double>();
        private  List<double> compass_up = new List<double>();
        private  List<int> ct03 = new List<int>();
        private  List<double> compass_degrees01 = new List<double>();
        private  List<string> compass_point01 = new List<string>();
        private  List<double> compass_right01 = new List<double>();
        private  List<double> compass_up01 = new List<double>();
        private  List<int> ct04 = new List<int>();
        private  List<double> compass_degrees02 = new List<double>();
        private  List<string> compass_point02 = new List<string>();
        private  List<double> compass_right02 = new List<double>();
        private  List<double> compass_up02 = new List<double>();
        private  List<int> ct05 = new List<int>();
        private  List<double> compass_degrees03 = new List<double>();
        private  List<string> compass_point03 = new List<string>();
        private  List<double> compass_right03 = new List<double>();
        private  List<double> compass_up03 = new List<double>();
        private  List<int> ct06 = new List<int>();
        private  List<double> compass_degrees04 = new List<double>();
        private  List<string> compass_point04 = new List<string>();
        private  List<double> compass_right04 = new List<double>();
        private  List<double> compass_up04 = new List<double>();
        private  List<int> ct07 = new List<int>();
        private  List<double> compass_degrees05 = new List<double>();
        private  List<string> compass_point05 = new List<string>();
        private  List<double> compass_right05 = new List<double>();
        private  List<double> compass_up05 = new List<double>();
        private  List<int> ct08 = new List<int>();
        private  List<double> compass_degrees06 = new List<double>();
        private  List<string> compass_point06 = new List<string>();
        private  List<double> compass_right06 = new List<double>();
        private  List<double> compass_up06 = new List<double>();
        private  List<int> ct09 = new List<int>();
        private  List<double> compass_degrees07 = new List<double>();
        private  List<string> compass_point07 = new List<string>();
        private  List<double> compass_right07 = new List<double>();
        private  List<double> compass_up07 = new List<double>();
        private  List<int> ct10 = new List<int>();
        private  List<double> compass_degrees08 = new List<double>();
        private  List<string> compass_point08 = new List<string>();
        private  List<double> compass_right08 = new List<double>();
        private  List<double> compass_up08 = new List<double>();
        private  List<int> ct11 = new List<int>();
        private  List<double> compass_degrees09 = new List<double>();
        private  List<string> compass_point09 = new List<string>();
        private  List<double> compass_right09 = new List<double>();
        private  List<double> compass_up09 = new List<double>();
        private  List<int> ct12 = new List<int>();
        private  List<double> compass_degrees10 = new List<double>();
        private  List<string> compass_point10 = new List<string>();
        private  List<double> compass_right10 = new List<double>();
        private  List<double> compass_up10 = new List<double>();
        private  List<int> ct13 = new List<int>();



        public List<Nasa_Set_Model01> collectiondata01 = new List<Nasa_Set_Model01>();
        public List<Nasa_Set_Model02> collectiondata02 = new List<Nasa_Set_Model02>();
        public List<Nasa_Set_Model03> collectiondata03 = new List<Nasa_Set_Model03>();
        public List<Nasa_Set_Model04> collectiondata04 = new List<Nasa_Set_Model04>();
        public List<Nasa_Set_Model05> collectiondata05 = new List<Nasa_Set_Model05>();
        public List<Nasa_Set_Model06> collectiondata06 = new List<Nasa_Set_Model06>();
        public List<Nasa_Set_Model07> collectiondata07 = new List<Nasa_Set_Model07>();
        private static Read_Textfiles01 READ = new Read_Textfiles01();



        public async Task<string> APOD()
        {


            data01[1] = await nasa_data01($"https://api.nasa.gov/planetary/apod?api_key={READ.api[4]}");

            return data01[1];
        }
        public async Task<string> Asteroids_NeoWs()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data02($"https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-07&end_date=2015-09-08&api_key={READ.api[4]}");

            return data01[1];
        }

        public async Task<string> DONKI_Coronal_Mass_Ejection_CME()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data03($"https://api.nasa.gov/DONKI/CME?startDate=2017-01-03&endDate=2017-01-03&api_key={READ.api[4]}");

            return data01[1];
        }
        public async Task<string> DONKI_Coronal_Mass_Ejection_CME_Analysis()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data03($"https://api.nasa.gov/DONKI/CME?startDate=2017-01-03&endDate=2017-01-03&api_key={READ.api[4]}");

            return data01[1];
        }

        public async Task<string> DONKI_Geomagnetic_Storm_GST()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data04($"https://api.nasa.gov/DONKI/GST?startDate=yyyy-MM-dd&endDate=yyyy-MM-dd&api_key={READ.api[4]}");

            return data01[1];
        }

        public async Task<string> DONKI_Interplanetary_Shock_IPS()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data04($"https://api.nasa.gov/DONKI/IPS?startDate=yyyy-MM-dd&endDate=yyyy-MM-dd&location=LOCATION&catalog=CATALOG&api_key={READ.api[4]}");

            return data01[1];
        }

        public async Task<string> DONKI_Solar_Flare_FLR()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data05($"https://api.nasa.gov/DONKI/FLR?startDate=yyyy-MM-dd&endDate=yyyy-MM-dd&api_key={READ.api[4]}");

            return data01[1];
        }

        public async Task<string> DONKI_Solar_Energetic_Particle_SEP()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data06($"https://api.nasa.gov/DONKI/SEP?startDate=yyyy-MM-dd&endDate=yyyy-MM-dd&api_key={READ.api[4]}");

            return data01[1];
        }

        public async Task<string> DONKI_Magnetopause_Crossing_MPC()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data06($"https://api.nasa.gov/DONKI/MPC?startDate=yyyy-MM-dd&endDate=yyyy-MM-dd&api_key={READ.api[4]}");

            return data01[1];
        }

        public async Task<string> DONKI_Radiation_Belt_Enhancement_RBE()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data06($"https://api.nasa.gov/DONKI/RBE?startDate=yyyy-MM-dd&endDate=yyyy-MM-dd&api_key={READ.api[4]}");

            return data01[1];
        }

        public async Task<string> DONKI_Hight_Speed_Stream_HSS()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data04($"https://api.nasa.gov/DONKI/HSS?startDate=yyyy-MM-dd&endDate=yyyy-MM-dd&api_key={READ.api[4]}");

            return data01[1];
        }

        public async Task<string> DONKI_WSA_EnlilSimulation()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data04($"https://api.nasa.gov/DONKI/WSAEnlilSimulations?startDate=2016-01-06&endDate=2016-01-06&api_key={READ.api[4]}");

            return data01[1];
        }

        public async Task<string> DONKI_Notifications()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data04($"https://api.nasa.gov/DONKI/notifications?startDate=2014-05-01&endDate=2014-05-08&type=all&api_key={READ.api[4]}");

            return data01[1];
        }
        public async Task<string> EPIC01()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data07($"https://api.nasa.gov/EPIC/api/natural?api_key={READ.api[4]}");

            return data01[1];
        }
        public async Task<string> EPIC02()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data07($"https://api.nasa.gov/EPIC/api/natural/date/2019-05-30?api_key={READ.api[4]}");

            return data01[1];
        }
        public async Task<string> EPIC03()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data07($"https://api.nasa.gov/EPIC/api/natural/all?api_key={READ.api[4]}");

            return data01[1];
        }
        public async Task<string> EPIC04()
        {
            DateTime date = DateTime.Now;
            string input01 = date.ToString("YYYY-MM-DD");
            data01[1] = await nasa_data07($"https://api.nasa.gov/EPIC/archive/natural/2019/05/30/png/epic_1b_20190530011359.png?api_key={READ.api[4]}");

            return data01[1];
        }
        public async Task<string> InSight_Mars_Weather_Service_API()
        {

            data01[1] = await nasa_data07($"https://api.nasa.gov/insight_weather/?api_key={READ.api[4]}&feedtype=json&ver=1.0");

            return data01[1];
        }
        private async Task<string> nasa_data01(string input)
        {
            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            Nasa_Model01.Root resaults = JsonConvert.DeserializeObject<Nasa_Model01.Root>(body);
            copyright.Add(resaults.copyright);
            date.Add(resaults.date);
            explanation.Add(resaults.explanation);
            hdurl.Add(resaults.hdurl);
            media_type.Add(resaults.media_type);
            service_version.Add(resaults.service_version);
            title.Add(resaults.title);
            url.Add(resaults.url);


            var collection_set = new Nasa_Set_Model01
            {
                Copyright = resaults.copyright,
                Date = resaults.date,
                Explanation = resaults.explanation,
                Hdurl = resaults.hdurl,
                Media_type = resaults.media_type,
                Service_version = resaults.service_version,
                Title01 = resaults.title,
                Url = resaults.url,

            };
            collectiondata01.Add(collection_set);


            for (int i = 0; i < copyright.Count; i++)
            {
                data01[0] +=
                $"copyright: {copyright[i]}\n" +
                $"date: {date[i]}\n" +
                $"explanation: {explanation[i]}\n" +
                $"hdurl: {hdurl[i]}\n" +
                $"media_type: {media_type[i]}\n" +
                $"service_version: {service_version[i]}\n" +
                $"title: {title[i]}\n" +
                $"url: {url[i]}\n";
            }
            return data01[0];
        }
        private async Task<string> nasa_data02(string input)//need to finish the variables
        {
            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            Nasa_Model02.Root results = JsonConvert.DeserializeObject<Nasa_Model02.Root>(body);
            next.Add(results.links.next);
            previous.Add(results.links.previous);
            self.Add(results.links.self);
            element_count.Add(results.element_count);

            foreach (var a in results.near_earth_objects._20150908)
            {
                next01.Add(a.links.next);
                previous01.Add(a.links.next);
                self01.Add(a.links.next);
                id.Add(a.id);
                neo_reference_id.Add(a.neo_reference_id);
                name.Add(a.name);
                nasa_jpl_url.Add(a.nasa_jpl_url);
                absolute_magnitude_h.Add(a.absolute_magnitude_h);
                estimated_diameter_min.Add(a.estimated_diameter.kilometers.estimated_diameter_min);
                estimated_diameter_max.Add(a.estimated_diameter.kilometers.estimated_diameter_max);
                estimated_diameter_min01.Add(a.estimated_diameter.meters.estimated_diameter_max);
                estimated_diameter_max01.Add(a.estimated_diameter.meters.estimated_diameter_min);
                estimated_diameter_min02.Add(a.estimated_diameter.miles.estimated_diameter_max);
                estimated_diameter_max02.Add(a.estimated_diameter.miles.estimated_diameter_min);
                estimated_diameter_min03.Add(a.estimated_diameter.feet.estimated_diameter_max);
                estimated_diameter_max03.Add(a.estimated_diameter.feet.estimated_diameter_min);
                is_potentially_hazardous_asteroid.Add(a.is_potentially_hazardous_asteroid);

                foreach (var b in a.close_approach_data)
                {
                    close_approach_date.Add(b.close_approach_date);
                    close_approach_date_full.Add(b.close_approach_date_full);
                    epoch_date_close_approach.Add(b.epoch_date_close_approach);
                    kilometers_per_second.Add(b.relative_velocity.kilometers_per_second);
                    kilometers_per_hour.Add(b.relative_velocity.kilometers_per_hour);
                    miles_per_hour.Add(b.relative_velocity.miles_per_hour);
                    astronomical.Add(b.miss_distance.astronomical);
                    lunar.Add(b.miss_distance.lunar);
                    kilometers.Add(b.miss_distance.kilometers);
                    miles.Add(b.miss_distance.miles);
                    orbiting_body.Add(b.orbiting_body);
                }
                is_sentry_object.Add(a.is_sentry_object);
            }

            var collection_set = new Nasa_Set_Model02
            {
                Next = results.links.next,
                Previous = results.links.previous,
                Self = results.links.self,
                Element_count = results.element_count,
                Next01 = next01.Count > 0 ? next01[0] : null,
                Previous01 = previous01.Count > 0 ? previous01[0] : null,
                Self01 = self01.Count > 0 ? self01[0] : null,
                Id = id.Count > 0 ? id[0] : null,
                Neo_reference_id = neo_reference_id.Count > 0 ? neo_reference_id[0] : null,
                Name = name.Count > 0 ? name[0] : null,
                Nasa_jpl_url = nasa_jpl_url.Count > 0 ? nasa_jpl_url[0] : null,
                Absolute_magnitude_h = absolute_magnitude_h.Count > 0 ? absolute_magnitude_h[0].ToString() : null,
                Estimated_diameter_min = estimated_diameter_min.Count > 0 ? estimated_diameter_min[0].ToString() : null,
                Estimated_diameter_max = estimated_diameter_max.Count > 0 ? estimated_diameter_max[0].ToString() : null,
                Estimated_diameter_min01 = estimated_diameter_min01.Count > 0 ? estimated_diameter_min01[0].ToString() : null,
                Estimated_diameter_max01 = estimated_diameter_max01.Count > 0 ? estimated_diameter_max01[0].ToString() : null,
                Estimated_diameter_min02 = estimated_diameter_min02.Count > 0 ? estimated_diameter_min02[0].ToString() : null,
                Estimated_diameter_max02 = estimated_diameter_max02.Count > 0 ? estimated_diameter_max02[0].ToString() : null,
                Estimated_diameter_min03 = estimated_diameter_min03.Count > 0 ? estimated_diameter_min03[0].ToString() : null,
                Estimated_diameter_max03 = estimated_diameter_max03.Count > 0 ? estimated_diameter_max03[0].ToString() : null,
                Is_potentially_hazardous_asteroid = is_potentially_hazardous_asteroid.Count > 0 ? is_potentially_hazardous_asteroid[0].ToString() : null,
                Close_approach_date = close_approach_date.Count > 0 ? close_approach_date[0] : null,
                Close_approach_date_full = close_approach_date_full.Count > 0 ? close_approach_date_full[0] : null,
                Epoch_date_close_approach = epoch_date_close_approach.Count > 0 ? epoch_date_close_approach[0].ToString() : null,
                Kilometers_per_second = kilometers_per_second.Count > 0 ? kilometers_per_second[0] : null,
                Kilometers_per_hour = kilometers_per_hour.Count > 0 ? kilometers_per_hour[0] : null,
                Miles_per_hour = miles_per_hour.Count > 0 ? miles_per_hour[0] : null,
                Astronomical = astronomical.Count > 0 ? astronomical[0] : null,
                Lunar = lunar.Count > 0 ? lunar[0] : null,
                Kilometers = kilometers.Count > 0 ? kilometers[0] : null,
                Miles = miles.Count > 0 ? miles[0] : null,
                Orbiting_body = orbiting_body.Count > 0 ? orbiting_body[0] : null,
                Is_sentry_object = is_sentry_object.Count > 0 ? is_sentry_object[0].ToString() : null

            };
            collectiondata02.Add(collection_set);

            for (int i = 0; i < copyright.Count; i++)
            {
                data01[0] +=
                $"next: {next[i]}\n" +
                $"previous: {previous[i]}\n" +
                $"self: {self[i]}\n" +
                $"element_count: {element_count[i]}\n" +
                $"next01: {next01[i]}\n" +
                $"previous01: {previous01[i]}\n" +
                $"self01: {self01[i]}\n" +
                $"id: {id[i]}\n" +
                $"neo_reference_id: {neo_reference_id[i]}\n" +
                $"name: {name[i]}\n" +
                $"nasa_jpl_url: {nasa_jpl_url[i]}\n" +
                $"absolute_magnitude_h: {absolute_magnitude_h[i]}\n" +
                $"estimated_diameter_min: {estimated_diameter_min[i]}\n" +
                $"estimated_diameter_max: {estimated_diameter_max[i]}\n" +
                $"estimated_diameter_min01: {estimated_diameter_min01[i]}\n" +
                $"estimated_diameter_max01: {estimated_diameter_max01[i]}\n" +
                $"estimated_diameter_min02: {estimated_diameter_min02[i]}\n" +
                $"estimated_diameter_max02: {estimated_diameter_max02[i]}\n" +
                $"estimated_diameter_min03: {estimated_diameter_min03[i]}\n" +
                $"estimated_diameter_max03: {estimated_diameter_max03[i]}\n" +
                $"is_potentially_hazardous_asteroid: {is_potentially_hazardous_asteroid[i]}\n" +
                $"close_approach_date: {close_approach_date[i]}\n" +
                $"close_approach_date_full: {close_approach_date_full[i]}\n" +
                $"epoch_date_close_approach: {epoch_date_close_approach[i]}\n" +
                $"kilometers_per_second: {kilometers_per_second[i]}\n" +
                $"kilometers_per_hour: {kilometers_per_hour[i]}\n" +
                $"miles_per_hour: {miles_per_hour[i]}\n" +
                $"astronomical: {astronomical[i]}\n" +
                $"lunar: {lunar[i]}\n" +
                $"kilometers: {kilometers[i]}\n" +
                $"miles: {miles[i]}\n" +
                $"orbiting_body: {orbiting_body[i]}\n" +
                $"is_sentry_object: {is_sentry_object[i]}\n";
            }



            return data01[0];

        }
        private async Task<string> nasa_data03(string input)
        {
            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nasa_Model03.Root> results = JsonConvert.DeserializeObject<List<Nasa_Model03.Root>>(body);
            foreach (var s in results)
            {
                activityID.Add(s.activityID);
                catalog.Add(s.catalog);
                startTime.Add(s.startTime);
                if (s.instruments != null)
                {
                    foreach (var a in s.instruments)
                    {
                        displayName.Add(a.displayName);
                    }
                }
                else
                {
                    displayName.Add(" ");
                }

                sourceLocation.Add(s.sourceLocation);
                activeRegionNum.Add(s.activeRegionNum);
                note.Add(s.note);
                submissionTime.Add(s.submissionTime);
                versionId.Add(s.versionId);
                link.Add(s.link);
                if (s.cmeAnalyses != null)
                {
                    foreach (var a in s.cmeAnalyses)
                    {
                        isMostAccurate.Add(a.isMostAccurate);
                        time21_5.Add(a.time21_5);
                        latitude.Add(a.latitude);
                        longitude.Add(a.longitude);
                        halfAngle.Add(a.halfAngle);
                        speed.Add(a.speed);
                        type.Add(a.type);
                        featureCode.Add(a.featureCode);
                        imageType.Add(a.imageType);
                        measurementTechnique.Add(a.measurementTechnique);
                        note01.Add(a.note);
                        levelOfData.Add(a.levelOfData);
                        tilt.Add(a.tilt);
                        minorHalfWidth.Add(a.minorHalfWidth);
                        speedMeasuredAtHeight.Add(a.speedMeasuredAtHeight);
                        submissionTime01.Add(a.submissionTime);
                        link01.Add(a.link);
                        if (a.enlilList != null)
                        {

                            foreach (var b in a.enlilList)
                            {
                                modelCompletionTime.Add(b.modelCompletionTime);
                                au.Add(b.au);
                                estimatedShockArrivalTime.Add(b.estimatedShockArrivalTime);
                                estimatedDuration.Add(b.estimatedDuration);
                                rmin_re.Add(b.rmin_re);
                                kp_18.Add(b.kp_18);
                                kp_90.Add(b.kp_90);
                                kp_135.Add(b.kp_135);
                                kp_180.Add(b.kp_180);
                                isEarthGB.Add(b.isEarthGB);
                                isEarthMinorImpact.Add(b.isEarthMinorImpact);
                                link02.Add(b.link);

                                if (b.impactList != null)
                                {
                                    foreach (var c in b.impactList)
                                    {
                                        isGlancingBlow.Add(c.isGlancingBlow);
                                        isMinorImpact.Add(c.isMinorImpact);
                                        location.Add(c.location);
                                        arrivalTime.Add(c.arrivalTime);

                                    }
                                }
                                else
                                {
                                    isGlancingBlow.Add(null);
                                    isMinorImpact.Add(null);
                                    location.Add(" ");
                                    arrivalTime.Add(" ");
                                }
                                if (b.cmeIDs != null)
                                {
                                    foreach (var c in b.cmeIDs)
                                    {
                                        cmeIDs.Add(c);
                                    }
                                }
                                else
                                {
                                    cmeIDs.Add(" ");

                                }



                            }
                        }
                        else
                        {
                            modelCompletionTime.Add(" ");
                            au.Add(0);
                            estimatedShockArrivalTime.Add(" ");
                            estimatedDuration.Add(" ");
                            rmin_re.Add(" ");
                            kp_18.Add(" ");
                            kp_90.Add(" ");
                            kp_135.Add(" ");
                            kp_180.Add(" ");
                            isEarthGB.Add(null);
                            isEarthMinorImpact.Add(null);
                            link02.Add(" ");

                        }



                    }

                }
                else
                {

                    isMostAccurate.Add(null);
                    time21_5.Add(" ");
                    latitude.Add(0);
                    longitude.Add(0);
                    halfAngle.Add(0);
                    speed.Add(0);
                    type.Add(" ");
                    featureCode.Add(" ");
                    imageType.Add(" ");
                    measurementTechnique.Add(" ");
                    note01.Add(" ");
                    levelOfData.Add(0);
                    tilt.Add(" ");
                    minorHalfWidth.Add(" ");
                    speedMeasuredAtHeight.Add(" ");
                    submissionTime01.Add(" ");
                    link01.Add(" ");
                }


                linkedEvents.Add(s.linkedEvents);
                if (s.sentNotifications != null)
                {
                    foreach (var b in s.sentNotifications)
                    {
                        messageID.Add(b.messageID);
                        messageIssueTime.Add(b.messageIssueTime);
                        messageURL.Add(b.messageURL);
                    }
                }
                else
                {

                    messageID.Add(" ");
                    messageIssueTime.Add(" ");
                    messageURL.Add(" ");

                }






            }


            var collection_set = new Nasa_Set_Model03
            {

                ActivityID = activityID.Count > 0 ? activityID[0] : null,
                Catalog = catalog.Count > 0 ? catalog[0] : null,
                StartTime = startTime.Count > 0 ? startTime[0] : null,
                DisplayName = displayName.Count > 0 ? displayName[0] : null,
                SourceLocation = sourceLocation.Count > 0 ? sourceLocation[0] : null,
                ActiveRegionNum = activeRegionNum.Count > 0 ? activeRegionNum[0] : null,
                Note = note.Count > 0 ? note[0] : null,
                SubmissionTime = submissionTime.Count > 0 ? submissionTime[0] : null,
                VersionId = versionId.Count > 0 ? versionId[0] : null,
                Link = link.Count > 0 ? link[0] : null,
                IsMostAccurate = isMostAccurate.Count > 0 ? isMostAccurate[0]?.ToString() : null,
                Time21_5 = time21_5.Count > 0 ? time21_5[0] : null,
                Latitude = latitude.Count > 0 ? latitude[0].ToString() : null,
                Longitude = longitude.Count > 0 ? longitude[0].ToString() : null,
                HalfAngle = halfAngle.Count > 0 ? halfAngle[0].ToString() : null,
                Speed = speed.Count > 0 ? speed[0].ToString() : null,
                Type = type.Count > 0 ? type[0] : null,
                FeatureCode = featureCode.Count > 0 ? featureCode[0] : null,
                ImageType = imageType.Count > 0 ? imageType[0] : null,
                MeasurementTechnique = measurementTechnique.Count > 0 ? measurementTechnique[0] : null,
                Note01 = note01.Count > 0 ? note01[0] : null,
                LevelOfData = levelOfData.Count > 0 ? levelOfData[0].ToString() : null,
                Tilt = tilt.Count > 0 ? tilt[0] : null,
                MinorHalfWidth = minorHalfWidth.Count > 0 ? minorHalfWidth[0] : null,
                SpeedMeasuredAtHeight = speedMeasuredAtHeight.Count > 0 ? speedMeasuredAtHeight[0] : null,
                SubmissionTime01 = submissionTime01.Count > 0 ? submissionTime01[0] : null,
                Link01 = link01.Count > 0 ? link01[0] : null,
                ModelCompletionTime = modelCompletionTime.Count > 0 ? modelCompletionTime[0] : null,
                Au = au.Count > 0 ? au[0].ToString() : null,
                EstimatedShockArrivalTime = estimatedShockArrivalTime.Count > 0 ? estimatedShockArrivalTime[0] : null,
                EstimatedDuration = estimatedDuration.Count > 0 ? estimatedDuration[0] : null,
                Rmin_re = rmin_re.Count > 0 ? rmin_re[0] : null,
                Kp_18 = kp_18.Count > 0 ? kp_18[0] : null,
                Kp_90 = kp_90.Count > 0 ? kp_90[0] : null,
                Kp_135 = kp_135.Count > 0 ? kp_135[0] : null,
                Kp_180 = kp_180.Count > 0 ? kp_180[0] : null,
                IsEarthGB = isEarthGB.Count > 0 ? isEarthGB[0]?.ToString() : null,
                IsEarthMinorImpact = isEarthMinorImpact.Count > 0 ? isEarthMinorImpact[0]?.ToString() : null,
                Link02 = link02.Count > 0 ? link02[0] : null,
                IsGlancingBlow = isGlancingBlow.Count > 0 ? isGlancingBlow[0]?.ToString() : null,
                IsMinorImpact = isMinorImpact.Count > 0 ? isMinorImpact[0]?.ToString() : null,
                Location = location.Count > 0 ? location[0] : null,
                ArrivalTime = arrivalTime.Count > 0 ? arrivalTime[0] : null,
                CmeIDs = cmeIDs.Count > 0 ? cmeIDs[0] : null,
                LinkedEvents = linkedEvents.Count > 0 ? linkedEvents[0] : null,
                MessageID = messageID.Count > 0 ? messageID[0] : null,
                MessageIssueTime = messageIssueTime.Count > 0 ? messageIssueTime[0] : null,
                MessageURL = messageURL.Count > 0 ? messageURL[0] : null

            };
            collectiondata03.Add(collection_set);

            int minCount = new[]
           {
      activityID.Count,

         catalog.Count,
        startTime.Count,
        displayName.Count,
          sourceLocation.Count,
     activeRegionNum.Count,
        note.Count,
         submissionTime.Count,
      versionId.Count,
      link.Count,
         isMostAccurate.Count,
     time21_5.Count,
        latitude.Count,
     longitude.Count,
        halfAngle.Count,
       speed.Count,
    type.Count,
      featureCode.Count,
        imageType.Count,
         measurementTechnique.Count,
         note01.Count,
        levelOfData.Count,
         tilt.Count,
       minorHalfWidth.Count,
          speedMeasuredAtHeight.Count,
          submissionTime01.Count,
           link01.Count,
        modelCompletionTime.Count,
        au.Count,
         estimatedShockArrivalTime.Count,
        estimatedDuration.Count,
       rmin_re.Count,
          kp_18.Count,
        kp_90.Count,
           kp_135.Count,
        kp_180.Count,
        isEarthGB.Count,
           isEarthMinorImpact.Count,
          link02.Count,
         isGlancingBlow.Count,
         isMinorImpact.Count,
        location.Count,
       arrivalTime.Count,
    cmeIDs.Count,
         linkedEvents.Count,
           messageID.Count,
           messageIssueTime.Count,
          messageURL.Count
        }.Min();

            for (var i = 0; i < minCount; i++)
            {
                data01[0] +=
                $"activityID: {activityID[i]}\n" +

           $"catalog: {catalog[i]}\n" +
          $"startTime: {startTime[i]}\n" +
           $"displayName: {displayName[i]}\n" +
           $"sourceLocation: {sourceLocation[i]}\n" +
         $"activeRegionNum: {activeRegionNum[i]}\n" +
           $"note: {note[i]}\n" +
           $"submissionTime: {submissionTime[i]}\n" +
           $"versionId: {versionId[i]}\n" +
         $"link: {link[i]}\n" +
          $"isMostAccurate: {isMostAccurate[i]}\n" +
         $"time21_5: {time21_5[i]}\n" +
         $"latitude: {latitude[i]}\n" +
         $"longitude: {longitude[i]}\n" +
         $"halfAngle: {halfAngle[i]}\n" +
           $"speed: {speed[i]}\n" +
        $"type: {type[i]}\n" +
          $"featureCode: {featureCode[i]}\n" +
         $"imageType: {imageType[i]}\n" +
           $"measurementTechnique: {measurementTechnique[i]}\n" +
           $"note01: {note01[i]}\n" +
           $"levelOfData: {levelOfData[i]}\n" +
           $"tilt: {tilt[i]}\n" +
          $"minorHalfWidth: {minorHalfWidth[i]}\n" +
           $"speedMeasuredAtHeight: {speedMeasuredAtHeight[i]}\n" +
           $"submissionTime01: {submissionTime01[i]}\n" +
           $"link01: {link01[i]}\n" +
           $"modelCompletionTime: {modelCompletionTime[i]}\n" +
           $"au: {au[i]}\n" +
           $"estimatedShockArrivalTime: {estimatedShockArrivalTime[i]}\n" +
           $"estimatedDuration: {estimatedDuration[i]}\n" +
           $"rmin_re: {rmin_re[i]}\n" +
           $"kp_18: {kp_18[i]}\n" +
           $"kp_90: {kp_90[i]}\n" +
           $"kp_135: {kp_135[i]}\n" +
           $"kp_180: {kp_180[i]}\n" +
           $"isEarthGB: {isEarthGB[i]}\n" +
           $"isEarthMinorImpact: {isEarthMinorImpact[i]}\n" +
           $"link02: {link02[i]}\n" +
           $"isGlancingBlow: {isGlancingBlow[i]}\n" +
           $"isMinorImpact: {isMinorImpact[i]}\n" +
           $"location: {location[i]}\n" +
           $"arrivalTime: {arrivalTime[i]}\n" +
         $"cmeIDs: {cmeIDs[i]}\n" +
         $"linkedEvents: {linkedEvents[i]}\n" +
           $"messageID: {messageID[i]}\n" +
           $"messageIssueTime: {messageIssueTime[i]}\n" +
           $"messageURL: {messageURL[i]}\n";

            }
            data01[3] = body;
            return data01[0];
        }
        private async Task<string> nasa_data04(string input)
        {
            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nasa_Model04.Root> results = JsonConvert.DeserializeObject<List<Nasa_Model04.Root>>(body);

            if (results != null)
            {
                foreach (var a in results)
                {

                    gstID.Add(a.gstID);
                    startTime.Add(a.startTime);
                    if (a.allKpIndex != null)
                    {
                        foreach (var b in a.allKpIndex)
                        {
                            observedTime.Add(b.observedTime);
                            kpIndex.Add(b.kpIndex);
                            source.Add(b.source);
                        }
                    }
                    else
                    {
                        observedTime.Add(" ");
                        kpIndex.Add(0);
                        source.Add(" ");

                    }


                    link.Add(a.link);
                    if (a.linkedEvents != null)
                    {
                        foreach (var b in a.linkedEvents)
                        {
                            activityID.Add(b.activityID);

                        }
                    }
                    else
                    {

                        activityID.Add(" ");

                    }
                    if (a.sentNotifications != null)
                    {
                        foreach (var b in a.sentNotifications)
                        {
                            messageID.Add(b.messageID);
                            messageIssueTime.Add(b.messageIssueTime);
                            messageURL.Add(b.messageURL);
                        }
                    }
                    else
                    {
                        messageID.Add(" ");
                        messageIssueTime.Add(" ");
                        messageURL.Add(" ");
                    }



                    submissionTime.Add(a.submissionTime);
                    versionId.Add(a.versionId);

                }
            }
            else
            {

                gstID.Add(" ");
                startTime.Add(" ");
                link.Add(" ");
                submissionTime.Add(" ");
                versionId.Add(0);
            }


            var collection_set = new Nasa_Set_Model04
            {

                GstID = gstID.Count > 0 ? gstID[0] : null,
                StartTime = startTime.Count > 0 ? startTime[0] : null,
                ObservedTime = observedTime.Count > 0 ? observedTime[0] : null,
                KpIndex = kpIndex.Count > 0 ? kpIndex[0].ToString() : null,
                Source = source.Count > 0 ? source[0] : null,
                ActivityID = activityID.Count > 0 ? activityID[0] : null,
                MessageID = messageID.Count > 0 ? messageID[0] : null,
                MessageIssueTime = messageIssueTime.Count > 0 ? messageIssueTime[0] : null,
                MessageURL = messageURL.Count > 0 ? messageURL[0] : null,
                SubmissionTime = submissionTime.Count > 0 ? submissionTime[0] : null,
                VersionId = versionId.Count > 0 ? versionId[0].ToString() : null






            };

            collectiondata04.Add(collection_set);






            int minCount = new[]
           {            gstID.Count,
            startTime.Count,
            observedTime.Count,
            kpIndex.Count,
            source.Count,
            activityID.Count,
            messageID.Count,
            messageIssueTime.Count,
            messageURL.Count,
            submissionTime.Count,
            versionId.Count
        }.Min();


            for (var i = 0; i < minCount; i++)
            {
                data01[0] +=
                $"gstID: {gstID[i]}\n" +
                $"startTime: {startTime[i]}\n" +
                $"observedTime: {observedTime[i]}\n" +
                $"kpIndex: {kpIndex[i]}\n" +
                $"source: {source[i]}\n" +
                $"activityID: {activityID[i]}\n" +
                $"messageID: {messageID[i]}\n" +
                $"messageIssueTime: {messageIssueTime[i]}\n" +
                $"messageURL: {messageURL[i]}\n" +
                $"submissionTime: {submissionTime[i]}\n" +
                $"versionId: {versionId[i]}\n";






            }
            data01[3] = body;





            return data01[0];
        }
        private async Task<string> nasa_data05(string input)
        {
            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nasa_Model05.Root> results = JsonConvert.DeserializeObject<List<Nasa_Model05.Root>>(body);

            if (results != null)
            {
                foreach (var a in results)
                {

                    flrID.Add(a.flrID);
                    catalog.Add(a.catalog);
                    if (a.instruments != null)
                    {
                        foreach (var b in a.instruments)
                        {
                            displayName.Add(b.displayName);
                        }

                        beginTime.Add(a.beginTime);
                        peakTime.Add(a.peakTime);
                        endTime.Add(a.endTime);
                        classType.Add(a.classType);
                        sourceLocation.Add(a.sourceLocation);
                        activeRegionNum.Add(a.activeRegionNum);
                        note.Add(a.note);
                        submissionTime.Add(a.submissionTime);
                        versionId.Add(a.versionId);
                        link.Add(a.link);
                        if (a.linkedEvents != null)
                        {
                            foreach (var b in a.linkedEvents)
                            {
                                activityID.Add(b.activityID);
                            }

                        }
                        else
                        {
                            activityID.Add(" ");
                        }

                        sentNotifications.Add(a.sentNotifications);
                    }
                    else
                    {
                        beginTime.Add(" ");
                        peakTime.Add(" ");
                        endTime.Add(" ");
                        classType.Add(" ");
                        sourceLocation.Add(" ");
                        activeRegionNum.Add(" ");
                        note.Add(" ");
                        submissionTime.Add(" ");
                        versionId.Add(0);
                        link.Add(" ");
                        sentNotifications.Add(" ");
                    }

                }

            }
            else
            {
                flrID.Add(" ");
                catalog.Add(" ");
            }

            var collection_set = new Nasa_Set_Model05
            {
                FlrID = flrID.Count > 0 ? flrID[0] : null,
                Catalog = catalog.Count > 0 ? catalog[0] : null,
                DisplayName = displayName.Count > 0 ? displayName[0] : null,
                BeginTime = beginTime.Count > 0 ? beginTime[0] : null,
                PeakTime = peakTime.Count > 0 ? peakTime[0] : null,
                EndTime = endTime.Count > 0 ? endTime[0] : null,
                ClassType = classType.Count > 0 ? classType[0] : null,
                SourceLocation = sourceLocation.Count > 0 ? sourceLocation[0] : null,
                ActiveRegionNum = activeRegionNum.Count > 0 ? activeRegionNum[0] : null,
                Note = note.Count > 0 ? note[0] : null,
                SubmissionTime = submissionTime.Count > 0 ? submissionTime[0] : null,
                VersionId = versionId.Count > 0 ? versionId[0].ToString() : null,
                Link = link.Count > 0 ? link[0] : null,
                ActivityID = activityID.Count > 0 ? activityID[0] : null








            };

            collectiondata05.Add(collection_set);


            int minCount = new[]
{

                flrID.Count,
            catalog.Count,
            displayName.Count,
            beginTime.Count,
            peakTime.Count,
            endTime.Count,
            classType.Count,
            sourceLocation.Count,
            activeRegionNum.Count,
            note.Count,
            submissionTime.Count,
            versionId.Count,
            link.Count,
            activityID.Count


        }.Min();

            for (var i = 0; i < minCount; i++)
            {
                data01[0] +=
                $"flrID: {flrID[i]}\n" +
                $"catalog: {catalog[i]}\n" +
            $"displayName: {displayName[i]}\n" +
            $"beginTime: {beginTime[i]}\n" +
            $"peakTime: {peakTime[i]}\n" +
            $"endTime: {endTime[i]}\n" +
            $"classType: {classType[i]}\n" +
            $"sourceLocation: {sourceLocation[i]}\n" +
           $"activeRegionNum: {activeRegionNum[i]}\n" +
           $"note: {note[i]}\n" +
          $"submissionTime: {submissionTime[i]}\n" +
           $"versionId: {versionId[i]}\n" +
           $"link: {link[i]}\n" +
          $"activityID: {activityID[i]}\n";
            }



            data01[3] = body;
            return data01[0];
        }
        private async Task<string> nasa_data06(string input)
        {
            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nasa_Model06.Root> results = JsonConvert.DeserializeObject<List<Nasa_Model06.Root>>(body);


            if (results != null)
            {
                foreach (var a in results)
                {
                    rbeID.Add(a.rbeID);



                    mpcID.Add(a.sepID);
                    sepID.Add(a.sepID);
                    eventTime.Add(a.eventTime);
                    if (a.instruments != null)
                    {
                        foreach (var b in a.instruments)
                        {
                            displayName.Add(b.displayName);
                        }
                    }
                    else
                    {
                        displayName.Add(" ");

                    }

                    submissionTime.Add(a.submissionTime);
                    versionId.Add(a.versionId);
                    link.Add(a.link);

                    if (a.linkedEvents != null)
                    {
                        foreach (var b in a.linkedEvents)

                        {
                            activityID.Add(b.activityID);
                        }

                    }
                    else
                    {
                        activityID.Add(" ");
                    }
                    if (a.sentNotifications != null)
                    {
                        foreach (var b in a.sentNotifications)
                        {
                            messageID.Add(b.messageID);
                            messageIssueTime.Add(b.messageIssueTime);
                            messageURL.Add(b.messageURL);
                        }

                    }


                    else
                    {
                        messageID.Add(" ");
                        messageIssueTime.Add(" ");
                        messageURL.Add(" ");
                    }
                }


            }
            else
            {
                rbeID.Add(" ");
                mpcID.Add(" ");
                sepID.Add(" ");
                eventTime.Add(" ");
                submissionTime.Add(" ");
                versionId.Add(0);
                link.Add(" ");
            }
            var collection_set = new Nasa_Set_Model06
            {
                RbeID = rbeID.Count > 0 ? rbeID[0] : null,
                MpcID = mpcID.Count > 0 ? mpcID[0] : null,
                SepID = sepID.Count > 0 ? sepID[0] : null,
                EventTime = eventTime.Count > 0 ? eventTime[0] : null,
                DisplayName = displayName.Count > 0 ? displayName[0] : null,
                SubmissionTime = submissionTime.Count > 0 ? submissionTime[0] : null,
                VersionId = versionId.Count > 0 ? versionId[0] : null,
                Link = link.Count > 0 ? link[0] : null,
                ActivityID = activityID.Count > 0 ? activityID[0] : null,
                MessageID = messageID.Count > 0 ? messageID[0] : null,
                MessageIssueTime = messageIssueTime.Count > 0 ? messageIssueTime[0] : null,
                MessageURL = messageURL.Count > 0 ? messageURL[0] : null,
            };
            collectiondata06.Add(collection_set);
            int minCount = new[]

            {

                                rbeID.Count,
            mpcID.Count,

            sepID.Count,
            eventTime.Count,
            displayName.Count,
            submissionTime.Count,
            versionId.Count,
            link.Count,
             activityID.Count,
             messageID.Count,
                 messageIssueTime.Count,
                  messageURL.Count,






        }.Min();

            for (var i = 0; i < minCount; i++)
            {
                data01[0] +=
                $"sepID: {rbeID[i]}\n" +
                $"sepID: {mpcID[i]}\n" +
                    $"sepID: {sepID[i]}\n" +
                $"eventTime: {eventTime[i]}\n" +
                 $"displayName: {displayName[i]}\n" +
                $"submissionTime: {submissionTime[i]}\n" +
                 $"versionId: {versionId[i]}\n" +
                 $"link: {link[i]}\n" +
                $"activityID: {activityID[i]}\n" +
                 $"messageID: {messageID[i]}\n" +
                $"messageIssueTime: {messageIssueTime[i]}\n" +
                 $"messageURL: {messageURL[i]}\n";


            }
            data01[3] = body;
            return data01[0];
        }
        private async Task<string> nasa_data07(string input)
        {
            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nasa_Model07.Root> results = JsonConvert.DeserializeObject<List<Nasa_Model07.Root>>(body);
            if (results != null)
            {
                foreach (var a in results)
                {
                    identifier.Add(a.identifier);
                    caption.Add(a.caption);
                    image.Add(a.image);
                    version.Add(a.version);
                    lat.Add(a.centroid_coordinates.lat);
                    lon.Add(a.centroid_coordinates.lon);
                    x.Add(a.dscovr_j2000_position.x);
                    y.Add(a.dscovr_j2000_position.y);
                    z.Add(a.dscovr_j2000_position.z);
                    x1.Add(a.lunar_j2000_position.x);
                    y1.Add(a.lunar_j2000_position.y);
                    z1.Add(a.lunar_j2000_position.z);
                    x2.Add(a.sun_j2000_position.x);
                    y2.Add(a.sun_j2000_position.y);
                    z2.Add(a.sun_j2000_position.z);
                    q0.Add(a.attitude_quaternions.q0);
                    q1.Add(a.attitude_quaternions.q1);
                    q2.Add(a.attitude_quaternions.q2);
                    q3.Add(a.attitude_quaternions.q3);
                    date1.Add(a.date);
                    x3.Add(a.coords.dscovr_j2000_position.x);
                    y3.Add(a.coords.dscovr_j2000_position.y);
                    z3.Add(a.coords.dscovr_j2000_position.z);
                    x2.Add(a.coords.lunar_j2000_position.x);
                    y2.Add(a.coords.lunar_j2000_position.y);
                    z2.Add(a.coords.lunar_j2000_position.z);
                    x3.Add(a.coords.sun_j2000_position.x);
                    y3.Add(a.coords.sun_j2000_position.y);
                    z3.Add(a.coords.sun_j2000_position.z);
                    q00.Add(a.coords.attitude_quaternions.q0);
                    q11.Add(a.coords.attitude_quaternions.q1);
                    q22.Add(a.coords.attitude_quaternions.q2);
                    q33.Add(a.coords.attitude_quaternions.q3);

                }
            }
            else
            {
                identifier.Add(" ");
                caption.Add(" ");
                image.Add(" ");
                version.Add(" ");
                lat.Add(0);
                lon.Add(0);
                x.Add(0);
                y.Add(0);
                z.Add(0);
                x1.Add(0);
                y1.Add(0);
                z1.Add(0);
                x2.Add(0);
                y2.Add(0);
                z2.Add(0);
                q0.Add(0);
                q1.Add(0);
                q2.Add(0);
                q3.Add(0);
                date1.Add("");
                x3.Add(0);
                y3.Add(0);
                z3.Add(0);
                x2.Add(0);
                y2.Add(0);
                z2.Add(0);
                x3.Add(0);
                y3.Add(0);
                z3.Add(0);
                q00.Add(0);
                q11.Add(0);
                q22.Add(0);
                q33.Add(0);

            }
            var collection_set = new Nasa_Set_Model07
            {

                Identifier = identifier.Count > 0 ? identifier[0] : null,
                Caption = caption.Count > 0 ? caption[0] : null,
                Image = image.Count > 0 ? image[0] : null,
                Version = version.Count > 0 ? version[0] : null,
                Lat = lat.Count > 0 ? lat[0] : 0,
                Lon = lon.Count > 0 ? lon[0] : 0,
                X = x.Count > 0 ? x[0] : 0,
                Y = y.Count > 0 ? y[0] : 0,
                Z = z.Count > 0 ? z[0] : 0,
                X1 = x1.Count > 0 ? x1[0] : 0,
                Y1 = y1.Count > 0 ? y1[0] : 0,
                Z1 = z1.Count > 0 ? z1[0] : 0,
                X2 = x2.Count > 0 ? x2[0] : 0,
                Y2 = y2.Count > 0 ? y2[0] : 0,
                Z2 = z2.Count > 0 ? z2[0] : 0,
                Q0 = q0.Count > 0 ? q0[0] : 0,
                Q1 = q1.Count > 0 ? q1[0] : 0,
                Q2 = q2.Count > 0 ? q2[0] : 0,
                Q3 = q3.Count > 0 ? q3[0] : 0,
                Date1 = date1.Count > 0 ? date1[0] : null,
                X3 = x3.Count > 0 ? x3[0] : 0,
                Y3 = y3.Count > 0 ? y3[0] : 0,
                Z3 = z3.Count > 0 ? z3[0] : 0,
                Q00 = q00.Count > 0 ? q00[0] : 0,
                Q11 = q11.Count > 0 ? q11[0] : 0,
                Q22 = q22.Count > 0 ? q22[0] : 0,
                Q33 = q33.Count > 0 ? q33[0] : 0,
            };
            collectiondata07.Add(collection_set);
            int minCount = new[]

            {

                   identifier.Count,
            caption.Count,
            image.Count,
            version.Count,
            lat.Count,
            lon.Count,
            x.Count,
            y.Count,
            z.Count,
            x1.Count,
            y1.Count,
            z1.Count,
            x2.Count,
            y2.Count,
            z2.Count,
            q0.Count,
            q1.Count,
            q2.Count,
            q3.Count,
            date1.Count,
            x3.Count,
            y3.Count,
            z3.Count,
            x2.Count,
            y2.Count,
            z2.Count,
            x3.Count,
            y3.Count,
            z3.Count,
            q00.Count,
            q11.Count,
            q22.Count,
            q33.Count
        }.Min();
            for (var i = 0; i < minCount; i++)
            {
                data01[0] +=
                        $"identifier: {identifier[i]}\n" +
                $"caption: {caption[i]}\n" +
               $"image: {image[i]}\n" +
            $"version: {version[i]}\n" +
            $"lat: {lat[i]}\n" +
            $"lon: {lon[i]}\n" +
            $"x: {x[i]}\n" +
            $"y: {y[i]}\n" +
            $"z: {z[i]}\n" +
            $"x1: {x1[i]}\n" +
            $"y1: {y1[i]}\n" +
            $"z1: {z1[i]}\n" +
            $"x2: {x2[i]}\n" +
            $"y2: {y2[i]}\n" +
            $"z2: {z2[i]}\n" +
            $"q0: {q0[i]}\n" +
            $"q1: {q1[i]}\n" +
            $"q2: {q2[i]}\n" +
            $"q3: {q3[i]}\n" +
            $"date: {date1[i]}\n" +
            $"x3: {x3[i]}\n" +
            $"y3: {y3[i]}\n" +
            $"z3: {z3[i]}\n" +
            $"x2: {x2[i]}\n" +
            $"y2: {y2[i]}\n" +
            $"z2: {z2[i]}\n" +
            $"x3: {x3[i]}\n" +
            $"y3: {y3[i]}\n" +
            $"z3: {z3[i]}\n" +
            $"q00: {q00[i]}\n" +
            $"q11: {q11[i]}\n" +
            $"q22: {q22[i]}\n" +
            $"q33: {q33[i]}\n";
            }



            return data01[0];
        }
        private async Task<string> nasa_data08(string input)
        {
            HttpResponseMessage response = await client.GetAsync(input);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            List<Nasa_Model08.Root> results = JsonConvert.DeserializeObject<List<Nasa_Model08.Root>>(body);











            return data01[0];
        }
    }

}