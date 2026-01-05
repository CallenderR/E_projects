using E_APP02.SERVICES.AI_SERVICES.SPEACH_TO_TEXT;
using E_APP02.SERVICES.AI_SERVICES.TEXT_TO_IMAGE;
using E_APP02.SERVICES.AI_SERVICES.TEXT_TO_TEXT;
using E_APP02.SERVICES.DEVICE_SERVICES;


namespace E_APP02.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class AI_View01
    {
        private static string[] data = new string[100];
        private static Text_To_Text01 Text_To_Text01 = new Text_To_Text01();
        private static Device_Services Device_Serv = new Device_Services();
        private static Text_To_Image01 Text_To_I01 = new Text_To_Image01();
        private static Speach_to_Text01 Speach_to_T01 = new Speach_to_Text01();
        public AI_View01()
        {
            load_AI_View01().Wait();
        }
        private async Task load_AI_View01()
        {
            data[0] = $"Select View\n" +
    $"-------------------------\n" +
    $"1.) Text generator 01\n" +
    $"2.) Text to image 01\n" +
    $"3.) Text to image 01\n" +
    $"4.) image to text 01\n" +
    $"5.) audioable text generator 01\n";
            Console.WriteLine(data[0]);
            data[1] = Console.ReadLine();
            switch (int.Parse(data[1]))
            {
                case 1:
                    data[2] = "another day another dollar\n" +
                              "what can i do for you\n";
                    Console.WriteLine(data[2]);

                    while (true)
                    {
                        data[3] = Console.ReadLine();

                        if (data[3].Equals("exit", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Goodbye.");
                            break;
                        }
                        else
                        {
                            data[4] = await Text_To_Text01.text_generation(data[3]);
                            Console.WriteLine(data[4]);
                            continue;
                        }

 
                    }

                    break;
                case 2:
                    data[5] = "another day another dollar\n" +
                              "talk to me, what seems to be on your mind\n" +
                              "and lets create an image\n";
                    Console.WriteLine(data[5]);
                    data[6] = Console.ReadLine();
                    data[7] = Text_To_I01.text_to_image01(data[6]);
                    Console.WriteLine(data[7]);
                    break;
                case 3:
                    data[8] = "another day another dollar\n" +
                              "talk to me, what seems to be on your mind\n" +
                              "and lets create an image\n";
                    Console.WriteLine(data[8]);
                    data[9] = Console.ReadLine();
                    data[10] = await Text_To_I01.text_to_image02(data[9]);
                    Console.WriteLine(data[10]);
                    break;
                case 4:
                    data[11] = "another day another dollar\n" +
                              "what image you would like for me to talk about\n";
                    Console.WriteLine(data[11]);
                    data[12] = $"{Device_Serv.pick_file01(@"C:\Users\calle\OneDrive\Pictures\Camera Roll 1")}";
                    data[13] = await Text_To_I01.text_to_image02(data[12]);
                    Console.WriteLine(data[13]);
                    break;
                case 5:




                    data[14] = "another day another dollar\n" +
                        "what can i do for you\n";
                    Console.WriteLine(data[14]);

                    while (true)
                    {
                        data[16] = Console.ReadLine();

                        if (data[16].Equals("exit", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Goodbye.");
                            break;
                        }
                        else
                        {
                            data[16] = string.Empty;
                            data[17] =string.Empty; 
                            data[17] = await Text_To_Text01.text_generation(data[16]);
                            await Speach_to_T01.text_to_voice01(data[17].Trim());
                            Console.WriteLine(data[17]);
                            continue;
                        }


                    }

                    break;

            }
        }
    }
}