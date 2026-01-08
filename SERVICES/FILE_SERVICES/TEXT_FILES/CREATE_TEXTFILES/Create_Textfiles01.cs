
namespace E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.CREATE_TEXTFILES
{
    internal class Create_Textfiles01
    {

        private static readonly string[] data01 = new string[100];
        public string create_textfile01(string input01, string input02)
        {
            //inpouit01 = file path
            //input02 = file content
            File.WriteAllText(input01, input02);                
            return data01[0];
        }



    }
}
