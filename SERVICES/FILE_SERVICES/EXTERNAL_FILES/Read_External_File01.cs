using E_APP02.SERVICES.FILE_SERVICES.FILE_HELPER;
using System.Reflection;


namespace E_APP02.SERVICES.FILE_SERVICES.EXTERNAL_FILES
{
    internal class Read_External_File01
    {
        private static File_Helper01 File_H01 = new File_Helper01();
        private static string[] textPaths = File_H01.all_embedded_gguf_models()
        .Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        private static Assembly assembly = Assembly.GetExecutingAssembly();
        private static Stream[] modelStream = { assembly.GetManifestResourceStream(textPaths[0])

        };
        public static Stream[] modelStream01 => modelStream;
    }
}

