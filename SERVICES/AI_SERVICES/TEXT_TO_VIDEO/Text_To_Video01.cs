using E_APP02.SERVICES.FILE_SERVICES.PYTHONE_FILES;
using System.Threading.Tasks;

namespace E_APP02.SERVICES.AI_SERVICES.TEXT_TO_VIDEO
{

    internal class Text_To_Video01
    {
        private  string[] data01 = new string[100];
        private static Read_Python01 C_Sharp_To_Python_Serv= new Read_Python01();
        public string text_to_Video01(string input)
        {
            data01[0] = C_Sharp_To_Python_Serv.RunTextToVideo01(input);
            return data01[0];
        }
    }
}
