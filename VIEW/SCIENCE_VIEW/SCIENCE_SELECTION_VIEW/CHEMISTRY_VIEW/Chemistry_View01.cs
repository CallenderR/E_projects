using E_APP02.SERVICES.SCIENCE_SERVICES.CHEMISTRY_SERVICES;

namespace E_APP02.VIEW.SCIENCE_VIEW.SCIENCE_SELECTION_VIEW.CHEMISTRY_VIEW
{
    internal class Chemistry_View01
    {
        private static string[] data01 = new string[100];
        private static Chemistry_Services Chemistry_Serv01 = new Chemistry_Services();
        private static int count = 0;
        public Chemistry_View01()
        {
            load_Chemistry_View01().Wait();


        }
        private async Task load_Chemistry_View01()
        {
            data01[0] =

                        "1.) find_element_using_textfile\n" +
                        "2.) find_element_using_sql\n" +
                        "3.)find_element_using_sqlite\n" +
                        "4.)view_all_elements_using_textfile\n" +
                        "5.)find_category_elements_using_sqlite\n" +
                        "6.)find_category_elements_using_sql\n" +
                        "7.)find_category_elements_table\n" +
                        "8.)view_all_elements_using_sqlit\n";

            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    while(true)
                    {
                        data01[2] = "search element\n";
                        Console.WriteLine(data01[2]);
                        data01[3] = Console.ReadLine();
                        if (data01[3].Equals("exit", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Goodbye.");
                            break;
                        }
                        else
                        {
                            data01[4] = $"{Chemistry_Serv01.find_element_using_textfile(data01[3])}";
                            Console.WriteLine(data01[4]);
                            continue;
                        }
                    }
                    break;
                case 2:
                    while(true)
                    {
                        data01[5] = "search element\n";
                        Console.WriteLine(data01[5]);
                        data01[6] = Console.ReadLine();
                        if (data01[6].Equals("exit", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Goodbye.");
                            break;
                        }
                        else
                        {
                            data01[7] = $"{Chemistry_Serv01.find_element_using_sql(data01[6])}";
                            Console.WriteLine(data01[7]);
                            continue;
                        }
                    }
                    break;
                case 3:
                    while (true)
                    {
                        data01[8] = "search element\n";
                        Console.WriteLine(data01[8]);
                        data01[9] = Console.ReadLine();
                        if (data01[9].Equals("exit", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Goodbye.");
                            break;
                        }
                        else
                        {
                            data01[10] = $"{await Chemistry_Serv01.find_element_using_sqlite(data01[9])}";
                            Console.WriteLine(data01[10]);
                            continue;
                        }
                    }
                    break;
                case 4:
                    data01[11] = $"{Chemistry_Serv01.view_all_elements_using_textfile()}";
                    Console.WriteLine(data01[11]);
                    break;
                case 5:
                    foreach (var a in Chemistry_Serv01.data_array)
                    {
                        count++;
                        data01[12] += $"{count}.) {a}\n";
                    }
                    Console.WriteLine(data01[12]);
                    data01[13] = Console.ReadLine();
                    data01[14] = $"{await Chemistry_Serv01.find_category_elements_using_sqlite(int.Parse(data01[13]))}";
                    Console.WriteLine(data01[14]);
                    break;
                case 6:
                    foreach(var a in Chemistry_Serv01.data_array)
                    {
                        count++;
                        data01[15] += $"{count}.) {a}\n";
                    }
                    Console.WriteLine(data01[15]);
                    data01[16] = Console.ReadLine();
                    data01[17] = $"{Chemistry_Serv01.find_category_elements_table(int.Parse(data01[16]))}";
                    Console.WriteLine(data01[17]);
                    break;
                case 7:
  
                    data01[18] = $"{await Chemistry_Serv01.view_all_elements_using_sqlit()}";
                    Console.WriteLine(data01[18]);
                    break;
            }
        }
    }
}