using E_APP02.SERVICES.NBA_SERVICES;


namespace E_APP02.VIEW.NBA_VIEW.NBA_SELECTION_VIEW
{
    internal class Nba_View02
    {
        private static string[] data01 = new string[100];
        private static Nba_Data_Api02 Nba_Data_A02 = new Nba_Data_Api02();
        public Nba_View02()
        {
            load_Nba_View02().Wait();


        }
        private async Task load_Nba_View02()
        {
            data01[0] = "1.)Leagues\n";

            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:

           
                    data01[2] += $"{await Nba_Data_A02.Leagues()}\n";
                    Console.WriteLine(data01[2]);
                    break;

            }
        }
    }
}