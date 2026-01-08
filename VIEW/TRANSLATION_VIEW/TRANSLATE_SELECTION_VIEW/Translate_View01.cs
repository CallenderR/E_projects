using E_APP02.SERVICES.AI_SERVICES.SPEACH_TO_TEXT;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using E_APP02.SERVICES.LANGUAGE_SERVICES;
using E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_LANGUAGE;

namespace E_APP02.VIEW.TRANSLATION_VIEW.TRANSLATE_SELECTION_VIEW
{
    internal class Translate_View01
    {
        private  string[] data01 = new string[100];
        private static Language_Services01 Language_Serv01 = new Language_Services01();
        private static Read_Textfiles01 Read_T01=new Read_Textfiles01();
        private static Speach_to_Text01 Speach_to_T01=new Speach_to_Text01();
        private static Sqlite_Services01 Sqlite_Serv01 = new Sqlite_Services01();
        private static int count=1;        
        public Translate_View01()
        {
            load_Translate_View01().Wait();

        }
        private async Task load_Translate_View01()
        {
            data01[0] +=  
     "1.) Tranlate_Text\n" +
     "2.) Batch_Translation\n" + 
     "3.) Translate_JSON\n" +
     "4.) Translate_HTML\n" +
     "5.) update_language_sqlite\n" +
     "6.) translate audio\n" +
     "7.) view_language_table\n" +
     "8.) Translate using AI";

            Console.WriteLine(data01[0]);   
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                   count = 1;   
                    data01[2] = Language_Services01.data_array01[0];    
                    Console.WriteLine(data01[2]);
                    data01[3] = Console.ReadLine();
                    data01[4] = Language_Services01.data_array01[1];
                    foreach (string a in Read_T01.language_name)
                    {
                        count++;            
                        data01[4] += $"{count++}.) {a}\n";
                       

                    }
                    Console.WriteLine(data01[4]);
                    data01[5] = Console.ReadLine();
                    data01[6] = $"{await Language_Serv01.Tranlate_Text01(int.Parse(data01[5]),data01[3])}";
                    Console.WriteLine(data01[6]);
                    break;
                case 2:  
                    data01[7] = $"{await Language_Serv01.Batch_Translation()}";
                    Console.WriteLine(data01[8]);
                    break;
                case 3:
                    data01[8] = $"{await Language_Serv01.Translate_JSON()}";
                    Console.WriteLine(data01[8]);
                    break;
                case 4:
                    data01[9] = $"{Language_Serv01.Translate_HTML()}";
                    Console.WriteLine(data01[9]);
                    break;
                case 5:   
           //         data01[10] = $"{Language_Serv01.update_language_sqlite()}";
                    Console.WriteLine(data01[10]);
                    break;
                case 6:
                    count = 1;
                    data01[11] = "Tranlate Text\n";
                    Console.WriteLine(data01[11]);
                    data01[12] = Console.ReadLine();
                    data01[13] = $"select language\n";
                    foreach (string a in Read_T01.language_name)
                    {
                        count++;
                        data01[14] += $"{count++}.) {a}\n";
                   

                    }
                    Console.WriteLine(data01[14]);
                    data01[15] = Console.ReadLine();
                    data01[16] = $"{await Language_Serv01.Tranlate_Text01(int.Parse(data01[15]), data01[12])}";
                   await Speach_to_T01.text_to_voice02(data01[16].Trim());
                    Console.WriteLine(data01[16]);
                    break;
                case 7:
                    data01[17] = $"{await Sqlite_Serv01.view_language_table()}";           
                    Console.WriteLine(data01[17]);
                    break;
                case 8:
                    count = 1;
                    data01[18] = Language_Services01.data_array01[0];
                    Console.WriteLine(data01[18]);
                    data01[19] = Console.ReadLine();
                    data01[20] = Language_Services01.data_array01[1];
                    foreach (string a in Read_T01.language_name)
                    {
                        count++;
                        data01[21] += $"{count++}.) {a}\n";


                    }
                    Console.WriteLine(data01[21]);
                    data01[22] = Console.ReadLine();
                    data01[23] = $"{await Language_Serv01.Translate_using_Ai(int.Parse(data01[22]), data01[19])}";
                    Console.WriteLine(data01[23]);
                    break;
            }
        }
    }
}