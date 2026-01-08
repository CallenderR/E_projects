

namespace E_APP02.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class AI_View03
    {
        private static string[] data = new string[100];

        public AI_View03()
        {
            load_AI_View03().Wait();


        }
        private async Task load_AI_View03()
        {
            data[0] = $"Select View\n" +
    $"-------------------------\n" +
    $"1.) Voice to text \n";
            Console.WriteLine(data[0]);
            data[1] = Console.ReadLine();
            switch (int.Parse(data[1]))
            {
                case 1:
                    data[2] = " ";
                    Console.WriteLine(data[2]);
                    break;

            }
        }
    }
}
