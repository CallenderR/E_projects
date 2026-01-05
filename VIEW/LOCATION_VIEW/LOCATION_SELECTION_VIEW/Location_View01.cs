using E_APP02.SERVICES.LOCATION_SERVICES.LOCATE_EXTERNAL.LOCATE_PERSON;


namespace E_APP02.VIEW.LOCATION_VIEW.LOCATION_SELECTION_VIEW
{
    internal class Location_View01
    {
        private static string[] data01 = new string[100];
        private static Locate_Person_Services01 Locate_Person_Serv01 = new Locate_Person_Services01();
        public Location_View01()
        {
            load_Location_View01().Wait();


        }
        private async Task load_Location_View01()
        {
            data01[0] =

                        "1.) trace_by_name\n" +
                        "2.) trace_by_address\n" +
                        "3.) trace_by_phone\n" +
                        "4.) trace_by_email\n" +
                        "5.) personDetailsByID\n";

            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    data01[2] = Locate_Person_Serv01.data_array[0];
                    Console.WriteLine(data01[2]);
                    data01[3] = Console.ReadLine();
                    data01[4] = $"{await Locate_Person_Serv01.trace_by_name(data01[3])}";
                    Console.WriteLine(data01[4]);
                    break;
                case 2:
                    data01[5] = Locate_Person_Serv01.data_array[2];
                    Console.WriteLine(data01[5]);
                    data01[6] = Console.ReadLine();
                    data01[7] = Locate_Person_Serv01.data_array[3];
                    Console.WriteLine(data01[7]);
                    data01[8] = Console.ReadLine();
                    data01[9] = $"{await Locate_Person_Serv01.trace_by_address(data01[6],data01[7])}";
                    Console.WriteLine(data01[9]);
                    break;
                case 3:
                    data01[10] = Locate_Person_Serv01.data_array[4];
                    Console.WriteLine(data01[10]);
                    data01[11] = Console.ReadLine();
                    data01[12] = $"{await Locate_Person_Serv01.trace_by_phone(data01[11])}";
                    Console.WriteLine(data01[12]);
                    break;
                case 4:
                    data01[14] = Locate_Person_Serv01.data_array[5];
                    Console.WriteLine(data01[14]);
                    data01[15] = Console.ReadLine();
                    data01[16] = $"{await Locate_Person_Serv01.trace_by_email(data01[15])}";
                    Console.WriteLine(data01[16]);
                    break;
                case 5:
                    data01[15] = Locate_Person_Serv01.data_array[6];
                    Console.WriteLine(data01[15]);
                    data01[16] = Console.ReadLine();
                    data01[17] = $"{await Locate_Person_Serv01.personDetailsByID(data01[16])}";
                    Console.WriteLine(data01[16]);
                    break;

            }
        }
    }
}