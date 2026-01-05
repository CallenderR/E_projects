using E_APP02.SERVICES.DEVICE_SERVICES;
using E_APP02.SERVICES.FILE_SERVICES.EXCEL_FILES;
using E_APP02.SERVICES.FILE_SERVICES.FILE_HELPER;
using E_APP02.SERVICES.FILE_SERVICES.PDF_FILES;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using E_APP02.SERVICES.LOCATION_SERVICES.LOCATE_EXTERNAL.LOCATE_DEVICES;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_HELPER;

namespace E_APP02.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_View01
    {
        private static string[] data01 = new string[100];
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        private static Read_Excel Read_Excel01 = new Read_Excel();
        private static Locate_Devices01 Device_Serv =new Locate_Devices01();
        private static Read_Pdf Read_Pdf01 = new Read_Pdf();
        private static File_Helper01 File_H01=new File_Helper01();  
        public Test_View01()
        {
            load_Test01().Wait();


        }
        private async Task load_Test01()
        {
            data01[0] += $"Select View\n" +
    $"-------------------------\n" +
    $"1.) get stored procedures \n" +
    $"2.) all embedded files \n" +
    $"3.) pdf file reader01 \n" +
    $"4.) read all text files \n" +
    $"5.) sqlite 01 \n" +
    $"6.) sqlite 02 \n" +
    $"7.) sqlite 03 \n" +
    $"8.) all embedded files \n" +
    $"9.) pdf_file_reader01\n" +
    $"10.) make pdf file\n" +
    $"11.) read text files 02\n" +
    $"12.) find python exe\n" +
    $"13) find python exe\n" +
    $"14.) get device loction info\n" +
    $"15.) get ipaddress\n" +
    $"16.) all_embedded_python_files\n" +
    $"17.) find_all_files_in_project\n" +
    $"18.) find_default_face_images01\n" +
    $"19.) find_default_face_images02\n" +
    $"20.) find_default_face_images03\n" +
    $"21.) find_default_group_face_images01\n" +
    $"22.) elements\n" +
    $"23.) book_of_enoch02\n" +
    $"24.) all_gguf_models\n" +
    $"25.) all_text_to_image_safetensors_models\n" +
    $"26.) all_python_files\n" +
    $"27.) file_creator\n" +
    $"28.) all_text_to_image_gguf_models\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            string data_temp = string.Empty;
            switch (int.Parse(data01[1]))
            {
                case 1:

                    data01[2] = $"{Sql_Helper01.get_stored_procedures()}";
                    Console.WriteLine(data01[2]);
                    break;

                case 2:

                    data01[3] = $"{File_H01.all_embedded_files()}";
                    Console.WriteLine(data01[3]);
                    break;
                case 3:

                    data01[4] += "api" +
          "------------------------\n";
                    foreach (var a in READ.api)
                    {
                        data01[4] +=
                            $"{a}\n";
                    }
                    data01[4] += "book_of_enoch01" +
          "------------------------\n";

                    foreach (var a in READ.book_of_enoch01)
                    {
                        data01[4] +=
                            $"{a}\n";
                    }
                    data01[4] += "elements" +
          "------------------------\n";
                    foreach (var a in READ.elements)
                    {
                        data01[4] +=
                            $"{a}\n";
                    }
                    data01[4] += "elements_category" +
          "------------------------\n";
                    foreach (var a in READ.elements_category)
                    {
                        data01[4] +=
                            $"{a}\n";
                    }
                    data01[4] += "CloudinaryDotNet_info" +
          "------------------------\n";
                    foreach (var a in READ.CloudinaryDotNet_info)
                    {
                        data01[4] +=
                            $"{a}\n";
                    }
                    data01[4] += "hairstyle_info_01" +
                 "------------------------\n";
                    foreach (var a in READ.hairstyle_info_01)
                    {
                        data01[4] +=
                            $"{a}\n";
                    }
                    data01[4] += "hairstyle_info_02" +
                 "------------------------\n";
                    foreach (var a in READ.hairstyle_info_02)
                    {
                        data01[4] +=
                            $"{a}\n";
                    }
                    data01[4] += "language_abbreviation" +
                 "------------------------\n";
                    foreach (var a in READ.language_abbreviation)
                    {
                        data01[4] +=
                            $"{a}\n";
                    }
                    data01[4] += "language_name" +
                 "------------------------\n";
                    foreach (var a in READ.language_name)
                    {
                        data01[4] +=
                            $"{a}\n";
                    }
                    data01[4] += "THE BIBLE" +
                        "------------------------\n";
                    foreach (var a in READ.the_bible01)
                    {
                        data01[4] +=
                            $"{a}\n";
                    }

                    Console.WriteLine(data01[4]);
                    break;
                case 4:


                    //       data01[0] = $"{await Sqlite_Services01.Login(entry01.Text.ToString(), entry02.Text.ToString())}";
                    break;
                case 5:

                    //   data01[0] = $"{await Sqlite_Services01.Create_Profile(entry01.Text.ToString(), entry02.Text.ToString())}";
                    break;
                case 6:

                    //     data01[0] = $"{await Sqlite_Services01.View_User_Table()}";
                    break;
                case 7:

                    data01[5] += $"All files\n\n" +
                                 "------------------------\n" +
                                 $"{File_H01.all_embedded_files()}\n\n" +

                                 $"image files\n" +
                                 "------------------------\n" +
                                 $"{File_H01.all_embedded_images()}\n\n" +
                                 $"text files\n" +
                                 "------------------------\n" +
                                 $"{File_H01.all_embedded_textfiles()}\n\n" +
                                  $"pdf files\n" +
                                 "------------------------\n" +
                                 $"{File_H01.all_embedded_pdf()}\n\n" +
                                   $"excel files\n" +
                                 "------------------------\n" +
                                 $"{File_H01.all_embedded_excel()}\n\n" +
                                 $"gguf files\n" +
                                 "------------------------\n" +
                                 $"{File_H01.all_embedded_gguf_models()}\n\n";

                    Console.WriteLine(data01[5]);

                    break;
                case 8:
                    data01[6] += $"{Read_Pdf01.book_of_enoch02}\n";
                    Console.WriteLine(data01[6]);
                    break;
                case 9:
                    data01[7] = "lets start making our pdf\n";
                    Console.WriteLine(data01[7]);
                    data01[8] = Console.ReadLine();
                    data01[9] += $"{Read_Pdf01.make_pdf_file(data01[8])}\n";

                    Console.WriteLine(data01[9]);
                    break;
         
                case 10:


                    foreach (var a in READ.elements)
                    {
                        data_temp += $"elements\n" +
                            $"{a}\n";
                    }
                    foreach (var a in READ.api)
                    {
                        data_temp += $"api\n" +
                            $"{a}\n";
                    }

                    foreach (var a in READ.language_abbreviation)
                    {
                        data_temp += $"language_abbreviation\n" +
                            $"{a}\n";
                    }
                    foreach (var a in READ.language_name)
                    {
                        data_temp += $"language_name\n" +
                            $"{a}\n";
                    }
                    foreach (var a in READ.CloudinaryDotNet_info)
                    {
                        data_temp += $"CloudinaryDotNet_info\n" +
                            $"{a}\n";
                    }
                    foreach (var a in READ.hairstyle_info_01)
                    {
                        data_temp += $"hairstyle_info_01\n" +
                            $"{a}\n";
                    }
                    foreach (var a in READ.hairstyle_info_02)
                    {
                        data_temp += $"hairstyle_info_02\n" +
                            $"{a}\n";
                    }
                    foreach (var a in READ.elements_category)
                    {
                        data_temp += $"elements_category\n" +
                            $"{a}\n";
                    }
                    foreach (var a in READ.the_bible01)
                    {
                        data_temp += $"the_bible\n" +
                            $"{a}\n";
                    }
                    data01[10] = data_temp;
                    Console.WriteLine(data01[10]);
                    break;
                case 11:

                    data01[11] += $"{Read_Excel01.string_excel01}\n" +
                                 $"{Read_Excel01.string_excel02}\n" +
                                 $"{Read_Excel01.string_excel03}\n";
                    Console.WriteLine(data01[11]);
                    break;
                case 12:
                    data01[12] += $"{Device_Services.get_windows_info()}\n";
                    Console.WriteLine(data01[12]);
                    break;
                case 13:
                    data01[13] += $"{File_H01.find_python_exe()}\n";
                    Console.WriteLine(data01[13]);
                    break;
                case 14:
               //     data01[14] += $"{await Device_Serv.get_device_loction_info()}\n";
                    Console.WriteLine(data01[14]);
                    break;
                case 15:
                    data01[15] += $"{Device_Serv.get_ipaddress()}\n";
                    Console.WriteLine(data01[15]);
                    break;
                case 16:
                    data01[16] += $"{File_H01.all_embedded_python_files()}\n";
                    Console.WriteLine(data01[16]);
                    break;
                case 17:
                    data01[17] += $"{File_H01.find_all_files_in_project()}\n";
                    Console.WriteLine(data01[17]);
                    break;
                case 18:
                    data01[18] += $"{File_H01.find_default_face_images01()}\n";
                    Console.WriteLine(data01[18]);
                    break;
                case 19:
                    foreach (var a in File_H01.find_default_single_face_images02())
                    {
                        data01[19] += $"{a}\n";
                    }
                    Console.WriteLine(data01[19]);
                    break;
                case 20:
                    foreach (var a in File_H01.find_default_single_face_images03())
                    {
                        data01[20] += $"{a}\n";
                    }
       
                    Console.WriteLine(data01[20]);
                    break;
                case 21:
                    foreach (var a in File_H01.find_default_group_face_images01())
                    {
                        data01[21] += $"{a}\n";
                    }

                    Console.WriteLine(data01[21]);
                    break;
                case 22:
                    foreach (var a in READ.elements)
                    {
                        data01[22] += $"elements\n" +
                            $"{a}\n";
                    }

                    Console.WriteLine(data01[22]);
                    break;
                case 23: 
         
                        data01[23] = Read_Pdf01.book_of_enoch02;
            

                    Console.WriteLine(data01[23]);
                    break;
                case 24:
                    foreach (var a in File_H01.all_text_to_text_gguf_models())
                    {
                        data01[24] += $"{a}\n";
                    }
                    Console.WriteLine(data01[24]);
                    break;
                case 25:
                    foreach (var a in File_H01.all_text_to_image_safetensors_models())
                    {
                        data01[25] += $"{a}\n";
                    }
                    Console.WriteLine(data01[25]);
                    break;
                case 26:
                    foreach (var a in File_H01.all_python_files())
                    {
                        data01[26] += $"{a}\n";
                    }
                    Console.WriteLine(data01[26]);
                    break;
                case 27:
                    string path01 = @"C:\PROJECTS\E_APP02\E_APP02\FILES\TEXT_FILES";
                    data01[0] = $"content";
                    Console.WriteLine(data01[0]);
                    data01[1] = Console.ReadLine();
                    data01[2] = $"file type";
                    Console.WriteLine(data01[2]);
                    data01[3] = Console.ReadLine();
                    data01[4] = $"{File_H01.file_creator(path01.Trim(), data01[1].ToString().Trim(), data01[3].ToString().Trim())}\n";
                    Console.WriteLine(data01[4]);
                    break;
                case 28:
                    foreach (var a in File_H01.all_text_to_image_gguf_models())
                    {
                        data01[27] += $"{a}\n";
                    }
                    Console.WriteLine(data01[27]);
                    break;
            }
        }
    }
}