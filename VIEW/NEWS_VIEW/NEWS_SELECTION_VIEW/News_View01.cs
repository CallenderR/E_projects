
using E_APP02.SERVICES.NEWS_SERVICES;

namespace E_APP02.VIEW.NEWS_VIEW.NEWS_SELECTION_VIEW
{
    internal class News_View01
    {
        private static string[] data01 = new string[100];
        private static News_Services01 News_Serv01 = new News_Services01();
        public News_View01()
        {
            load_News_View01().Wait();


        }
        private async Task load_News_View01()
        {
            data01[0] = "1.) Real_Time_News_Data_GET_Search\n" +
                        "2.) Real_Time_News_Data_GET_Top_Headlines\n" +
                        "3.) Real_Time_News_Data_GET_Topic_Headlines\n" +
                        "4.) Real_Time_News_Data_GET_Topic_News_By_Section\n" +
                        "5.) Local_Headlines_Geo\n" +
                        "6.) Full_Story_Coverage\n" +
                        "7.) Real_Time_News_Data_GET_Language_List\n";

            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    data01[2] = News_Serv01.data_array[0];
                    Console.WriteLine(data01[2]);
                    data01[3] = Console.ReadLine();
                    data01[4] = $"{await News_Serv01.Real_Time_News_Data_GET_Search(data01[3])}";
                    Console.WriteLine(data01[4]);
                    break;
                case 2:
                    data01[5] = $"{await News_Serv01.Real_Time_News_Data_GET_Top_Headlines()}";
                    Console.WriteLine(data01[5]);
                    break;
                case 3:
                    data01[6] = $"{await News_Serv01.Real_Time_News_Data_GET_Topic_Headlines()}";
                    Console.WriteLine(data01[6]);
                    break;
                case 4:
                    data01[7] = News_Serv01.data_array[1];
                    Console.WriteLine(data01[7]);
                    data01[8] = Console.ReadLine();
                    data01[9] = $"{await News_Serv01.Real_Time_News_Data_GET_Topic_News_By_Section(data01[8])}";
                    Console.WriteLine(data01[9]);
                    break;
                case 5:
                    data01[10] = News_Serv01.data_array[0];
                    data01[11] = Console.ReadLine();
                    data01[12] = $"{await News_Serv01.Local_Headlines_Geo(data01[11])}";
                    Console.WriteLine(data01[12]);
                    break;
                case 6:
                    data01[13] = $"{await News_Serv01.Full_Story_Coverage()}";
                    Console.WriteLine(data01[13]);
                    break;
                case 7:
                    data01[14] = $"{await News_Serv01.Real_Time_News_Data_GET_Language_List()}";
                    Console.WriteLine(data01[14]);
                    break;
            }
        }
    }
}