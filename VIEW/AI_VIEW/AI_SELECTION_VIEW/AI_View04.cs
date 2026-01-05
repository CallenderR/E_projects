using E_APP02.SERVICES.AI_SERVICES.IMAGE_EDIT;
using E_APP02.SERVICES.AI_SERVICES.TEXT_TO_VIDEO;
using E_APP02.SERVICES.DEVICE_SERVICES;
using E_APP02.SERVICES.FILE_SERVICES.FILE_HELPER;

namespace E_APP02.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class AI_View04
    {

        private static string[] data = new string[100];
        private static Image_Edit03 Image_E03 = new Image_Edit03();
        private static Device_Services Device_Serv = new Device_Services();
        private static File_Helper01 File_H01 = new File_Helper01();
        public AI_View04()
        {
            load_AI_View04().Wait();


        }
        private async Task load_AI_View04()
        {
            data[0] = $"Select View\n" +
    $"-------------------------\n" +
    $"1.) single face swap 01 \n" +
    $"2.)Face_Swap_Multiple_Faces\n" +
$"3.)Face_Swap_Single_Base64\n" +
$"4.)Face_Swap_Multiple_Base64\n" +
$"5.)Face_Swap_One_To_All_Faces\n" +
$"6.)Image_Temporary_Storage_API\n" +
$"7.)Face_Recognition_Facial_Analysis\n" +
$"8.)Face_Beautify_Enhancer \n";
            Console.WriteLine(data[0]);
            data[1] = Console.ReadLine();
            switch (int.Parse(data[1]))
            {
                case 1:
                    data[2] = "Please select a photo for me to edit\n";
                    Console.WriteLine(data[2]);
                    data[3] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[0].Trim())}";
                    data[4] = "Please select a 2nd photo for me to edit\n";
                    Console.WriteLine(data[4]);
                    data[5] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[1].Trim())}";
                    string[] data_array01 = {data[5].Trim(),data[3].Trim() };
                    data[6] = await Image_E03.Face_Swap_Single_Face(data_array01);
                    Console.WriteLine(data[6]);
                    break;
                case 2:
                    data[7] = "Please select a photo for me to edit\n";
                    Console.WriteLine(data[7]);
                    data[8] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[0].Trim())}";
                    data[9] = "Please select a 2nd photo for me to edit\n";
                    Console.WriteLine(data[9]);
                    data[10] = $"{await Device_Serv.image_to_url(File_H01.find_default_group_face_images01()[0].Trim())}";
                    string[] data_array02 = { data[8].Trim(), data[10].Trim() };
                    data[11] = await Image_E03.Face_Swap_Multiple_Faces(data_array02);
                    Console.WriteLine(data[11]);
                    break;
                case 3:
                    data[12] = "Please select a photo for me to edit\n";
                    Console.WriteLine(data[12]);
                    data[13] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[0].Trim())}";
                    data[14] = "Please select a 2nd photo for me to edit\n";
                    Console.WriteLine(data[14]);
                    data[15] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[1].Trim())}";
                    data[16] = await Image_E03.Face_Swap_Single_Base64(data[13].Trim(), data[15].Trim());
                    Console.WriteLine(data[16]);
                    break;
                case 4:
                    data[17] = "Please select a photo for me to edit\n";
                    Console.WriteLine(data[17]);
                    data[18] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[0].Trim())}";
                    data[19] = "Please select a 2nd photo for me to edit\n";
                    Console.WriteLine(data[19]);
                    data[20] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[1].Trim())}";
                    data[21] = await Image_E03.Face_Swap_Multiple_Base64(data[18].Trim(), data[20].Trim());
                    Console.WriteLine(data[21]);
                    break;
                case 5:
                    data[22] = "Please select a photo for me to edit\n";
                    Console.WriteLine(data[22]);
                    data[23] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[0].Trim())}";
                    data[24] = await Image_E03.Face_Swap_One_To_All_Faces(data[24].Trim());
                    Console.WriteLine(data[24]);
                    break;
                case 6:
                    data[25] = "Please select a photo for me to edit\n";
                    Console.WriteLine(data[25]);
                    data[26] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[0].Trim())}";
                    data[27] = "Please select a 2nd photo for me to edit\n";
                    Console.WriteLine(data[27]);
                    data[28] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[1].Trim())}";
                    data[29] = await Image_E03.Image_Temporary_Storage_API(data[26].Trim(), data[28].Trim());
                    Console.WriteLine(data[29]);
                    break;
                case 7:
                    data[30] = "Please select a photo for me to edit\n";
                    Console.WriteLine(data[30]);
                    data[31] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[0].Trim())}";
                    data[32] = await Image_E03.Face_Recognition_Facial_Analysis(data[31].Trim());
                    Console.WriteLine(data[33]);
                    break;
                case 8:
                    data[34] = "Please select a photo for me to edit\n";
                    Console.WriteLine(data[34]);
                    data[35] = $"{await Device_Serv.image_to_url(File_H01.find_default_single_face_images03()[0].Trim())}";
                    data[36] = await Image_E03.Face_Beautify_Enhancer(data[35].Trim());
                    Console.WriteLine(data[36]);
                    break;




            }
        }
    }
}