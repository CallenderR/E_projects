using E_APP02.MODEL.LIFE_STUDY_MODEL.BIBLE_MODEL.BIBLE_SET_MODEL;
using E_APP02.SERVICES.FILE_SERVICES.PDF_FILES;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;


namespace E_APP02.SERVICES.LIFE_STUDY_SERVICES.THE_BIBLE
{
    internal class Bible_Services01
    {
        private static string[] data01 = new string[10];
        public List<string> thebook = new List<string>();
        public List<string> bookname = new List<string>();
        public List<string> charpter = new List<string>();
        public List<string> verses = new List<string>();
        public List<Bible_Set_Model01> collectiondata01 = new List<Bible_Set_Model01>();
        private static Read_Textfiles01 READ = new Read_Textfiles01();

        private static Read_Pdf Read_Pdf01 = new Read_Pdf();
        public Bible_Services01()
        {
            load_bible_data();
        }


        public string read_full_bible_text()
        {
            foreach (string a in READ.the_bible01)
            {
                data01[0] += $"{a}\n";

            }

            return data01[0];
        }
        public string get_data01()
        {

            string previous = null;
            for (int i = 0; i < bookname.Count; i++)
            {
                string current = bookname[i];
                if (current == previous)
                {
                    continue;

                }
                else
                {
                    previous = current;
                }
                data01[1] += $"{current}\n";

            }
            return data01[1];
        }
        public string get_data02(string input)
        {

            if (verses.Contains(input) == true)
            {
                foreach (string a in verses)
                {
                    data01[2] = $"{a}\n";
                }
            }
            else
            {
                data01[2] = "cant find";
            }
            return data01[2];
        }

        public string string_read_kjv()
        {
            data01[3] = Read_Pdf01.The_Holy_Bible_KJV;
            return data01[3];
        }
        private void load_bible_data()
        {
            string[] lines = READ.the_bible01;
            string previousBook = null;

            foreach (string line in lines)
            {
                thebook.Add(line);

                if (string.IsNullOrWhiteSpace(line))
                {
                    bookname.Add("");
                    continue;
                }
                else
                {

                    int spaceIndex = line.IndexOf(' ');
                    string book = (spaceIndex == -1) ? line : line.Substring(0, spaceIndex);
                    if (book == previousBook)
                    {
                        continue;

                    }
                    else
                    {
                        previousBook = book;
                        bookname.Add(book);
                    }

                }
            }
        }
    }
}