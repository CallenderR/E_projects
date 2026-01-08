using E_APP02.SERVICES.AI_SERVICES.IMAGE_EDIT;
using E_APP02.SERVICES.DEVICE_SERVICES;
using E_APP02.SERVICES.FILE_SERVICES.FILE_HELPER;

namespace E_APP02.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class AI_View02
    {
        private static string[] data = new string[100];
        private static Device_Services Device_Serv = new Device_Services();
        private static Image_Edit01 Image_E01 = new Image_Edit01();
        private static Image_Edit02 Image_E02 = new Image_Edit02();
        private static Image_Edit03 Image_E03 = new Image_Edit03();
        private static Image_Edit05 Image_E05 = new Image_Edit05();
        private static File_Helper01 File_H01 = new File_Helper01();
        public AI_View02()
        {
            load_AI_View02().Wait();
        }
        private async Task load_AI_View02()
        {
            data[0] = $"Select View\n" +
    $"-------------------------\n" +
    $"1.) PhotoAnime \n" +
    $"2.) Hairstyle_Changer_Pro\n" +
    $"3.) Face_Swap \n" +
    $"4.) photo anime 01 \n";
            Console.WriteLine(data[0]);
            data[1] = Console.ReadLine();
            switch (int.Parse(data[1]))
            {
                case 1:
                    data[2] = "Please select a photo for me to edit\n";
                    Console.WriteLine(data[2]);
                    data[3] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[0].Trim())}";         
                    data[4] = $"{await Image_E01.PhotoAnime(data[3].Trim())}";
                    data[5] = await Device_Serv.image_url_to_file(data[4].Trim());
                    Console.WriteLine(data[5]);
                    break;
                case 2:
                    foreach (string a in Image_Edit02.hair_color)
                    {
                        data[6] += $"{a}\n";
                    }
                    foreach (string a in Image_Edit02.hair_type)
                    {
                        data[7] += $"{a}\n";
                    }
                    data[8] = "Please select a photo for me to edit\n";
                    Console.WriteLine(data[8]);
                    data[9] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[0].Trim())}";
                    data[10] = "Please select a hair color\n" +
                              "--------------------------------\n" +
                              $"{data[6]}\n";
                    Console.WriteLine(data[10]);
                    data[11]= Console.ReadLine();       
                    data[12] = "Please select a hair type\n" +
                               "--------------------------------\n" +
                               $"{data[7]}\n";
                    Console.WriteLine(data[12]);
                    data[13] = Console.ReadLine();
                    data[14] = $"{await Image_E02.Hairstyle_Changer_Pro(Image_Edit02.hair_type[int.Parse(data[13])], Image_Edit02.hair_color[int.Parse(data[11])], data[9])}";//hair type, hair color,image
                    Console.WriteLine(data[14]);
                    break;

                case 3:
                    data[15] = "Please select a photo for me to face swap\n"; 
                    Console.WriteLine(data[15]);
                    data[16] = await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[1].Trim());
                    data[17] = "Please select a 2nd photo for me to face swap\n";
                    Console.WriteLine(data[17]);
                    data[18] = await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[0].Trim());
                    string[] data_array = { data[16].Trim(), data[18].Trim() };
                    data[19] = $"{await Image_E03.Face_Swap_Single_Face(data_array)}";
              //      data[20] = await Device_Serv.image_url_to_file(data[19].Trim());
                    Console.WriteLine(data[19]);
                    break;
                case 4:
                    data[21] = "Please select a photo for me to face swap\n";
                    Console.WriteLine(data[22]);
                    data[23] = File_H01.find_default_single_face_images03()[1].Trim();
                    foreach(var a in Image_Edit05.data_array01)
                    {
                        data[24] += $"{a}\n";
                    }
        
                    Console.WriteLine(data[24]);
                    data[25] =Console.ReadLine();               
                    data[26] = $"{await Image_E05.photo_to_anime(data[23],int.Parse(data[24]))}";

                    data[27] =await Device_Serv.image_url_to_file(data[26]);
                    Console.WriteLine(data[27]);
                    break;
            }
        }
    }
}
