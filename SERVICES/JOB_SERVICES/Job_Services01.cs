using E_APP02.MODELS.JOB_MODEL.JOB_GET_MODEL;
using E_APP02.MODELS.JOB_MODEL.JOB_SET_MODEL;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using Newtonsoft.Json;


//https://rapidapi.com/letscrape-6bRBa3QguO5/api/jsearch/playground/endpoint_73845d59-2a15-4a88-92c5-e9b1bc90956d

namespace E_APP02.SERVICES.JOB_SERVICES
{
    internal class Job_Services01
    {
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        private static readonly HttpClient client = new HttpClient();
        private  List<string> status = new List<string>();
        private  List<string> request_id = new List<string>();
        private  List<string> query = new List<string>();
        private  List<int> page = new List<int>();
        private  List<int> num_pages = new List<int>();
        private  List<string> date_posted = new List<string>();
        private  List<string> country = new List<string>();
        private  List<string> language = new List<string>();
        private  List<string> job_id = new List<string>();
        private  List<string> job_title = new List<string>();
        private  List<string> employer_name = new List<string>();
        private  List<string> employer_logo = new List<string>();
        private  List<string> employer_website = new List<string>();
        private  List<string> job_publisher = new List<string>();
        private  List<string> job_employment_type = new List<string>();
        private  List<string> job_employment_types = new List<string>();
        private  List<string> job_apply_link = new List<string>();
        private  List<bool> job_apply_is_direct = new List<bool>();
        private  List<string> publisher = new List<string>();
        private  List<string> apply_link = new List<string>();
        private  List<bool> is_direct = new List<bool>();
        private  List<string> job_description = new List<string>();
        private  List<bool?> job_is_remote = new List<bool?>();
        private  List<string> job_posted_at = new List<string>();
        private  List<int?> job_posted_at_timestamp = new List<int?>();
        private  List<DateTime?> job_posted_at_datetime_utc = new List<DateTime?>();
        private  List<string> job_location = new List<string>();
        private  List<string> job_city = new List<string>();
        private  List<string> job_state = new List<string>();
        private  List<string> job_country = new List<string>();
        private  List<double?> job_latitude = new List<double?>();
        private  List<double?> job_longitude = new List<double?>();
        private  List<string> job_benefits = new List<string>();
        private  List<string> job_google_link = new List<string>();
        private  List<double?> job_min_salary = new List<double?>();
        private  List<double?> job_max_salary = new List<double?>();
        private  List<string> job_salary_period = new List<string>();
        private  List<string> Qualifications = new List<string>();
        private  List<string> Benefits = new List<string>();
        private  List<string> Responsibilities = new List<string>();
        private  List<string> job_onet_soc = new List<string>();
        private  List<string> job_onet_job_zone = new List<string>();
        private  List<object> job_salary = new List<object>();
        public List<Job_Set_Model01> collectiondata01 = new List<Job_Set_Model01>();
        private  string[] Headers_array = {"x-rapidapi-key", READ.api[0].Trim(),
                                                 "x-rapidapi-host", "jsearch.p.rapidapi.com"};
        private string[] data01 = new string[100];
        public string[] data_array = { "search job",//0
                                        "job details",//1
                                        "job salary",//2
                                        "find company for position",//3
                                        "find salary from company",//4
                                        "Job Title",//5
                                        "job City",//6
                                        "Company Name"//7
     };

        public async Task<string> Job_Search(string input)
        {
            data01[2] = await job_data01($"https://jsearch.p.rapidapi.com/search?query={input}&page=1&num_pages=1&country=us&date_posted=all");
            data01[3] = await Job_Details(job_id.FirstOrDefault().Trim());

            return $"{data01[2]}\n" +
                    $"{data01[3]}\n";
    
        }

        private async Task<string> Job_Details(string input)
        {
      

            data01[4] = await job_data01($"https://jsearch.p.rapidapi.com/job-details?job_id={input.Trim()}&country=us");
            return data01[4];
        }

        public async Task<string> Job_Salary(string[] input)
        {
            //input[0] = job title  
            //input[1] = location
            data01[5] =await job_data01($"https://jsearch.p.rapidapi.com/estimated-salary?job_title={input[0].Trim()}&location={input[1].Trim()}location_type=ANY&years_of_experience=ALL");
            return data01[5];
        }
        public async Task<string> Company_Job_Salary(string[] input)
        {
            //input[0] = company name
            //input[1] = job title
            data01[6] = await job_data01($"https://jsearch.p.rapidapi.com/company-job-salary?company={input[0]}&job_title={input[1]}&location_type=ANY&years_of_experience=ALL");
            return data01[6];
        }
        private async Task<string> job_data01(string input)
        {

      
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
    {
        { Headers_array[0], Headers_array[1]},
        { Headers_array[2],Headers_array[3] },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Job_Model01.Root resaults = JsonConvert.DeserializeObject<Job_Model01.Root>(body);
                if (resaults != null)
                {
                    status.Add(resaults.status);
                    request_id.Add(resaults.request_id);

                    if (resaults.parameters != null)
                    {
                        query.Add(resaults.parameters.query ?? "");
                        page.Add(resaults.parameters.page);
                        num_pages.Add(resaults.parameters.num_pages);
                        date_posted.Add(resaults.parameters.date_posted ?? "");
                        country.Add(resaults.parameters.country ?? "");
                        language.Add(resaults.parameters.language ?? "");
                    }
                    else
                    {
                        query.Add("");
                        page.Add(0);
                        num_pages.Add(0);
                        date_posted.Add("");
                        country.Add("");
                        language.Add("");
                    }
                    if (resaults.data != null)
                    {
                        foreach (var a in resaults.data)
                        {
                            job_id.Add(a.job_id);
                            job_title.Add(a.job_title);
                            employer_name.Add(a.employer_name);
                            employer_logo.Add(a.employer_logo);
                            employer_website.Add(a.employer_website);
                            job_publisher.Add(a.job_publisher);
                            job_employment_type.Add(a.job_employment_type);
                            if (a.job_employment_types != null)
                            {
                                foreach (var b in a.job_employment_types)
                                {
                                    job_employment_types.Add(b);
                                }
                            }
                            else
                            {
                                job_employment_types.Add("");
                            }

                            job_apply_link.Add(a.job_employment_type);
                            job_apply_is_direct.Add(a.job_apply_is_direct);
                            if (a.apply_options != null)
                            {
                                foreach (var b in a.apply_options)
                                {
                                    publisher.Add(b.publisher);
                                    apply_link.Add(b.apply_link);
                                    is_direct.Add(b.is_direct);
                                }
                            }
                            else
                            {
                                publisher.Add("");
                                apply_link.Add("");
                                is_direct.Add(false);
                            }
                            job_description.Add(a.job_description);
                            job_is_remote.Add(a.job_is_remote);
                            job_posted_at.Add(a.job_posted_at);
                            job_onet_job_zone.Add(a.job_onet_job_zone);
                            job_posted_at_timestamp.Add(a.job_posted_at_timestamp);
                            job_posted_at_datetime_utc.Add(a.job_posted_at_datetime_utc);
                            job_location.Add(a.job_location);
                            job_city.Add(a.job_city);
                            job_state.Add(a.job_state);
                            job_country.Add(a.job_country);
                            job_latitude.Add(a.job_latitude);
                            job_longitude.Add(a.job_longitude);
                            if (a.job_benefits != null)
                            {
                                foreach (var b in a.job_benefits)
                                {
                                    job_benefits.Add(b);
                                }
                            }
                            else
                            {
                                job_benefits.Add(" ");
                            }
                            job_google_link.Add(a.job_google_link);
                            job_min_salary.Add(a.job_min_salary);
                            job_max_salary.Add(a.job_max_salary);
                            job_salary_period.Add(a.job_salary_period);
                            if (a.job_highlights.Qualifications != null)
                            {
                                foreach (var b in a.job_highlights.Qualifications)
                                {
                                    Qualifications.Add(b);
                                }

                            }
                            else
                            {
                                Qualifications.Add("");
                            }
                            if (a.job_highlights.Benefits != null)
                            {
                                foreach (var b in a.job_highlights.Benefits)
                                {
                                    Benefits.Add(b);
                                }

                            }
                            else
                            {
                                Benefits.Add("");

                            }
                            if (a.job_highlights.Responsibilities != null)
                            {
                                foreach (var b in a.job_highlights.Responsibilities)
                                {
                                    Responsibilities.Add(b);
                                }
                            }
                            else
                            {
                                Responsibilities.Add("");

                            }
                            job_onet_soc.Add(a.job_onet_soc);
                            job_onet_job_zone.Add(a.job_onet_job_zone);
                            job_salary.Add(a.job_salary);
                        }
                    }
                    else
                    {
                        job_id.Add("");
                        job_title.Add("");
                        employer_name.Add("");
                        employer_logo.Add("");
                        employer_website.Add("");
                        job_publisher.Add("");
                        job_employment_type.Add("");
                        job_apply_link.Add("");
                        job_apply_is_direct.Add(false);
                        job_description.Add("");
                        job_is_remote.Add(false);
                        job_posted_at.Add("");
                        job_posted_at_timestamp.Add(null);
                        job_posted_at_datetime_utc.Add(null);
                        job_location.Add("");
                        job_city.Add("");
                        job_state.Add("");
                        job_country.Add("");
                        job_latitude.Add(0);
                        job_longitude.Add(0);
                        job_google_link.Add("");
                        job_min_salary.Add(null);
                        job_max_salary.Add(0);
                        job_salary_period.Add("");
                        job_onet_soc.Add("");
                        job_onet_job_zone.Add("");
                        job_salary.Add("");
                    }
                }
                else
                {
                    status.Add("");
                    request_id.Add("");
                    query.Add("");
                    page.Add(0);
                    num_pages.Add(0);
                    date_posted.Add("");
                    country.Add("");
                    language.Add("");
                }

                var collection_set = new Job_Set_Model01
                {
                    status = status.Count > 0 ? status[0] : null,
                    request_id = request_id.Count > 0 ? request_id[0] : null,
                    query = query.Count > 0 ? query[0] : null,
                    page = page.Count > 0 ? page[0] : 0,
                    num_pages = num_pages.Count > 0 ? num_pages[0] : 0,
                    date_posted = date_posted.Count > 0 ? date_posted[0] : null,
                    country = country.Count > 0 ? country[0] : null,
                    language = language.Count > 0 ? language[0] : null,
                    job_id = job_id.Count > 0 ? job_id[0] : null,
                    job_title = job_title.Count > 0 ? job_title[0] : null,
                    employer_name = employer_name.Count > 0 ? employer_name[0] : null,
                    employer_logo = employer_logo.Count > 0 ? employer_logo[0] : null,
                    employer_website = employer_website.Count > 0 ? employer_website[0] : null,
                    job_publisher = job_publisher.Count > 0 ? job_publisher[0] : null,
                    job_employment_type = job_employment_type.Count > 0 ? job_employment_type[0] : null,
                    job_employment_types = job_employment_types.Count > 0 ? job_employment_types[0] : null,
                    job_apply_link = job_apply_link.Count > 0 ? job_apply_link[0] : null,
                    job_apply_is_direct = job_apply_is_direct.Count > 0 ? job_apply_is_direct[0] : false,
                    publisher = publisher.Count > 0 ? publisher[0] : null,
                    apply_link = apply_link.Count > 0 ? apply_link[0] : null,
                    is_direct = is_direct.Count > 0 ? is_direct[0] : false,
                    job_description = job_description.Count > 0 ? job_description[0] : null,
                    job_is_remote = job_is_remote.Count > 0 ? job_is_remote[0] : false,
                    job_posted_at = job_posted_at.Count > 0 ? job_posted_at[0] : null,
                    job_posted_at_timestamp = job_posted_at_timestamp.Count > 0 ? job_posted_at_timestamp[0] : null,
                    job_posted_at_datetime_utc = job_posted_at_datetime_utc.Count > 0 ? job_posted_at_datetime_utc[0] : null,
                    job_location = job_location.Count > 0 ? job_location[0] : null,
                    job_city = job_city.Count > 0 ? job_city[0] : null,
                    job_state = job_state.Count > 0 ? job_state[0] : null,
                    job_country = job_country.Count > 0 ? job_country[0] : null,
                    job_latitude = job_latitude.Count > 0 ? job_latitude[0] : 0,
                    job_longitude = job_longitude.Count > 0 ? job_longitude[0] : 0,
                    job_benefits = job_benefits.Count > 0 ? job_benefits[0] : null,
                    job_google_link = job_google_link.Count > 0 ? job_google_link[0] : null,
                    job_min_salary = job_min_salary.Count > 0 ? job_min_salary[0] : null,
                    job_max_salary = job_max_salary.Count > 0 ? job_max_salary[0] : null,
                    job_salary_period = job_salary_period.Count > 0 ? job_salary_period[0] : null,
                    Qualifications = Qualifications.Count > 0 ? Qualifications[0] : null,
                    Benefits = Benefits.Count > 0 ? Benefits[0] : null,
                    Responsibilities = Responsibilities.Count > 0 ? Responsibilities[0] : null,
                    job_onet_soc = job_onet_soc.Count > 0 ? job_onet_soc[0] : null,
                    job_onet_job_zone = job_onet_job_zone.Count > 0 ? job_onet_job_zone[0] : null,
                    job_salary = job_salary.Count > 0 ? job_salary[0] : null,
                };
                //         collectiondata01.Add(collection_set);

                data01[0] +=
                    $"{string.Join(" ", status)}\n" +
                    $"{string.Join(" ", request_id)}\n" +
                    $"{string.Join(" ", query)}\n" +
                    $"{string.Join(" ", page)}\n" +
                    $"{string.Join(" ", num_pages)}\n" +
                    $"{string.Join(" ", date_posted)}\n" +
                    $"{string.Join(" ", country)}\n" +
                    $"{string.Join(" ", language)}\n" +
                    $"{string.Join(" ", job_id)}\n" +
                    $"{string.Join(" ", job_title)}\n" +
                    $"{string.Join(" ", employer_name)}\n" +
                    $"{string.Join(" ", employer_logo)}\n" +
                    $"{string.Join(" ", employer_website)}\n" +
                    $"{string.Join(" ", job_publisher)}\n" +
                    $"{string.Join(" ", job_employment_type)}\n" +
                    $"{string.Join(" ", job_employment_types)}\n" +
                    $"{string.Join(" ", job_apply_link)}\n" +
                    $"{string.Join(" ", job_apply_is_direct)}\n" +
                    $"{string.Join(" ", publisher)}\n" +
                    $"{string.Join(" ", apply_link)}\n" +
                    $"{string.Join(" ", is_direct)}\n" +
                    $"{string.Join(" ", job_description)}\n" +
                    $"{string.Join(" ", job_is_remote)}\n" +
                    $"{string.Join(" ", job_posted_at)}\n" +
                    $"{string.Join(" ", job_posted_at_timestamp)}\n" +
                    $"{string.Join(" ", job_posted_at_datetime_utc)}\n" +
                    $"{string.Join(" ", job_location)}\n" +
                    $"{string.Join(" ", job_city)}\n" +
                    $"{string.Join(" ", job_state)}\n" +
                    $"{string.Join(" ", job_country)}\n" +
                    $"{string.Join(" ", job_latitude)}\n" +
                    $"{string.Join(" ", job_longitude)}\n" +
                    $"{string.Join(" ", job_benefits)}\n" +
                    $"{string.Join(" ", job_google_link)}\n" +
                    $"{string.Join(" ", job_min_salary)}\n" +
                    $"{string.Join(" ", job_max_salary)}\n" +
                    $"{string.Join(" ", job_salary_period)}\n" +
                    $"{string.Join(" ", Qualifications)}\n" +
                    $"{string.Join(" ", Benefits)}\n" +
                    $"{string.Join(" ", Responsibilities)}\n" +
                    $"{string.Join(" ", job_onet_soc)}\n" +
                    $"{string.Join(" ", job_onet_job_zone)}\n" +
                    $"{string.Join(" ", job_salary)}\n";
    
                int minCount = new[]
                         {
                  status.Count,
                  request_id.Count,
                  query.Count,
                  page.Count,
                  num_pages.Count,
                  date_posted.Count,
                  country.Count,
                  language.Count,
                  job_id.Count,
                  job_title.Count,
                  employer_name.Count,
                  employer_logo.Count,
                  employer_website.Count,
                  job_publisher.Count,
                  job_employment_type.Count,
                  job_employment_types.Count,
                  job_apply_link.Count,
                  job_apply_is_direct.Count,
                  publisher.Count,
                  apply_link.Count,
                  is_direct.Count,
                  job_description.Count,
                  job_is_remote.Count,
                  job_posted_at.Count,
                  job_posted_at_timestamp.Count,
                  job_posted_at_datetime_utc.Count,
                  job_location.Count,
                  job_city.Count,
                  job_state.Count,
                  job_country.Count,
                  job_latitude.Count,
                  job_longitude.Count,
                  job_benefits.Count,
                  job_google_link.Count,
                  job_min_salary.Count,
                  job_max_salary.Count,
                  job_salary_period.Count,
                  Qualifications.Count,
                  Benefits.Count,
                  Responsibilities.Count,
                  job_onet_soc.Count,
                  job_onet_job_zone.Count,
                  job_salary.Count,
            }.Min();
                for (int i = 0; i < minCount; i++)
                {
                    data01[1] +=
                                 $"status: {status[i]}\n" +
                                 $"request_id: {request_id[i]}\n" +
                                 $"query: {query[i]}\n" +
                                 $"page: {page[i]}\n" +
                                 $"num_pages: {num_pages[i]}\n" +
                                 $"date_posted: {date_posted[i]}\n" +
                                 $"country: {country[i]}\n" +
                                 $"language: {language[i]}\n" +
                                 $"job_id: {job_id[i]}\n" +
                                 $"job_title: {job_title[i]}\n" +
                                 $"employer_name: {employer_name[i]}\n" +
                                 $"employer_logo: {employer_logo[i]}\n" +
                                 $"employer_website: {employer_website[i]}\n" +
                                 $"job_publisher: {job_publisher[i]}\n" +
                                 $"job_employment_type: {job_employment_type[i]}\n" +
                                 $"job_employment_types: {job_employment_types[i]}\n" +
                                 $"job_apply_link: {job_apply_link[i]}\n" +
                                 $"job_apply_is_direct: {job_apply_is_direct[i]}\n" +
                                 $"publisher: {publisher[i]}\n" +
                                 $"apply_link: {apply_link[i]}\n" +
                                 $"is_direct: {is_direct[i]}\n" +
                                 $"job_description: {job_description[i]}\n" +
                                 $"job_is_remote: {job_is_remote[i]}\n" +
                                 $"job_posted_at: {job_posted_at[i]}\n" +
                                 $"job_posted_at_timestamp: {job_posted_at_timestamp[i]}\n" +
                                 $"job_posted_at_datetime_utc: {job_posted_at_datetime_utc[i]}\n" +
                                 $"job_location: {job_location[i]}\n" +
                                 $"job_city: {job_city[i]}\n" +
                                 $"job_state: {job_state[i]}\n" +
                                 $"job_country: {job_country[i]}\n" +
                                 $"job_latitude: {job_latitude[i]}\n" +
                                 $"job_longitude: {job_longitude[i]}\n" +
                                 $"job_benefits: {job_benefits[i]}\n" +
                                 $"job_google_link: {job_google_link[i]}\n" +
                                 $"job_min_salary: {job_min_salary[i]}\n" +
                                 $"job_max_salary: {job_max_salary[i]}\n" +
                                 $"job_salary_period: {job_salary_period[i]}\n" +
                                 $"Qualifications: {Qualifications[i]}\n" +
                                 $"Benefits: {Benefits[i]}\n" +
                                 $"Responsibilities: {Responsibilities[i]}\n" +
                                 $"job_onet_soc: {job_onet_soc[i]}\n" +
                                 $"job_onet_job_zone: {job_onet_job_zone[i]}\n" +
                                 $"job_salary: {job_salary[i]}\n";

                }

                return  $"{data01[1]}\n";
            }
        }
    }
}