using E_APP02.VIEW.LOCATION_VIEW.LOCATION_SELECTION_VIEW;


namespace E_APP02.VIEW.LOCATION_VIEW.LOCATION_MAIN_VIEW
{
    internal class Location_Main_View01
    {
        private static string[] data01 = new string[100];
        public Location_Main_View01()
        {
            load_Location_Main_View01();


        }
        private void load_Location_Main_View01()
        {
            data01[0] = $"Select View\n" +
                        $"-------------------------\n" +
                        $"1.) Location 01 \n" +
                        $"2.) Location 02 \n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    new Location_View01();
                    break;
                case 2:
                    new Location_View02();
                    break;



            }
        }
    }
}