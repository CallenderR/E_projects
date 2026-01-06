using E_APP02.MODELS.SCIENCE_MODEL.CHEMISTRY_MODEL.CHEMISTRY_SET_MODEL;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using E_APP02.SERVICES.SQL_SERVICES.SQL.SQL_SERVICES.SQL_SERVICES_CHEMISTRY;
using E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_MANAGER;
using E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_CHEMISTORY;
using E_APP02.TEMPLATE.TEXTS;

namespace E_APP02.SERVICES.SCIENCE_SERVICES.CHEMISTRY_SERVICES
{
    internal class Chemistry_Services
    {
        private  List<int> atomic_number = new List<int>();
        private  List<string> element_name = new List<string>();
        private  List<string> element_symboles = new List<string>();
        private  List<string> atomic_mass = new List<string>();
        private static Sql_Services02 Sql_Serv02 = new Sql_Services02();
        private static string[] data01 = new string[100];
        private  List<string> Alkali_Metals = new List<string>();
        private  List<string> Alkaline_Earth_Metals = new List<string>();
        private  List<string> Transition_Metals = new List<string>();
        private  List<string> Lanthanides_Rare_Earth_Metals = new List<string>();
        private  List<string> Noble_Gases = new List<string>();
        private  List<string> Actinides = new List<string>();
        private  List<string> Nonmetal_Gases_at_Room_Temperature = new List<string>();
        private  List<int> protons = new List<int>();
        private  List<int> electons = new List<int>();
        private  List<int> neutrons = new List<int>();
        private static Sqlite_Services01 Sqlite_Serv = new Sqlite_Services01();      
        public  List<Chemistry_Set_Model01> collectiondata01 = new List<Chemistry_Set_Model01>();
        public  List<Chemistry_Set_Model02> collectiondata02 = new List<Chemistry_Set_Model02>();
        private static Read_Textfiles01 READ01 = new Read_Textfiles01();
        private static Sql_Services01 Sql_Serv01= new Sql_Services01();
        public string[] data_array = {"Alkali Metals",//0
                                      "Alkaline Earth Metals",//1
                                      "Transition Metals",//2
                                      "Lanthanides Rare Earth Metals",//3
                                      "Noble Gases",//4
                                      "Actinides",//5
                                      "Nonmetal Gases at Room Temperature"//6

    };
        public string[] data_array01 = {"find element",//0
                                        "Seach by Catorogy",//1

        };

        public Chemistry_Services()
        {
            Sqlite_Manager01.InitializeAsync().Wait();
            load_find_Element_Textfile().Wait();
            category_elements_table();
        }

        private async Task load_find_Element_Textfile()
        {

            var cleanedElements = READ01.elements
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => line.Trim())
                .ToList();
            int count = 0;

            for (int i = 0; i < cleanedElements.Count; i++)
            {
                if (i % 3 == 0)
                {
                    count++;

                    atomic_number.Add(count);
                    protons.Add(count);
                    electons.Add(count);
                    element_name.Add(cleanedElements[i].ToLower());
                }
                else if (i % 3 == 1)
                {
                    element_symboles.Add(cleanedElements[i].ToLower());
                }
                else if (i % 3 == 2)
                {
                    string massString = cleanedElements[i]
                        .Replace("[", "")
                        .Replace("]", "")
                        .Replace(",", ".")
                        .Trim();
                    atomic_mass.Add(massString);
                    if (double.TryParse(massString, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double mass))
                    {
                        int roundedMass = (int)Math.Round(mass);
                        int neutronCount = Math.Max(0, roundedMass - count);
                        neutrons.Add(neutronCount);
                    }
                    else
                    {

                        neutrons.Add(0);
                    }
                }
            }

            for (int i = 0; i < atomic_number.Count; i++)
            {
                data01[0] += Sql_Serv02.insert_element(atomic_number[i],
                                                            element_name[i],
                                                            element_symboles[i],
                                                            atomic_mass[i],
                                                            protons[i],
                                                            electons[i],
                                                            neutrons[i]);
                data01[1] += await Sqlite_Serv.insert_element(
                atomic_number[i].ToString(),
                element_name[i],
                element_symboles[i],
                atomic_mass[i],
                protons[i].ToString(),
                electons[i].ToString(),
                neutrons[i].ToString());
           

            }
        }


        public string find_element_using_textfile(string input)
        {

            int index = element_name.IndexOf(input.ToLower());
            int index01 = element_symboles.IndexOf(input.ToLower());
            if (index != -1)
            {
                data01[2] = $"{atomic_number[index]}\n" +
                           $"{element_name[index]}\n" +
                           $"{element_symboles[index]}\n" +
                           $"{atomic_mass[index]}\n" +
                           $"{electons[index]}\n" +
                           $"{protons[index]}\n" +
                           $"{neutrons[index]}\n";


                var collection_set = new Chemistry_Set_Model01
                {

                    Atomic_number = atomic_number[index],
                    Element_name = element_name[index],
                    Element_symboles = element_symboles[index],
                    Atomic_mass = atomic_mass[index],
                    Electons = electons[index],
                    Protons = protons[index],
                    Neutrons = neutrons[index],
                };

                collectiondata01.Add(collection_set);

            }
            else if (index01 != -1)
            {
                data01[2] = $"{atomic_number[index01]}\n" +
                           $"{element_name[index01]}\n" +
                           $"{element_symboles[index01]}\n" +
                           $"{atomic_mass[index01]}\n" +
                           $"{electons[index01]}\n" +
                           $"{protons[index01]}\n" +
                           $"{neutrons[index01]}\n";


                var collection_set = new Chemistry_Set_Model01
                {

                    Atomic_number = atomic_number[index01],
                    Element_name = element_name[index01],
                    Element_symboles = element_symboles[index01],
                    Atomic_mass = atomic_mass[index01],
                    Electons = electons[index01],
                    Protons = protons[index01],
                    Neutrons = neutrons[index01],
                };

                collectiondata01.Add(collection_set);

            }
            else if (int.TryParse(input, out int number))
            {
                index = atomic_number.IndexOf(number);
                if (index >= 0 && index < atomic_number.Count)
                {
                    data01[2] = $"{atomic_number[index]}\n" +
                                $"{element_name[index]}\n" +
                                $"{element_symboles[index]}\n" +
                                $"{atomic_mass[index]}\n" +
                                $"{electons[index]}\n" +
                                $"{protons[index]}\n" +
                                $"{neutrons[index]}\n";
                    var collection_set = new Chemistry_Set_Model01
                    {

                        Atomic_number = atomic_number[index],
                        Element_name = element_name[index],
                        Element_symboles = element_symboles[index],
                        Atomic_mass = atomic_mass[index],
                        Electons = electons[index],
                        Protons = protons[index],
                        Neutrons = neutrons[index],
                    };

                    collectiondata01.Add(collection_set);
                }
            }
            else
            {
                data01[2] = Default_Text01.text02[2];
           
            }

            return $"{data01[2]}";

        }

        public string find_element_using_sql(string input)
        {

            if (Sql_Serv02.find_element_using_atomic_number(input) != Default_Text01.text02[2])
            {
                data01[4] = Sql_Serv02.find_element_using_atomic_number(input);
            }
            else if (Sql_Serv02.find_element_using_symbol(input) != Default_Text01.text02[2])
            {
                data01[4] = Sql_Serv02.find_element_using_symbol(input);
            }
            else if (Sql_Serv02.find_element_using_name(input) != Default_Text01.text02[2])
            {
                data01[4] = Sql_Serv02.find_element_using_name(input);
            }
            else
            {
                data01[4] = Default_Text01.text02[2];
            }

            return $"{data01[4]}";
        }

        public async Task<string> find_element_using_sqlite(string input)
        {
            if (SECURITY_SERVICES.Security_Services01.string_only_digit(input) == true)
            {
                if (await Sqlite_Serv.find_element_using_atomic_number(int.Parse(input)) != Default_Text01.text02[2])
                {
                    data01[5] = await Sqlite_Serv.find_element_using_atomic_number(int.Parse(input));
                }
                else
                {
                    data01[5] = Default_Text01.text02[2];

                }
            }
            else
            {
                if (await Sqlite_Serv.find_element_using_symbol(input) != Default_Text01.text02[2])
                {
                    data01[5] = await Sqlite_Serv.find_element_using_symbol(input);
                }
                else if (await Sqlite_Serv.find_element_using_name(input) != Default_Text01.text02[2])
                {
                    data01[5] = await Sqlite_Serv.find_element_using_name(input);
                }
                else
                {
                    data01[5] = Default_Text01.text02[2];
                }
            }




            return $"{data01[5]}";
        }


        public string view_all_elements_using_textfile()
        {
            collectiondata01.Clear();
            for (int i = 0; i < atomic_number.Count; i++)
            {
                data01[6] = $"{atomic_number[i]}\n" +
                             $"{element_name[i]}\n" +
                             $"{element_symboles[i]}\n" +
                             $"{atomic_mass[i]}\n" +
                             $"{electons[i]}\n" +
                            $"{protons[i]}\n" +
                           $"{neutrons[i]}\n";
                var collection_set = new Chemistry_Set_Model01
                {

                    Atomic_number = atomic_number[i],
                    Element_name = element_name[i],
                    Element_symboles = element_symboles[i],
                    Atomic_mass = atomic_mass[i],
                    Electons = electons[i],
                    Protons = protons[i],
                    Neutrons = neutrons[i],
                };

                collectiondata01.Add(collection_set);
            }

            return $"{data01[6]}";
        }



        public async Task<string> find_category_elements_using_sqlite(int input)
        {

            if (input == 0)
            {
                data01[7] = await Sqlite_Serv.find_Alkali_Metals();
            }
            else if (input ==1)
            {
                data01[7] = await Sqlite_Serv.Find_Actinides();
            }
            else if (input == 2)
            {
                data01[7] = await Sqlite_Serv.find_Alkaline_Earth_Metals();
            }
            else if (input == 3)
            {
                data01[7] = await Sqlite_Serv.find_Lanthanides_Rare_Earth_Metals();
            }
            else if (input == 4)
            {
                data01[7] = await Sqlite_Serv.find_Noble_Gases();
            }
            else if (input == 5)
            {
                data01[7] = await Sqlite_Serv.find_Nonmetal_Gases_at_Room_Temperature();
            }
            else if (input == 6)
            {
                data01[7] = await Sqlite_Serv.find_Transition_Metals();
            }
            else
            {
                data01[7] = "IDK";
            }

            return $"{data01[7]}";
        }

        public async Task<string> find_category_elements_using_sql(int input)
        {

            if (input == 0)
            {
                data01[8] = await Sql_Serv01.find_Alkali_Metals();
            }
            else if (input == 1)
            {
                data01[8] = await Sql_Serv01.Find_Actinides();
            }
            else if (input == 2)
            {
                data01[8] = await Sql_Serv01.find_Alkaline_Earth_Metals();
            }
            else if (input == 3)
            {
                data01[8] = await Sql_Serv01.find_Lanthanides_Rare_Earth_Metals();
            }
            else if (input == 4)
            {
                data01[8] = await Sql_Serv01.find_Noble_Gases();
            }
            else if (input == 5)
            {
                data01[8] = await Sql_Serv01.find_Nonmetal_Gases_at_Room_Temperature();
            }
            else if (input == 6)
            {
                data01[8] = await Sql_Serv01.find_Transition_Metals();
            }
            else
            {
                data01[8] = "IDK";
            }
            return $"{data01[8]}";
        }
        public string find_category_elements_table(int input)
        {


            if (input == 0)
            {
                for (int i = 0; i < Alkali_Metals.Count; i++)
                {
                    var collection_set = new Chemistry_Set_Model02
                    {
                        element_name = Alkali_Metals[i],

                    };
                    collectiondata02.Add(collection_set);

                }

                foreach (var a in Alkali_Metals)
                {

                    data01[9] += $"{a.Split('(')[0].Trim().ToLower()}\n";

                }

            }
            else if (input == 1)
            {
                for (int i = 0; i < Alkaline_Earth_Metals.Count; i++)
                {
                    var collection_set = new Chemistry_Set_Model02
                    {
                        element_name = Alkaline_Earth_Metals[i],
                    };
                    collectiondata02.Add(collection_set);


                }
                foreach (var a in Alkaline_Earth_Metals)
                {

                    data01[9] += $"{a.Split('(')[0].Trim().ToLower()}\n";

                }
            }


            else if (input == 2)
            {
                for (int i = 0; i < Transition_Metals.Count; i++)
                {
                    var collection_set = new Chemistry_Set_Model02
                    {
                        element_name = Transition_Metals[i],
                    };

                    collectiondata02.Add(collection_set);

                }
                foreach (var a in Transition_Metals)
                {

                    data01[9] += $"{a.Split('(')[0].Trim().ToLower()}\n";

                }
            }
            else if (input == 3)
            {
                for (int i = 0; i < Lanthanides_Rare_Earth_Metals.Count; i++)
                {
                    var collection_set = new Chemistry_Set_Model02
                    {
                        element_name = Lanthanides_Rare_Earth_Metals[i],
                    };

                    collectiondata02.Add(collection_set);

                }
                foreach (var a in Lanthanides_Rare_Earth_Metals)
                {

                    data01[9] += $"{a.Split('(')[0].Trim().ToLower()}\n";

                }
            }
            else if (input == 4)
            {
                for (int i = 0; i < Noble_Gases.Count; i++)
                {
                    var collection_set = new Chemistry_Set_Model02
                    {
                        element_name = Noble_Gases[i],
                    };

                    collectiondata02.Add(collection_set);

                }
                foreach (var a in Noble_Gases)
                {

                    data01[9] += $"{a.Split('(')[0].Trim().ToLower()}\n";

                }
            }
            else if (input == 5)
            {
                for (int i = 0; i < Actinides.Count; i++)
                {
                    var collection_set = new Chemistry_Set_Model02
                    {
                        element_name = Actinides[i],
                    };

                    collectiondata02.Add(collection_set);

                }
                foreach (var a in Actinides)
                {
                    data01[9] += $"{a.Split('(')[0].Trim().ToLower()}\n";

                }
            }
            else if (input == 6)
            {
                for (int i = 0; i < Nonmetal_Gases_at_Room_Temperature.Count; i++)
                {
                    var collection_set = new Chemistry_Set_Model02
                    {
                        element_name = Nonmetal_Gases_at_Room_Temperature[i],
                    };

                    collectiondata02.Add(collection_set);

                }
                foreach (var a in Nonmetal_Gases_at_Room_Temperature)
                {

                    data01[9] += $"{a.Split('(')[0].Trim().ToLower()}\n";

                }
            }
            else
            {
                data01[9] = "IDK";
            }


            return $"{data01[9]}";
        }


        private void category_elements_table()
        {

            string currentCategory = "";

            for (int i = 0; i < READ01.elements_category.Length; i++)
            {
                string line = READ01.elements_category[i].Trim();

                if (string.IsNullOrEmpty(line))
                    continue;

                if (line.Contains("Alkali Metals"))
                {
                    currentCategory = "Alkali Metals";
                    continue;
                }
                else if (line.Contains("Alkaline Earth Metals"))
                {
                    currentCategory = "Alkaline Earth Metals";
                    continue;
                }
                else if (line.Contains("Transition Metals"))
                {
                    currentCategory = "Transition Metals";
                    continue;
                }
                else if (line.Contains("Lanthanides Rare Earth Metals"))
                {
                    currentCategory = "Lanthanides Rare Earth Metals";
                    continue;
                }
                else if (line.Contains("Actinides"))
                {
                    currentCategory = "Actinides";
                    continue;
                }
                else if (line.Contains("Noble Gases"))
                {
                    currentCategory = "Noble Gases";
                    continue;
                }
                else if (line.Contains("Nonmetal Gases at Room Temperature"))
                {
                    currentCategory = "Nonmetal Gases at Room Temperature";
                    continue;
                }


                switch (currentCategory)
                {
                    case "Alkali Metals":
                        Alkali_Metals.Add(line);
                        break;
                    case "Alkaline Earth Metals":
                        Alkaline_Earth_Metals.Add(line);
                        break;
                    case "Transition Metals":
                        Transition_Metals.Add(line);
                        break;
                    case "Lanthanides Rare Earth Metals":
                        Lanthanides_Rare_Earth_Metals.Add(line);
                        break;
                    case "Actinides":
                        Actinides.Add(line);
                        break;
                    case "Noble Gases":
                        Noble_Gases.Add(line);
                        break;
                    case "Nonmetal Gases at Room Temperature":
                        Nonmetal_Gases_at_Room_Temperature.Add(line);
                        break;
                }

            }

        }
        public async Task<string> view_all_elements_using_sqlit()
        {

            data01[6] =await Sqlite_Serv.view_all_elements();

            return $"{data01[6]}";
        }

    }
}