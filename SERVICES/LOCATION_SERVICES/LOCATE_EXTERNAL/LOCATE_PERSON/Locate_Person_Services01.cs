using E_APP02.MODEL.LOCATION_MODEL.LOCATION_GET_MODEL;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using Newtonsoft.Json;
//https://rapidapi.com/oneapiproject/api/skip-tracing-working-api/playground/apiendpoint_da93b236-ecf1-48a9-b2ea-f0cfd24bf38b`  

namespace E_APP02.SERVICES.LOCATION_SERVICES.LOCATE_EXTERNAL.LOCATE_PERSON
{
    internal class Locate_Person_Services01
    {
        private static string[] data01 = new string[100];
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        private static string[] Headers_array = {"x-rapidapi-key", READ.api[0].Trim(),
                                               "x-rapidapi-host", "skip-tracing-working-api.p.rapidapi.com"};
        private  List<int> Status = new List<int>();
        private  List<string> Message = new List<string>();
        private  List<string> Source = new List<string>();
        private  List<int> Records = new List<int>();
        private  List<int> Page = new List<int>();
        private  List<string> Name = new List<string>();
        private  List<string> Link = new List<string>();
        private  List<string> PersonID = new List<string>();
        private  List<object> Age = new List<object>();
        private  List<string> Livesin = new List<string>();
        private  List<string> Usedtolivein = new List<string>();
        private  List<string> Relatedto = new List<string>();
        private  List<string> Person_name = new List<string>();
        private  List<string> Age01 = new List<string>();
        private  List<string> Born = new List<string>();
        private  List<string> Telephone = new List<string>();
        private  List<string> street_address = new List<string>();
        private  List<string> address_locality = new List<string>();
        private  List<string> address_region = new List<string>();
        private  List<string> postal_code = new List<string>();
        private  List<string> county = new List<string>();
        private  List<string> date_range = new List<string>();
        private  List<string> phone_number = new List<string>();
        private  List<string> phone_type = new List<string>();
        private  List<string> last_reported = new List<string>();
        private  List<string> provider = new List<string>();
        private  List<string> EmailAddresses = new List<string>();
        private  List<string> streetAddress = new List<string>();
        private  List<string> addressLocality = new List<string>();
        private  List<string> addressRegion = new List<string>();
        private  List<string> postalCode = new List<string>();
        private  List<string> timespan = new List<string>();
        private  List<string> PersonLink = new List<string>();





        public string[] data_array = {"Full Name",//0
                                      "full address",//1
                                      "address",//2
                                      "Zip Code",//3
                                      "Phone Number",//4
                                      "Email",//5
                                      "Person ID",//6
        
        };
        public async Task<string> trace_by_name(string input)
        {
            //input= full name example John Doe
            data01[2] = await load_data01($"https://skip-tracing-working-api.p.rapidapi.com/search/byname?name={input}&page=1");
            return data01[2];
        }
        public async Task<string> trace_by_address(string input01, string input02)
        {
            //input01= street example 123 Main St
            //input02= citystatezip 75201

            data01[3] = await load_data01($"https://skip-tracing-working-api.p.rapidapi.com/search/byaddress?street={input01}&citystatezip={input02}page=1");
            return data01[3];
        }
        public async Task<string> trace_by_name_and_address(string input01, string input02)
        {
            //input01= full name example John Doe
            //input02= full address example 123 Main St, Dallas, TX 75201 exapmle
            data01[4] = await load_data01($"https://skip-tracing-working-api.p.rapidapi.com/search/bynameaddress?name={input01}&citystatezip={input02}page=1");
            return data01[4];
        }
        public async Task<string> trace_by_phone(string input)
        {
            //input= (214)349-3972 example
            data01[5] = await load_data01($"https://skip-tracing-working-api.p.rapidapi.com/search/byphone?phoneno={input}&page=1");
            return data01[5];
        }


        public async Task<string> trace_by_email(string input)
        {
            //input= email example
            data01[6] = await load_data02($"https://skip-tracing-working-api.p.rapidapi.com/search/byemail?email={input}&phone=1");
            return data01[6];
        }

        public async Task<string> personDetailsByID(string input)
        {
            //input= email example
            data01[7] = await load_data02($"https://skip-tracing-working-api.p.rapidapi.com/search/detailsbyID?peo_id={input}");
            return data01[7];
        }

        private async Task<string> load_data01(string input01)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{input01}"),
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
                Location_Model01.Root resaults = JsonConvert.DeserializeObject<Location_Model01.Root>(body);
                if (resaults != null)
                {
                    Status.Add(resaults.Status);
                    Message.Add(resaults.Message);
                    Source.Add(resaults.Source);
                    Records.Add(resaults.Records);
                    Page.Add(resaults.Page);
                    if (resaults.PeopleDetails != null)
                    {
                        foreach (var detail in resaults.PeopleDetails)
                        {
                            Name.Add(detail.Name);
                            Link.Add(detail.Link);
                            PersonID.Add(detail.PersonID);
                            Age.Add(detail.Age);
                            Livesin.Add(detail.Livesin);
                            Usedtolivein.Add(detail.Usedtolivein);
                            Relatedto.Add(detail.Relatedto);
                        }
                        data01[0] =
                            $"status: {string.Join("", Status)}\n" +
                            $"message: {string.Join("", Message)}\n" +
                            $"source: {string.Join("", Source)}\n" +
                            $"records: {string.Join("", Records)}\n" +
                            $"page: {string.Join("", Page)}\n" +
                            $"names: {string.Join(", ", Name)}\n" +
                            $"links: {string.Join(", ", Link)}\n" +
                            $"personIDs: {string.Join(", ", PersonID)}\n" +
                            $"ages: {string.Join(", ", Age)}\n" +
                            $"livesins: {string.Join(", ", Livesin)}\n" +
                            $"usedtoliveins: {string.Join(", ", Usedtolivein)}\n" +
                            $"relatedtos: {string.Join(", ", Relatedto)}\n";
                        return data01[0];
                    }
                    else
                    {
                        Name.Add("");
                        Link.Add("");
                        PersonID.Add("");
                        Age.Add("");
                        Livesin.Add("");
                        Usedtolivein.Add("");
                        Relatedto.Add("");
                    }

                }
                else
                {
                    Status.Add(0);
                    Message.Add("");
                    Source.Add("");
                    Records.Add(0);
                    Page.Add(0);

                }
                return data01[0];
            }
        }
        private async Task<string> load_data02(string input01)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{input01}"),
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
                Location_Model02.Root resaults = JsonConvert.DeserializeObject<Location_Model02.Root>(body);
                if (resaults != null)
                {
                    Status.Add(resaults.Status);
                    Message.Add(resaults.Message);
                    Source.Add(resaults.Source);
                    if (resaults.PersonDetails != null)
                    {
                        foreach (var a in resaults.PersonDetails)
                        {
                            Person_name.Add(a.Person_name);
                            Age01.Add(a.Age);
                            Born.Add(a.Born);
                            Livesin.Add(a.Livesin);
                            Telephone.Add(a.Telephone);
                        }

                    }
                    else
                    {
                        Person_name.Add("");
                        Age01.Add("");
                        Born.Add("");
                        Livesin.Add("");
                        Telephone.Add("");

                    }
                    if (resaults.CurrentAddressDetailsList != null)
                    {
                        foreach (var a in resaults.CurrentAddressDetailsList)
                        {
                            street_address.Add(a.street_address);
                            address_locality.Add(a.address_locality);
                            address_region.Add(a.address_region);
                            postal_code.Add(a.postal_code);
                            county.Add(a.county);
                            date_range.Add(a.date_range);
                        }
                    }
                    else
                    {
                        street_address.Add("");
                        address_locality.Add("");
                        address_region.Add("");
                        postal_code.Add("");
                        county.Add("");
                        date_range.Add("");
                    }
                    if (resaults.AllPhoneDetails != null)
                    {
                        foreach (var a in resaults.AllPhoneDetails)
                        {
                            phone_number.Add(a.phone_number);
                            phone_type.Add(a.phone_type);
                            last_reported.Add(a.last_reported);
                            provider.Add(a.provider);
                        }
                    }
                    else
                    {
                        phone_number.Add("");
                        phone_type.Add("");
                        last_reported.Add("");
                        provider.Add("");
                    }
                    if (resaults.EmailAddresses != null)
                    {
                        foreach (var a in resaults.EmailAddresses)
                        {
                            EmailAddresses.Add(a);
                        }
                    }
                    else
                    {
                        EmailAddresses.Add("");
                    }
                    if (resaults.PreviousAddressDetails != null)
                    {
                        foreach (var a in resaults.PreviousAddressDetails)
                        {
                            streetAddress.Add(a.streetAddress);
                            addressLocality.Add(a.addressLocality);
                            addressRegion.Add(a.addressRegion);
                            postalCode.Add(a.postalCode);
                            county.Add(a.county);
                            timespan.Add(a.timespan);
                        }
                    }
                    else
                    {
                        streetAddress.Add("");
                        addressLocality.Add("");
                        addressRegion.Add("");
                        postalCode.Add("");
                        county.Add("");
                        timespan.Add("");

                    }
                    if(resaults.AllRelatives!=null)
                    {
                       foreach(var a in resaults.AllRelatives)
                        {
                            Name.Add(a.Name);   
                            Age.Add(a.Age);
                            PersonLink.Add(a.PersonLink);
                            PersonID.Add(a.PersonID);

                        }
                    }
                    else
                    {
                        Name.Add("");   
                        Age.Add("");
                        PersonLink.Add("");
                        PersonID.Add("");
                    }
                    if (resaults.AllAssociates != null)
                    {
                        foreach (var a in resaults.AllAssociates)
                        {
                            Name.Add(a.Name);
                            Age.Add(a.Age);
                            PersonLink.Add(a.PersonLink);
                            PersonID.Add(a.PersonID);
                        }

                    }
                    else
                    {
                        Name.Add("");
                        Age.Add("");
                        PersonLink.Add("");
                        PersonID.Add("");
                    }
                }
                else
                {
                    Status.Add(0);
                    Message.Add("");
                    Source.Add("");
                }
                data01[1] +=
                    $"Status: {string.Join("",Status)} \n"+
                    $"Message: {string.Join("",Message)} \n" +
                    $"Source: {string.Join("",Source)} \n" +
                    $"Person_name: {string.Join(", ", Person_name)} \n" +
                    $"Age01: {string.Join(", ", Age01)} \n" +
                    $"Born: {string.Join(", ", Born)} \n" +
                    $"Livesin: {string.Join(", ", Livesin)} \n" +
                    $"Telephone: {string.Join(", ", Telephone)} \n" +
                    $"street_address: {string.Join(", ", street_address)} \n" +
                    $"address_locality: {string.Join(", ", address_locality)} \n" +
                    $"address_region: {string.Join(", ", address_region)} \n" +
                    $"postal_code: {string.Join(", ", postal_code)} \n" +
                    $"county: {string.Join(", ", county)} \n" +
                    $"date_range: {string.Join(", ", date_range)} \n" +
                    $"phone_number: {string.Join(", ", phone_number)} \n" +
                    $"phone_type: {string.Join(", ", phone_type)} \n" +
                    $"last_reported: {string.Join(", ", last_reported)} \n" +
                    $"provider: {string.Join(", ", provider)} \n" +
                    $"EmailAddresses: {string.Join(", ", EmailAddresses)} \n" +
                    $"streetAddress: {string.Join(", ", streetAddress)} \n" +
                    $"addressLocality: {string.Join(", ", addressLocality)} \n" +
                    $"addressRegion: {string.Join(", ", addressRegion)} \n" +
                    $"postalCode: {string.Join(", ", postalCode)} \n" +
                    $"timespan: {string.Join(", ", timespan)} \n" +
                    $"Relative Names: {string.Join(", ", Name)} \n" +
                    $"Relative Ages: {string.Join(", ", Age)} \n" +
                    $"Relative PersonLinks: {string.Join(", ", PersonLink)} \n" +
                    $"Relative PersonIDs: {string.Join(", ", PersonID)} \n" +
                    $"Associate Names: {string.Join(", ", Name)} \n" +
                    $"Associate Ages: {string.Join(", ", Age)} \n" +
                    $"Associate PersonLinks: {string.Join(", ", PersonLink)} \n" +
                    $"Associate PersonIDs: {string.Join(", ", PersonID)} \n";

                return data01[1];
            }
        }
    }
}



