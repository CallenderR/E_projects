using E_APP02.VIEW.TRANSLATION_VIEW.TRANSLATE_SELECTION_VIEW;


namespace E_APP02.VIEW.TRANSLATION_VIEW.TRANSLATE_MAIN_VIEW
{
    internal class Translate_Main_View01
    {
        private static string[] data01 = new string[100];
        public Translate_Main_View01()
        {
            load_Translate_Main_View01().Wait();


        }
        private async Task load_Translate_Main_View01()
        {
            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) Translate 01 \n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    new Translate_View01();
                    break;


            }
        }
    }
}