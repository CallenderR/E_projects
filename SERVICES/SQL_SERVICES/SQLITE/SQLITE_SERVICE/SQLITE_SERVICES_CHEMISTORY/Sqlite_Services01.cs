using E_APP02.MODEL.SQLITE_MODEL.SQLITE_CHEMISTRY.SQLITE_GET_MODEL;
using E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_MANAGER;
using E_APP02.TEMPLATE.TEXTS;
using SQLite;



namespace E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_CHEMISTORY
{
    internal class Sqlite_Services01
    {
        private static string[] data01 = new string[100];


        public  async Task<string> insert_element(
         string input01, string input02, string input03,
         string input04, string input05, string input06,
         string input07)
        {
            int atomicNumber = int.Parse(input01);

            // Check correctly in database 1
            var existing = await Sqlite_Manager01.conn[1]
                .Table<Sqlite_Get_Model01>()
                .Where(x => x.atomic_number == atomicNumber ||
                            x.element_symboles == input03)
                .FirstOrDefaultAsync();

            if (existing != null)
            {
                data01[0] = "Record already exists";
                return data01[0];
            }
            else
            {
                try
                {
                    var user = new Sqlite_Get_Model01
                    {
                        atomic_number = atomicNumber,
                        element_name = input02,
                        element_symboles = input03,
                        atomic_mass = input04,
                        protons = input05,
                        electons = input06,
                        neutrons = input07,
                    };

                    await Sqlite_Manager01.conn[1].InsertAsync(user);

                    data01[0] = Default_Text01.text02[3]; // "Inserted Successfully"
                    return data01[0];
                }
                catch (SQLiteException ex)
                {
                    data01[0] = $"{Default_Text01.text02[2]}\n{ex.Message}";
                    return data01[0];
                }
                catch (Exception ex)
                {
                    data01[0] = $"{Default_Text01.text02[2]}\n{ex.Message}";
                    return data01[0];
                }

            }


        }
        public  async Task<string> find_element_using_name(string input)
        {
            var element = await Sqlite_Manager01.conn[1].Table<Sqlite_Get_Model01>()
                .Where(x => x.element_name == input)
                .FirstOrDefaultAsync();
            if (element != null)
            {
                return data01[1] = $"Success\n" +
                                   $"Element Name: {element.element_name}\n" +
                                   $"Atomic Number: {element.atomic_number}\n" +
                                   $"Element Symboles: {element.element_symboles}\n" +
                                   $"protons: {element.protons}\n" +
                                   $"electons: {element.electons}\n" +
                                   $"neutrons: {element.neutrons}\n";
            }
            else
            {
                return data01[1] = Default_Text01.text02[2];
            }
        }
        public  async Task<string> find_element_using_atomic_number(int input)
        {
            var element = await Sqlite_Manager01.conn[1].Table<Sqlite_Get_Model01>()
                .Where(x => x.atomic_number ==input)
                .FirstOrDefaultAsync();
            if (element != null)
            {
                return data01[2] = $"Success\n" +
                                   $"Element Name: {element.element_name}\n" +
                                   $"Atomic Number: {element.atomic_number}\n" +
                                   $"Element Symboles: {element.element_symboles}\n" +
                                   $"Atomic Mass: {element.atomic_mass}\n" +
                                   $"protons: {element.protons}\n" +
                                   $"electons: {element.electons}\n" +
                                   $"neutrons: {element.neutrons}\n";
            }
            else
            {
                return data01[2] = Default_Text01.text02[2];
            }
        }
        public  async Task<string> find_element_using_symbol(string input)
        {
            var element = await Sqlite_Manager01.conn[1].Table<Sqlite_Get_Model01>()
                .Where(x => x.element_symboles == input)
                .FirstOrDefaultAsync();
            if (element != null)
            {
                return data01[3] = $"Success\n" +
                                   $"Element Name: {element.element_name}\n" +
                                   $"Atomic Number: {element.atomic_number}\n" +
                                   $"Element Symboles: {element.element_symboles}\n" +
                                   $"Atomic Mass: {element.atomic_mass}\n" +
                                   $"protons: {element.protons}\n" +
                                   $"electons: {element.electons}\n" +
                                   $"neutrons: {element.neutrons}\n";
            }
            else
            {
                return data01[3] = Default_Text01.text02[2];
            }
        }

        public  async Task<string> find_element_using_symbol()
        {
            var elements = await Sqlite_Manager01.conn[1].Table<Sqlite_Get_Model01>()
                .ToListAsync();
            if (elements.Count > 0)
            {

                foreach (var element in elements)
                {
                    data01[4] += $"Element Name: {element.element_name}, " +
                              $"Atomic Number: {element.atomic_number}, " +
                              $"Element Symboles: {element.element_symboles}, " +
                              $"Atomic Mass: {element.atomic_mass}\n" +
                              $"protons: {element.protons}\n" +
                              $"electons: {element.electons}\n" +
                              $"neutrons: {element.neutrons}\n";
                }
                return data01[4];
            }
            else
            {
                return data01[4] = Default_Text01.text02[2];
            }
        }
        public  async Task<string> view_all_elements()
        {
            var elements = await Sqlite_Manager01.conn[1].Table<Sqlite_Get_Model01>().ToListAsync();

            if (elements.Count > 0)
            {
                foreach (var element in elements)
                {
                    data01[5] += $"Element Name: {element.element_name}, " +
                              $"Atomic Number: {element.atomic_number}, " +
                              $"Element Symboles: {element.element_symboles}, " +
                              $"Atomic Mass: {element.atomic_mass}\n" +
                              $"protons: {element.protons}\n" +
                              $"electons: {element.electons}\n" +
                              $"neutrons: {element.neutrons}\n";
                }
                return data01[5];
            }
            else
            {
                return data01[5] = Default_Text01.text02[2];
            }
        }
        public  async Task<string> insert_catagory_type(string input01, string input02, string input03, string input04,
                                                             string input05, string input06, string input07)
        {
            var existing = await Sqlite_Manager01.conn[1]
            .Table<Sqlite_Get_Model02>()
            .Where(x => x.Alkali_Metals == input01 || x.Alkaline_Earth_Metals == input03)
            .FirstOrDefaultAsync();
            if (existing != null)
            {
                try
                {
                    var user = new Sqlite_Get_Model02
                    {

                        Alkali_Metals = input02,
                        Alkaline_Earth_Metals = input02,
                        Transition_Metals = input02,
                        Lanthanides_Rare_Earth_Metals = input02,
                        Noble_Gases = input02,
                        Actinides = input02,
                        Nonmetal_Gases_at_Room_Temperature = input02,
                    };

                    await Sqlite_Manager01.conn[2].InsertAsync(user);
                    data01[6] = Default_Text01.text02[3];
                    return data01[6];
                }
                catch (SQLiteException ex)
                {

                    data01[6] = $"{Default_Text01.text02[2]}n" +
                                $"{ex.Result}";

                    return data01[6];
                }
            }
            else
            {
                data01[6] = $"Record already exists";
                return data01[6];
            }

        }
        public  async Task<string> find_Alkali_Metals()
        {
            var elements = await Sqlite_Manager01.conn[2].Table<Sqlite_Get_Model02>()
                .ToListAsync();
            if (elements.Count > 0)
            {
                foreach (var element in elements)
                {
                    data01[7] += $"Alkali Metals: {element.Alkali_Metals}\n";
                }
                return data01[7];
            }
            else
            {
                return data01[7] = Default_Text01.text02[2];
            }
        }
        public  async Task<string> Find_Actinides()
        {
            var elements = await Sqlite_Manager01.conn[2].Table<Sqlite_Get_Model02>()
                .ToListAsync();
            if (elements.Count > 0)
            {
                foreach (var element in elements)
                {
                    data01[8] += $"Actinides: {element.Actinides}\n";
                }
                return data01[8];
            }
            else
            {
                return data01[8] = Default_Text01.text02[2];
            }
        }
        public  async Task<string> find_Alkaline_Earth_Metals()
        {
            var elements = await Sqlite_Manager01.conn[2].Table<Sqlite_Get_Model02>()
                .ToListAsync();
            if (elements.Count > 0)
            {
                foreach (var element in elements)
                {
                    data01[9] += $"Alkaline Earth Metals: {element.Alkaline_Earth_Metals}\n";
                }
                return data01[9];
            }
            else
            {
                return data01[9] = Default_Text01.text02[2];
            }
        }
        public  async Task<string> find_Lanthanides_Rare_Earth_Metals()
        {
            var elements = await Sqlite_Manager01.conn[2].Table<Sqlite_Get_Model02>()
                .ToListAsync();
            if (elements.Count > 0)
            {
                foreach (var element in elements)
                {
                    data01[10] += $"Lanthanides Rare Earth Metals: {element.Lanthanides_Rare_Earth_Metals}\n";
                }
                return data01[10];
            }
            else
            {
                return data01[10] = Default_Text01.text02[2];
            }
        }
        public  async Task<string> find_Noble_Gases()
        {
            var elements = await Sqlite_Manager01.conn[2].Table<Sqlite_Get_Model02>()
                .ToListAsync();
            if (elements.Count > 0)
            {
                foreach (var element in elements)
                {
                    data01[11] += $"Noble Gases: {element.Noble_Gases}\n";
                }
                return data01[11];
            }
            else
            {
                return data01[11] = Default_Text01.text02[2];
            }
        }
        public  async Task<string> find_Nonmetal_Gases_at_Room_Temperature()
        {

            var elements = Sqlite_Manager01.conn[2].Table<Sqlite_Get_Model02>()
                .ToListAsync().Result;
            if (elements.Count > 0)
            {
                foreach (var element in elements)
                {
                    data01[12] += $"Nonmetal Gases at Room Temperature: {element.Nonmetal_Gases_at_Room_Temperature}\n";
                }
                return data01[12];
            }
            else
            {
                return data01[12] = Default_Text01.text02[2];
            }
        }
        public  async Task<string> find_Transition_Metals()
        {
            var elements = await Sqlite_Manager01.conn[2].Table<Sqlite_Get_Model02>()
                .ToListAsync();
            if (elements.Count > 0)
            {
                foreach (var element in elements)
                {
                    data01[13] += $"Transition Metals: {element.Transition_Metals}\n";
                }
                return data01[13];
            }
            else
            {
                return data01[13] = Default_Text01.text02[2];
            }
        }
        public  async Task<string> view_catagory_type()
        {
            var elements = await Sqlite_Manager01.conn[2].Table<Sqlite_Get_Model02>()
                .ToListAsync();
            if (elements.Count > 0)
            {
                foreach (var element in elements)
                {
                    data01[14] += $"Alkali Metals: {element.Alkali_Metals}, " +
                                  $"Alkaline Earth Metals: {element.Alkaline_Earth_Metals}, " +
                                  $"Transition Metals: {element.Transition_Metals}, " +
                                  $"Lanthanides Rare Earth Metals: {element.Lanthanides_Rare_Earth_Metals}, " +
                                  $"Noble Gases: {element.Noble_Gases}, " +
                                  $"Actinides: {element.Actinides}, " +
                                  $"Nonmetal Gases at Room Temperature: {element.Nonmetal_Gases_at_Room_Temperature}\n";
                }
                return data01[14];
            }
            else
            {
                return data01[14] = Default_Text01.text02[2];
            }
        }
    }
}