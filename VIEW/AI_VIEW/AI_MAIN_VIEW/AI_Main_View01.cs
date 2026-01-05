using E_APP02.VIEW.AI_VIEW.AI_SELECTION_VIEW;


namespace E_APP02.VIEW.AI_VIEW.AI_MAIN_VIEW
{
    internal class AI_Main_View01
    {
        private static string[] data01 = new string[100];
        public AI_Main_View01()
        {
            load_AI_Main_View01();


        }
        private void load_AI_Main_View01()
        {
            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) AI text \n" +
$"2.) AI image\n" +
$"3.) AI sound\n" +
$"4.) AI face swap 01\n" +
$"5.) AI face swap 02\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    new AI_View01();
                    break;

                case 2:
                    new AI_View02();
                    break;

                case 3:
                    new AI_View03();
                    break;
                case 4:
                    new AI_View04();
                    break;
                case 5:
                    new AI_View05();
                    break;

            }
        }
    }
}