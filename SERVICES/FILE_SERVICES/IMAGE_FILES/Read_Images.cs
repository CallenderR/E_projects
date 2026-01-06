using E_APP02.SERVICES.FILE_SERVICES.FILE_HELPER;
using System.Reflection;

namespace E_APP02.SERVICES.FILE_SERVICES.IMAGE_FILES
{
    internal class Read_Images
    {
        private static File_Helper01 File_H01 = new File_Helper01();
        private static string[] imagePaths = File_H01.all_embedded_images().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        private static int photos_count = imagePaths.Length;
        private static Assembly assembly = Assembly.GetExecutingAssembly();

    }
}
