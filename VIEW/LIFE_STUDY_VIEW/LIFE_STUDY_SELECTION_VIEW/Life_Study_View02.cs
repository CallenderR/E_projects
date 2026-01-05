using E_APP02.SERVICES.AI_SERVICES.SPEACH_TO_TEXT;
using E_APP02.SERVICES.LIFE_STUDY_SERVICES.BOOK_OF_ENOCH;
namespace E_APP02.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_SELECTION_VIEW
{
    internal class Life_Study_View02
    {
        private static string[] data01 = new string[100];
        private static Enoch_Services01 Enoch_Serv01 =new Enoch_Services01();
        private static Speach_to_Text01 Speach_to_T01 = new Speach_to_Text01();
        public Life_Study_View02()
        {
            load_Life_Study_View02().Wait();
        }
        private async Task load_Life_Study_View02()
        {
            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) Read Book of Enoch \n" +
$"2.) Audio Book of Enoch \n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    data01[2] = $"{Enoch_Serv01.read_full_enoch_text()}";
                    Console.WriteLine(data01[2]);
                    break;
                case 2:
                    data01[3] = $"{Enoch_Serv01.read_full_enoch_text()}";
                    await Speach_to_T01.text_to_voice02(data01[3].Trim());
                    Console.WriteLine(data01[3].Trim());
                    break;
            }
        }
    }
}
