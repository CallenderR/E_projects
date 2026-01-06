using E_APP02.MODELS.NEWS_MODEL.NEWS_GET_MODEL;
using E_APP02.MODELS.NEWS_MODEL.NEWS_SET_MODEL;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using E_APP02.SERVICES.LANGUAGE_SERVICES;
using Newtonsoft.Json;
//https://rapidapi.com/letscrape-6bRBa3QguO5/api/real-time-news-data/playground/apiendpoint_a03c0486-3abf-4ce1-b5eb-d27128e91395
//needs to orginize this class better 
namespace E_APP02.SERVICES.NEWS_SERVICES
{
    internal class News_Services01
    {
        private static string[] data01 = new string[3];
        private  List<string> status = new List<string>();
        private  List<string> request_id = new List<string>();
        private List<string> title = new List<string>();
        private  List<string> link = new List<string>();
        private  List<string> snippet = new List<string>();
        private  List<string> photo_url = new List<string>();
        private  List<string> thumbnail_url = new List<string>();
        private  List<DateTime?> published_datetime_utc = new List<DateTime?>();
        private  List<string> authors = new List<string>();
        private  List<string> source_url = new List<string>();
        private  List<string> source_name = new List<string>();
        private  List<string> source_logo_url = new List<string>();
        private  List<string> source_favicon_url = new List<string>();
        private  List<string> source_publication_id = new List<string>();
        private  List<string> topic_id = new List<string>();
        private  List<string> topic_name = new List<string>();
        private  List<string> story_id = new List<string>();
        private  List<string> post_id = new List<string>();
        private  List<object> photo = new List<object>();
        private  List<string> post_author_username = new List<string>();
        private  List<string> post_author_picture = new List<string>();
        private  List<DateTime> post_datetime_utc = new List<DateTime>();
        private  List<string> name = new List<string>();
        private  List<string> lang = new List<string>();
        public List<News_Set_Model01> NewsItems01 = new List<News_Set_Model01>();
        public List<News_Set_Model02> NewsItems02 = new List<News_Set_Model02>();
        public List<News_Set_Model03> NewsItems03 = new List<News_Set_Model03>();
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        private static string[] Headers_ ={ "x-rapidapi-key",READ.api[0].Trim(),
         "x-rapidapi-host", "real-time-news-data.p.rapidapi.com" };
        public string[] data_array = {"City Name", //0
                                      "Search Topic"//1
     
        };

        private static Language_Services01 Language_Serv01=new Language_Services01();
        public async Task<string> Real_Time_News_Data_GET_Search(string input)
        {


            data01[2] = await news_data01($"https://real-time-news-data.p.rapidapi.com/search?query={input.Trim()}&limit=10&time_published=anytime&country=US&lang=en");
            return data01[2];
        }
        public async Task<string> Real_Time_News_Data_GET_Top_Headlines()
        {

            data01[1] = await news_data02($"https://real-time-news-data.p.rapidapi.com/top-headlines?limit=500&country=US&lang=en");
            return data01[1];
        }
        public async Task<string> Real_Time_News_Data_GET_Topic_Headlines()
        {

            data01[1] = await news_data02($"https://real-time-news-data.p.rapidapi.com/topic-headlines?topic=WORLD&limit=500&country=US&lang=en");
            return data01[1];
        }
        public async Task<string> Real_Time_News_Data_GET_Topic_News_By_Section(string input)
        {

            data01[1] = await news_data02($"https://real-time-news-data.p.rapidapi.com/topic-news-by-section?topic={input.Trim()}&section=CAQiSkNCQVNNUW9JTDIwdk1EZGpNWFlTQldWdUxVZENHZ0pKVENJT0NBUWFDZ29JTDIwdk1ETnliSFFxQ2hJSUwyMHZNRE55YkhRb0FBKi4IACoqCAoiJENCQVNGUW9JTDIwdk1EZGpNWFlTQldWdUxVZENHZ0pKVENnQVABUAE&limit=500&country=US&lang=en");
            return data01[1];
        }
        public async Task<string> Local_Headlines_Geo(string input)
        {
            //city

            data01[2] = await news_data01($"https://real-time-news-data.p.rapidapi.com/local-headlines?query={input.Trim()}&country=US&lang=en&limit=500");
            return data01[2];
        }
        public async Task<string> Full_Story_Coverage()
        {

            data01[2] = await news_data03($"https://real-time-news-data.p.rapidapi.com/full-story-coverage?story=CAAqNggKIjBDQklTSGpvSmMzUnZjbmt0TXpZd1NoRUtEd2pzbFA3X0N4RjlDUlpVVnhudXBpZ0FQAQ&sort=RELEVANCE&country=US&lang=en");
            return data01[2];
        }
        public async Task<string> Real_Time_News_Data_GET_Language_List()
        {

            data01[1] = await news_data04($"https://real-time-news-data.p.rapidapi.com/language-list?country=US");
            return data01[1];
        }

        private async Task<string> news_data01(string input)
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
                News_Model01.Root results = JsonConvert.DeserializeObject<News_Model01.Root>(body);
                status.Add(results.status);
                request_id.Add(results.request_id);
                foreach (var item in results.data)
                {
                    title.Add(item.title);
                    link.Add(item.link);
                    snippet.Add(item.snippet);
                    photo_url.Add(item.photo_url);
                    thumbnail_url.Add(item.thumbnail_url);
                    published_datetime_utc.Add(item.published_datetime_utc);
                    authors.Add(string.Join(", ", item.authors));
                    source_url.Add(item.source_url);
                    source_name.Add(item.source_name);
                    source_logo_url.Add(item.source_logo_url);
                    source_favicon_url.Add(item.source_favicon_url);
                    source_publication_id.Add(item.source_publication_id);
                    foreach (var topic in item.related_topics)
                    {
                        topic_id.Add(topic.topic_id);
                        topic_name.Add(topic.topic_name);
                    }
                }
                for (int i = 0; i < status.Count; i++)
                {
                    data01[0] += $"status: {status[i]}\n" +
                                 $"request_id: {request_id[i]}\n" +
                                 $"title: {title[i]}\n" +
                                 $"link: {link[i]}\n" +
                                 $"snippet: {snippet[i]}\n" +
                                 $"photo_url: {photo_url[i]}\n" +
                                 $"thumbnail_url: {thumbnail_url[i]}\n" +
                                 $"published_datetime_utc: {published_datetime_utc[i]}\n" +
                                 $"authors: {authors[i]}\n" +
                                 $"source_url: {source_url[i]}\n" +
                                 $"source_name: {source_name[i]}\n" +
                                 $"source_logo_url: {source_logo_url[i]}\n" +
                                 $"source_favicon_url: {source_favicon_url[i]}\n" +
                                 $"source_publication_id: {source_publication_id[i]}\n" +
                                 $"topic_id: {topic_id[i]}\n" +
                                 $"topic_name: {topic_name[i]}\n";

                }
                foreach (var item in results.data)
                {
                    var newsItem = new News_Set_Model01
                    {

                        Title = item.title,
                        Link = item.link,
                        Snippet = item.snippet,
                        PhotoUrl = item.photo_url,
                        ThumbnailUrl = item.thumbnail_url,
                        PublishedDateUtc = string.Join(", ", item.published_datetime_utc),
                        Authors = string.Join(", ", item.authors),
                        SourceUrl = item.source_url,
                        SourceName = item.source_name,
                        SourceLogoUrl = item.source_url,
                        SourceFaviconUrl = item.source_favicon_url,
                        SourcePublicationId = item.source_publication_id,
                    };
                    NewsItems01.Add(newsItem);
                }




                data01[1] += $"{string.Join(" ", status)}\n" +
                   $"{string.Join(" ", request_id)}\n" +
                   $"{string.Join(" ", title)}\n" +
                   $"{string.Join(" ", link)}\n" +
                   $"{string.Join(" ", snippet)}\n" +
                   $"{string.Join(" ", photo_url)}\n" +
                   $"{string.Join(" ", thumbnail_url)}\n" +
                   $"{string.Join(" ", published_datetime_utc)}\n" +
                   $"{string.Join(" ", authors)}\n" +
                   $"{string.Join(" ", source_url)}\n" +
                   $"{string.Join(" ", source_name)}\n" +
                   $"{string.Join(" ", source_logo_url)}\n" +
                   $"{string.Join(" ", source_favicon_url)}\n" +
                   $"{string.Join(" ", source_publication_id)}\n" +
                   $"{string.Join(" ", topic_id)}\n" +
                   $"{string.Join(" ", topic_name)}\n";

                return data01[1];
            }
        }
        private async Task<string> news_data02(string input)
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
                News_Model02.Root results = JsonConvert.DeserializeObject<News_Model02.Root>(body);
                if (results != null)
                {
                    status.Add(results.status);
                    request_id.Add(results.request_id);
                    if (results.data != null)
                    {
                        foreach (var item in results.data)
                        {
                            title.Add(item.title);
                            link.Add(item.link);
                            snippet.Add(item.snippet);
                            photo_url.Add(item.photo_url);
                            thumbnail_url.Add(item.thumbnail_url);
                            published_datetime_utc.Add(item.published_datetime_utc);
                            authors.Add(string.Join(", ", item.authors));
                            source_url.Add(item.source_url);
                            source_name.Add(item.source_name);
                            source_logo_url.Add(item.source_logo_url);
                            source_favicon_url.Add(item.source_favicon_url);
                            source_publication_id.Add(item.source_publication_id);
                            story_id.Add(item.story_id);
                            if (item.related_topics != null)
                            {
                                foreach (var topic in item.related_topics)
                                {
                                    topic_id.Add(topic.topic_id);
                                    topic_name.Add(topic.topic_name);
                                    if (item.sub_articles != null)
                                    {
                                        foreach (var sub in item.sub_articles)
                                        {
                                            title.Add(sub.title);
                                            link.Add(sub.link);
                                            photo_url.Add(sub.photo_url);
                                            thumbnail_url.Add(sub.thumbnail_url);
                                            published_datetime_utc.Add(sub.published_datetime_utc);
                                            authors.Add(string.Join(", ", sub.authors));
                                            source_url.Add(sub.source_url);
                                            source_name.Add(sub.source_name);
                                            source_logo_url.Add(sub.source_logo_url);
                                            source_favicon_url.Add(sub.source_favicon_url);
                                            source_publication_id.Add(sub.source_publication_id);
                                        }
                                    }
                                    else
                                    {
                                        title.Add(" ");
                                        link.Add(" ");
                                        photo_url.Add(" ");
                                        thumbnail_url.Add(" ");
                                        published_datetime_utc.Add(null);
                                        authors.Add(" ");
                                        source_url.Add(" ");
                                        source_name.Add(" ");
                                        source_logo_url.Add(" ");
                                        source_favicon_url.Add(" ");
                                        source_publication_id.Add(" ");
                                    }
                                }
                            }

                            else
                            {
                                topic_id.Add(" ");
                                topic_name.Add(" ");
                            }



                        }
                    }
                    else
                    {
                        title.Add(" ");
                        link.Add(" ");
                        snippet.Add(" ");
                        photo_url.Add(" ");
                        thumbnail_url.Add(" ");
                        published_datetime_utc.Add(null);
                        authors.Add(" ");
                        source_url.Add(" ");
                        source_name.Add(" ");
                        source_logo_url.Add(" ");
                        source_favicon_url.Add(" ");
                        source_publication_id.Add(" ");
                        story_id.Add(" ");
                    }

                }
                else
                {
                    status.Add(" ");
                    request_id.Add(" ");
                }


                for (int i = 0; i < status.Count; i++)
                {
                    data01[0] += $"status: {status[i]}\n" +
               $"request_id: {request_id[i]}\n" +
               $"title: {title[i]}\n" +
               $"link: {link[i]}\n" +
               $"snippet: {snippet[i]}\n" +
               $"photo_url: {photo_url[i]}\n" +
               $"thumbnail_url: {thumbnail_url[i]}\n" +
               $"published_datetime_utc: {published_datetime_utc[i]}\n" +
               $"authors: {authors[i]}\n" +
               $"source_url: {source_url[i]}\n" +
               $"source_name: {source_name[i]}\n" +
               $"source_logo_url: {source_logo_url[i]}\n" +
               $"source_favicon_url: {source_favicon_url[i]}\n" +
              $"source_publication_id: {source_publication_id[i]}\n" +
               $"story_id: {story_id[i]}\n" +
               $"topic_id: {topic_id[i]}\n" +
               $"topic_name {topic_name[i]}\n";


                }
                foreach (var item in results.data)
                {
                    var topicIds = new List<string>();
                    var topicNames = new List<string>();
                    var newsItem = new News_Set_Model02
                    {
                        Status = results.status,
                        Request_id = results.request_id,
                        Title = item.title,
                        Link = item.link,
                        Snippet = item.snippet,
                        Photo_url = item.photo_url,
                        Thumbnail_url = item.thumbnail_url,
                        Published_datetime_utc = item.published_datetime_utc,
                        Authors = item.authors != null ? string.Join(", ", item.authors) : "",
                        Source_url = item.source_url,
                        Source_name = item.source_name,
                        Source_logo_url = item.source_logo_url,
                        Source_favicon_url = item.source_favicon_url,
                        Source_publication_id = item.source_publication_id,
                        Story_id = item.story_id,
                        Topic_id = topicIds,
                        Topic_name = topicNames
                    };

                    NewsItems02.Add(newsItem);
                }


                data01[1] += $"{string.Join(" ", status)}" +
               $"{string.Join(" ", request_id)}" +
               $"{string.Join(" ", title)}" +
               $"{string.Join(" ", link)}" +
               $"{string.Join(" ", snippet)}" +
               $"{string.Join(" ", photo_url)}" +
               $"{string.Join(" ", thumbnail_url)}" +
               $"{string.Join(" ", published_datetime_utc)}" +
               $"{string.Join(" ", authors)}" +
               $"{string.Join(" ", source_url)}" +
               $"{string.Join(" ", source_name)}" +
               $"{string.Join(" ", source_logo_url)}" +
               $"{string.Join(" ", source_favicon_url)}" +
               $"{string.Join(" ", source_publication_id)}" +
               $"{string.Join(" ", story_id)}" +
               $"{string.Join(" ", topic_id)}" +
               $"{string.Join(" ", topic_name)}";

            }
            return data01[0];
        }
        private async Task<string> news_data03(string input)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
        {
            { Headers_[0], Headers_[1] },
            { Headers_[2], Headers_[3] },
        },
            };

            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var body = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<News_Model03.Root>(body);

            // Clear previous lists if they are class-level
            status.Clear(); request_id.Clear(); title.Clear(); link.Clear(); snippet.Clear();
            photo_url.Clear(); thumbnail_url.Clear(); published_datetime_utc.Clear();
            source_url.Clear(); source_name.Clear(); source_logo_url.Clear(); source_favicon_url.Clear(); source_publication_id.Clear();
            topic_id.Clear(); topic_name.Clear(); post_id.Clear(); photo.Clear();
            post_author_username.Clear(); post_author_picture.Clear();
            NewsItems03.Clear();
            data01[0] = "";
            data01[1] = "";

            if (results?.data?.all_articles == null) return "No articles found.";

            foreach (var article in results.data.all_articles)
            {
                title.Add(article.title);
                link.Add(article.link);
                snippet.Add(article.snippet);
                photo_url.Add(article.photo_url);
                thumbnail_url.Add(article.thumbnail_url);
                published_datetime_utc.Add(article.published_datetime_utc);
                source_url.Add(article.source_url);
                source_name.Add(article.source_name);
                source_logo_url.Add(article.source_logo_url);
                source_favicon_url.Add(article.source_favicon_url);
                source_publication_id.Add(article.source_publication_id);

                if (article.related_topics != null)
                {
                    foreach (var topic in article.related_topics)
                    {
                        topic_id.Add(topic.topic_id);
                        topic_name.Add(topic.topic_name);

                        if (results.data.twitter_posts != null)
                        {
                            foreach (var tweet in results.data.twitter_posts)
                            {
                                post_id.Add(tweet.post_id);
                                photo.Add(tweet.photo);
                                post_author_username.Add(tweet.post_author_username);
                                post_author_picture.Add(tweet.post_author_picture);

                                var newsItem = new News_Set_Model03
                                {
                                    Status = results.status,
                                    Request_id = results.request_id,
                                    Title01 = article.title,
                                    Link = article.link,
                                    Snippet = article.snippet,
                                    Photo_url = article.photo_url,
                                    Thumbnail_url = article.thumbnail_url,
                                    Published_datetime_utc = article.published_datetime_utc,
                                    Source_url = article.source_url,
                                    Source_name = article.source_name,
                                    Source_logo_url = article.source_logo_url,
                                    Source_favicon_url = article.source_favicon_url,
                                    Source_publication_id = article.source_publication_id,
                                    Topic_id = topic.topic_id,
                                    Topic_name = topic.topic_name,
                                    Post_id = tweet.post_id,
                                    Photo = tweet.photo,
                                    Post_author_username = tweet.post_author_username,
                                    Post_author_picture = tweet.post_author_picture,
                                };

                                NewsItems03.Add(newsItem);

                                // Add to output string (data01[0])
                                data01[0] +=
                                    $"status: {newsItem.Status}\n" +
                                    $"request_id: {newsItem.Request_id}\n" +
                                    $"title: {newsItem.Title01}\n" +
                                    $"link: {newsItem.Link}\n" +
                                    $"snippet: {newsItem.Snippet}\n" +
                                    $"photo_url: {newsItem.Photo_url}\n" +
                                    $"thumbnail_url: {newsItem.Thumbnail_url}\n" +
                                    $"published_datetime_utc: {newsItem.Published_datetime_utc}\n" +
                                    $"source_url: {newsItem.Source_url}\n" +
                                    $"source_name: {newsItem.Source_name}\n" +
                                    $"source_logo_url: {newsItem.Source_logo_url}\n" +
                                    $"source_favicon_url: {newsItem.Source_favicon_url}\n" +
                                    $"source_publication_id: {newsItem.Source_publication_id}\n" +
                                    $"topic_id: {newsItem.Topic_id}\n" +
                                    $"topic_name: {newsItem.Topic_name}\n" +
                                    $"post_id: {newsItem.Post_id}\n" +
                                    $"photo: {newsItem.Photo}\n" +
                                    $"post_author_username: {newsItem.Post_author_username}\n" +
                                    $"post_author_picture: {newsItem.Post_author_picture}\n\n";
                            }
                        }
                    }
                }

                status.Add(results.status);
                request_id.Add(results.request_id);
            }

            // data01[1] combines all list contents into a long flat string
            data01[1] += $"{string.Join(" ", status)}" +
                         $"{string.Join(" ", request_id)}" +
                         $"{string.Join(" ", title)}" +
                         $"{string.Join(" ", link)}" +
                         $"{string.Join(" ", snippet)}" +
                         $"{string.Join(" ", photo_url)}" +
                         $"{string.Join(" ", thumbnail_url)}" +
                         $"{string.Join(" ", published_datetime_utc)}" +
                         $"{string.Join(" ", source_url)}" +
                         $"{string.Join(" ", source_name)}" +
                         $"{string.Join(" ", source_logo_url)}" +
                         $"{string.Join(" ", source_favicon_url)}" +
                         $"{string.Join(" ", source_publication_id)}" +
                         $"{string.Join(" ", topic_id)}" +
                         $"{string.Join(" ", topic_name)}" +
                         $"{string.Join(" ", post_id)}" +
                         $"{string.Join(" ", photo)}" +
                         $"{string.Join(" ", post_author_username)}" +
                         $"{string.Join(" ", post_author_picture)}";

            return data01[1];
        }
        private async Task<string> news_data04(string input)
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
                News_Model04.Root results = JsonConvert.DeserializeObject<News_Model04.Root>(body);
                status.Add(results.status);
                request_id.Add(results.request_id);
                foreach (var item in results.data)
                {
                    name.Add(item.name);
                    lang.Add(item.lang);
                }
                int minCount = new[] { status.Count, request_id.Count, name.Count, lang.Count }.Min();
                for (int i = 0; i < minCount; i++)
                {
                    data01[0] += $"status: {status[i]}\n" +
                                 $"request_id: {request_id[i]}\n" +
                                 $"name: {name[i]}\n" +
                                 $"lang: {lang[i]}\n";






                }

                data01[1] += $"{string.Join(" ", status)}" +
                    $"{string.Join(" ", request_id)}" +
                    $"{string.Join(" ", name)}" +
                    $"{string.Join(" ", lang)}";

            }
            return data01[0];
        }
        private string news_language(string input)
        {

            data01[2] = Language_Serv01.pick_languge_using_text_file(input);
            return data01[2];



        }
    }
}
