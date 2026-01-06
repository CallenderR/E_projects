using E_APP02.SERVICES.FILE_SERVICES.FILE_HELPER;
using System.Reflection;
using System.Text;


namespace E_APP02.SERVICES.FILE_SERVICES.EXCEL_FILES
{
    internal class Read_Excel
    {
        private static File_Helper01 File_H01 = new File_Helper01();
        private static readonly string[] filePath = File_H01.all_embedded_excel()
                .Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        private static readonly Assembly assembly = Assembly.GetExecutingAssembly();
        private static Stream[] stream = { assembly.GetManifestResourceStream(filePath[0]),
                                           assembly.GetManifestResourceStream(filePath[1]),
                                           assembly.GetManifestResourceStream(filePath[2]),
        };
        private static readonly StreamReader[] reader = { new StreamReader(stream[0], Encoding.UTF8),
                                                 new StreamReader(stream[1], Encoding.UTF8),
                                                 new StreamReader(stream[2], Encoding.UTF8),

        };
        private static readonly string[] string_reader = { reader[0].ReadToEnd(),
                                                  reader[1].ReadToEnd(),
                                                  reader[2].ReadToEnd(),

        };
        public string string_excel01 => string_reader[0];
        public string string_excel02 => string_reader[1];
        public string string_excel03 => string_reader[2];

    }
}