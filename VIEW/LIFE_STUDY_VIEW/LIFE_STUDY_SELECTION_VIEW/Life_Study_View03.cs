using E_APP02.SERVICES.AI_SERVICES.SPEACH_TO_TEXT;
using E_APP02.SERVICES.LIFE_STUDY_SERVICES.THE_BOOK_OF_JUBILEES;


namespace E_APP02.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_SELECTION_VIEW
{
    internal class Life_Study_View03
    {
        private static string[] data01 = new string[100];
       private static Jubiless_Services01 Jubiless_Serv01 =new Jubiless_Services01();
        private static Speach_to_Text01 Speach_to_T01 = new Speach_to_Text01();
        public Life_Study_View03()
        {
            load_Life_Study_View03().Wait();


        }
        private async Task load_Life_Study_View03()
        {
            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) Read Book of jubilees \n" +
$"2.) Audio Book of jubilees \n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    data01[2] = $"{Jubiless_Serv01.read_full_jubiless_text()}";
                    Console.WriteLine(data01[2]);
                    break;
                case 2:
                    data01[3] = "";
                    await Speach_to_T01.text_to_voice01(data01[3]);
                    break;
            }
        }
    }
}
