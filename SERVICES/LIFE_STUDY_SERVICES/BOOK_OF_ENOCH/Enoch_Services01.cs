using E_APP02.MODEL.LIFE_STUDY_MODEL.ENOCH_MODEL.ENOCH_SET_MODEL;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;

namespace E_APP02.SERVICES.LIFE_STUDY_SERVICES.BOOK_OF_ENOCH
{
    internal class Enoch_Services01
    {
        private static string[] data01 = new string[100];
        public List<string> thebook = new List<string>();
        public List<string> bookname = new List<string>();
        public List<string> charpter = new List<string>();
        public List<string> verses = new List<string>();
        public List<Enoch_Set_Model> collectiondata01 = new List<Enoch_Set_Model>();
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        public Enoch_Services01()
        {
            load_Enoch_data();
        }
        public string read_full_enoch_text()
        {
            foreach (string a in READ.book_of_enoch01)
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

        private void load_Enoch_data()
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