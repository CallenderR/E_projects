using E_APP02.SERVICES.FILE_SERVICES.FILE_HELPER;
using System.Reflection;

namespace E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS
{
    internal class Read_Textfiles01
    {
        private static File_Helper01 File_H01 = new File_Helper01();
        private static readonly Assembly assembly01 = Assembly.GetExecutingAssembly();
        private static readonly string[] textPaths = File_H01.all_embedded_textfiles()
        .Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        private static readonly Stream[] stream01 = { assembly01.GetManifestResourceStream(textPaths[0]),
                                             assembly01.GetManifestResourceStream(textPaths[1]),
                                             assembly01.GetManifestResourceStream(textPaths[2]),
                                             assembly01.GetManifestResourceStream(textPaths[3]),
                                             assembly01.GetManifestResourceStream(textPaths[4]),
                                             assembly01.GetManifestResourceStream(textPaths[5]),
                                             assembly01.GetManifestResourceStream(textPaths[6]),
                                             assembly01.GetManifestResourceStream(textPaths[7]),
                                             assembly01.GetManifestResourceStream(textPaths[8]),
                                             assembly01.GetManifestResourceStream(textPaths[9]),


        };
        private static readonly StreamReader[] reader01 = { new StreamReader(stream01[0]),
                                                   new StreamReader(stream01[1]),
                                                   new StreamReader(stream01[2]),
                                                   new StreamReader(stream01[3]),
                                                   new StreamReader(stream01[4]),
                                                   new StreamReader(stream01[5]),
                                                   new StreamReader(stream01[6]),
                                                   new StreamReader(stream01[7]),
                                                   new StreamReader(stream01[7]),
                                                   new StreamReader(stream01[8]),
                                                   new StreamReader(stream01[9]),

        };
        private static readonly string[] data01 = reader01[0].ReadToEnd().Split("\n");
        private static readonly string[] data02 = reader01[1].ReadToEnd().Split("\n");
        private static readonly string[] data03 = reader01[2].ReadToEnd().Split("\n");
        private static readonly string[] data04 = reader01[3].ReadToEnd().Split("\n");
        private static readonly string[] data05 = reader01[4].ReadToEnd().Split("\n");
        private static readonly string[] data06 = reader01[5].ReadToEnd().Split("\n");
        private static readonly string[] data07 = reader01[6].ReadToEnd().Split("\n");
        private static readonly string[] data08 = reader01[7].ReadToEnd().Split("\n");
        private static readonly string[] data09 = reader01[8].ReadToEnd().Split("\n");
        private static readonly string[] data10 = reader01[9].ReadToEnd().Split("\n");

        public string[] api => data01;
        public string[] book_of_enoch01 => data02;
        public string[] elements => data03;
        public string[] elements_category => data04;
        public string[] CloudinaryDotNet_info => data05;
        public string[] hairstyle_info_01 => data06;
        public string[] hairstyle_info_02 => data07;
        public string[] language_abbreviation => data08;
        public string[] language_name => data10;
        public string[] the_bible01 => data09;

    }
}