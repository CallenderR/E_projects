using E_APP02.SERVICES.AI_SERVICES.SPEACH_TO_TEXT;
using E_APP02.SERVICES.LIFE_STUDY_SERVICES.THE_BIBLE;


namespace E_APP02.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_SELECTION_VIEW
{
    internal class Life_Study_View01
    {
        /// <summary>
        ////////// https://www.naturalnews.com/
        ///
        /// blacklisted.........
        /// 	Mike Adams The Health Ranger
        /// </summary>
        //tor...........enoch search engine
        ////https://www.brighteon.com/63ff7bc9-35dc-48cf-b60e-7537e8002928
        ///https://www.brighteon.com/

        private static string[] data01 = new string[100];
        private static Bible_Services01 Bible_Serv01 = new Bible_Services01();
        private static Speach_to_Text01 Speach_to_T01 = new Speach_to_Text01();

        public Life_Study_View01()
        {
            load_Life_Study_View01().Wait();


        }
        private async Task load_Life_Study_View01()
        {
            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) Read The Bible \n" +
$"2.) Audio The Bible \n" +
$"3.) read king james version\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    data01[2] = Bible_Serv01.read_full_bible_text();
                    Console.WriteLine(data01[2]);
                    break;
                case 2:
                    data01[3] = Bible_Serv01.read_full_bible_text();
                    await Speach_to_T01.text_to_voice01(data01[3]);
                    break;
                case 3:
                    data01[4] = Bible_Serv01.string_read_kjv();
                    Console.WriteLine(data01[4]);
                    break;
            }
        }
    }
}
