
using E_APP02.MODEL.LIFE_STUDY_MODEL.JUBILESS_MODEL.JUBILESS_SET_MODEL;
using E_APP02.SERVICES.FILE_SERVICES.PDF_FILES;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;


namespace E_APP02.SERVICES.LIFE_STUDY_SERVICES.THE_BOOK_OF_JUBILEES
{
    internal class Jubiless_Services01
    {
        private static string[] data01 = new string[10];
        public List<string> thebook = new List<string>();
        public List<string> bookname = new List<string>();
        public List<string> charpter = new List<string>();
        public List<string> verses = new List<string>();
        public List<Jubiless_Set_Model> collectiondata01 = new List<Jubiless_Set_Model>();
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        private static Read_Pdf Read_Pdf01 = new Read_Pdf();
        public Jubiless_Services01()
        {
            load_Jubiless_data();
        }
        public string read_full_jubiless_text()
        {
            foreach (string a in Read_Pdf01.book_of_jubilees.Split("\n"))
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

        private void load_Jubiless_data()
        {
            string[] lines = Read_Pdf01.book_of_jubilees.Split("\n");
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