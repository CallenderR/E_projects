using E_APP02.SERVICES.AI_SERVICES.IMAGE_EDIT;
using E_APP02.SERVICES.DEVICE_SERVICES;
using E_APP02.SERVICES.FILE_SERVICES.FILE_HELPER;


namespace E_APP02.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class AI_View05
    {
        private static string[] data = new string[100];
        private static Image_Edit04 Image_E04 = new Image_Edit04();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static Device_Services device_serv =new Device_Services();       
        public AI_View05()
        {
            load_AI_View05().Wait();


        }
        private async Task load_AI_View05()
        {
            data[0] = $"Select View\n" +
    $"-------------------------\n" +
    $"1.) face swap 01 \n";
            Console.WriteLine(data[0]);
            data[1] = Console.ReadLine();
            switch (int.Parse(data[1]))
            {
                case 1:
                    data[2] = "Please select a photo for me to edit\n";
                    Console.WriteLine(data[2]);
                    data[3] = $"{File_H01.find_default_single_face_images02()[0].Trim()}";
                    data[4] = "Please select a 2nd photo for me to edit\n";
                    Console.WriteLine(data[4]);
                    data[5] = $"{File_H01.find_default_single_face_images02()[1].Trim()}";
                    string[] data_array01 = { data[5].Trim(), data[3].Trim() };
                    data[6] = await Image_E04.Result(data_array01);
                    data[7]=await device_serv.Base64ToImageFile(data[6]);
                    Console.WriteLine(data[7]);
                    break;

            }
        }
    }
}
