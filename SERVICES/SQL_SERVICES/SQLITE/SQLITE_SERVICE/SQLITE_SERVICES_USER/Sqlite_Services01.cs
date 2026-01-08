using E_APP02.MODEL.SQLITE_MODEL.SQLITE_USERS.SQLITE_GET_MODEL;
using E_APP02.SERVICES.DEVICE_SERVICES;
using E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_MANAGER;
using E_APP02.TEMPLATE.TEXTS;
using SQLite;


namespace E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_USER
{
    internal class Sqlite_Services01
    {

        private static string[] data01 = new string[100];
        public string[] data_array = {"username","firstname","lastname",
                                             "birthdate", "email","phonenumber",
                                             "password","longitude","latitude",
                                             "creation_date"};
        private static Device_Services Device_Serv = new Device_Services(); 
        public async Task<string> Login(string username, string password)
        {
            var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                .Where(x => x.Username == username && x.Password == password)
                .FirstOrDefaultAsync();

            if (user != null)
            {
                return data01[0] = $"Success\n" +
                                   $"Username:{user.Username}\n" +
                                   $"Password:{user.Password}\n";
            }
            else
            {
                return data01[0] = Default_Text01.text02[2];
            }

        }

        public async Task<string> insert_user(string input01, string input02, string input03,
                                          string input04, string input05, string input06,
                                          string input07)
        {
            DateTime dateTime = DateTime.Now;
            string datenow = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string[] results = Device_Serv.get_device_ip().Result.Split(',');


            try
            {
                var user = new Sqlite_Get_Model01
                {
                    Username = input01,
                    Password = input02,
                    Firstname = input03,
                    Lastname = input04,
                    Birthdate = input05,
                    Email = input06,
                    Phonenumber = input07,
                    Longitude = results[0],
                    Latitude = results[1],
                    Creation_date = datenow,
                };

                await Sqlite_Manager01.conn[0].InsertAsync(user);
                data01[0] = Default_Text01.text02[3];
                return data01[0];
            }
            catch (SQLiteException ex)
            {

                data01[0] = $"{Default_Text01.text02[2]}n" +
                            $"{ex.Result}";

                return data01[0];
            }
        }

        public async Task<string> View_User_Table()
        {
            var users = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>().ToListAsync();
            foreach (var u in users)
            {
                data01[0] += $"Username: {u.Username}\n" +
                             $"Password:{u.Password}\n" +
                             $"Firstname:{u.Firstname}\n" +
                             $"Lastname:{u.Lastname}\n" +
                             $"Birthdate:{u.Birthdate}\n" +
                             $"Email:{u.Email}\n" +
                             $"Phonenumber:{u.Phonenumber}\n" +
                             $"Longitude:{u.Longitude}\n" +
                             $"Latitude:{u.Latitude}\n" +
                             $"Creation_date:{u.Creation_date}\n";
            }
            return data01[0];
        }
        public async Task<string> find_email_using_email(string input)
        {
            var a = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
    .Where(x => x.Email == input)
    .FirstOrDefaultAsync();

            if (a != null)
            {
                return data01[0] = $"{a.Email}";
            }
            else
            {
                return data01[0] = Default_Text01.text02[2];
            }
        }

        public async Task<string> find_phonenumber_using_email(string input)
        {
            var a = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
    .Where(x => x.Email == input)
    .FirstOrDefaultAsync();

            if (a != null)
            {
                return data01[0] = $"{a.Phonenumber}";
            }
            else
            {
                return data01[0] = Default_Text01.text02[2];
            }
        }
        public async Task<string> find_phonenumber_using_username(string input)
        {
            var a = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
    .Where(x => x.Username == input)
    .FirstOrDefaultAsync();

            if (a != null)
            {
                return data01[0] = $"{a.Phonenumber}";
            }
            else
            {
                return data01[0] = Default_Text01.text02[2];
            }
        }
        public async Task<string> find_phonenumber_using_phonenumber(string input)
        {
            var a = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
    .Where(x => x.Phonenumber == input)
    .FirstOrDefaultAsync();

            if (a != null)
            {
                return data01[0] = $"{a.Phonenumber}";
            }
            else
            {
                return data01[0] = Default_Text01.text02[2];
            }
        }
        public async Task<string> find_user_location_using_email(string input)
        {
            var a = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
    .Where(x => x.Email == input)
    .FirstOrDefaultAsync();

            if (a != null)
            {
                return data01[0] = $"{a.Latitude}\n" +
                                 $"{a.Longitude}\n";
            }
            else
            {
                return data01[0] = Default_Text01.text02[2];
            }
        }
        public async Task<string> find_user_location_using_username(string input)
        {
            var a = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
    .Where(x => x.Username == input)
    .FirstOrDefaultAsync();

            if (a != null)
            {
                return data01[0] = $"{a.Latitude}\n" +
                                   $"{a.Longitude}\n";
            }
            else
            {
                return data01[0] = Default_Text01.text02[2];
            }
        }
        public async Task<string> find_username_using_email(string input)
        {
            var a = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
    .Where(x => x.Email == input)
    .FirstOrDefaultAsync();

            if (a != null)
            {
                return data01[0] = $"{a.Username}";
            }
            else
            {
                return data01[0] = Default_Text01.text02[2];
            }
        }
        public async Task<string> find_username_using_username(string input)
        {
            var a = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
    .Where(x => x.Username == input)
    .FirstOrDefaultAsync();

            if (a != null)
            {
                return data01[0] = $"{a.Username}";
            }
            else
            {
                return data01[0] = Default_Text01.text02[2];
            }
        }
        public async Task<string> find_password_using_email(string input)
        {
            var a = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
    .Where(x => x.Email == input)
    .FirstOrDefaultAsync();

            if (a != null)
            {
                return data01[0] = $"{a.Password}";
            }
            else
            {
                return data01[0] = Default_Text01.text02[2];
            }
        }
        public async Task<string> find_password_using_username(string input)
        {
            var a = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
    .Where(x => x.Username == input)
    .FirstOrDefaultAsync();

            if (a != null)
            {
                return data01[0] = $"{a.Password}";
            }
            else
            {
                return data01[0] = Default_Text01.text02[2];
            }
        }
        public async Task<string> update_phonenumber_using_email(string input01, string input02)
        {
       
                var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                    .Where(x => x.Email == input01)
                    .FirstOrDefaultAsync();
                if (user != null)
                {
                    user.Phonenumber = input02;
                    await Sqlite_Manager01.conn[0].UpdateAsync(user);
                    data01[0] = Default_Text01.text02[4];
                    return data01[0];
                }
                else
                {
                    data01[0] = Default_Text01.text02[2];
                    return data01[0];
                }
 
        }
        public async Task<string> update_phonenumber_using_username(string input01, string input02)
        {

            var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                .Where(x => x.Username == input01)
                .FirstOrDefaultAsync();
            if (user != null)
            {
                user.Phonenumber = input02;
                await Sqlite_Manager01.conn[0].UpdateAsync(user);
                data01[0] = Default_Text01.text02[4];
                return data01[0];
            }
            else
            {
                data01[0] = Default_Text01.text02[2];
                return data01[0];
            }

        }
        public async Task<string> update_email_using_username(string input01, string input02)
        {

            var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                .Where(x => x.Username == input01)
                .FirstOrDefaultAsync();
            if (user != null)
            {
                user.Email = input02;
                await Sqlite_Manager01.conn[0].UpdateAsync(user);
                data01[0] = Default_Text01.text02[4];
                return data01[0];
            }
            else
            {
                data01[0] = Default_Text01.text02[2];
                return data01[0];
            }

        }
        public async Task<string> update_email_using_email(string input01,string input02)
        {

            var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                .Where(x => x.Email == input01)
                .FirstOrDefaultAsync();
            if (user != null)
            {
                user.Email = input02;
                await Sqlite_Manager01.conn[0].UpdateAsync(user);
                data01[0] = Default_Text01.text02[4];
                return data01[0];
            }
            else
            {
                data01[0] = Default_Text01.text02[2];
                return data01[0];
            }

        }
        public async Task<string> update_username_using_email(string input01, string input02)
        {

            var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                .Where(x => x.Username == input01)
                .FirstOrDefaultAsync();
            if (user != null)
            {
                user.Email = input02;
                await Sqlite_Manager01.conn[0].UpdateAsync(user);
                data01[0] = Default_Text01.text02[4];
                return data01[0];
            }
            else
            {
                data01[0] = Default_Text01.text02[2];
                return data01[0];
            }

        }
        public async Task<string> update_username_using_username(string input01, string input02)
        {

            var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                .Where(x => x.Username == input01)
                .FirstOrDefaultAsync();
            if (user != null)
            {
                user.Username = input02;
                await Sqlite_Manager01.conn[0].UpdateAsync(user);
                data01[0] = Default_Text01.text02[4];
                return data01[0];
            }
            else
            {
                data01[0] = Default_Text01.text02[2];
                return data01[0];
            }

        }
        public async Task<string> update_username_using_phonenumber(string input01, string input02)
        {

            var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                .Where(x => x.Username == input01)
                .FirstOrDefaultAsync();
            if (user != null)
            {
                user.Phonenumber = input02;
                await Sqlite_Manager01.conn[0].UpdateAsync(user);
                data01[0] = Default_Text01.text02[4];
                return data01[0];
            }
            else
            {
                data01[0] = Default_Text01.text02[2];
                return data01[0];
            }

        }
        public async Task<string> update_password_using_username(string input01, string input02)
        {

            var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                .Where(x => x.Username == input01)
                .FirstOrDefaultAsync();
            if (user != null)
            {
                user.Password = input02;
                await Sqlite_Manager01.conn[0].UpdateAsync(user);
                data01[0] = Default_Text01.text02[4];
                return data01[0];
            }
            else
            {
                data01[0] = Default_Text01.text02[2];
                return data01[0];
            }

        }
        public async Task<string> update_password_using_email(string input01, string input02)
        {

            var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                .Where(x => x.Email == input01)
                .FirstOrDefaultAsync();
            if (user != null)
            {
                user.Password = input02;
                await Sqlite_Manager01.conn[0].UpdateAsync(user);
                data01[0] = Default_Text01.text02[4];
                return data01[0];
            }
            else
            {
                data01[0] = Default_Text01.text02[2];
                return data01[0];
            }

        }
        public async Task<string> update_password_using_phonenumber(string input01, string input02)
        {

            var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                .Where(x => x.Phonenumber == input01)
                .FirstOrDefaultAsync();
            if (user != null)
            {
                user.Password = input02;
                await Sqlite_Manager01.conn[0].UpdateAsync(user);
                data01[0] = Default_Text01.text02[4];
                return data01[0];
            }
            else
            {
                data01[0] = Default_Text01.text02[2];
                return data01[0];
            }

        }
        public async Task<string> delete_user_using_email(string input)
        {
            var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                .Where(x => x.Email == input)
                .FirstOrDefaultAsync();
            if (user != null)
            {
                await Sqlite_Manager01.conn[0].DeleteAsync(user);
                data01[0] = Default_Text01.text02[5];
                return data01[0];
            }
            else
            {
                data01[0] = Default_Text01.text02[2];
                return data01[0];
            }
        }
        public async Task<string> delete_user_using_username(string input)
        {
            var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                .Where(x => x.Username == input)
                .FirstOrDefaultAsync();
            if (user != null)
            {
                await Sqlite_Manager01.conn[0].DeleteAsync(user);
                data01[0] = Default_Text01.text02[5];
                return data01[0];
            }
            else
            {
                data01[0] = Default_Text01.text02[2];
                return data01[0];
            }
        }
        public async Task<string> delete_user_using_phonenumber(string input)
        {
            var user = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>()
                .Where(x => x.Phonenumber == input)
                .FirstOrDefaultAsync();
            if (user != null)
            {
                await Sqlite_Manager01.conn[0].DeleteAsync(user);
                data01[0] = Default_Text01.text02[5];
                return data01[0];
            }
            else
            {
                data01[0] = Default_Text01.text02[2];
                return data01[0];
            }
        }
        public async Task<string> view_all_passwords()
        {
            var users = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>().ToListAsync();
            foreach (var u in users)
            {
                data01[0] +=$"{u.Password}\n";

            }
            return data01[0];
        }
        public async Task<string> view_all_uernames()
        {
            var users = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>().ToListAsync();
            foreach (var u in users)
            {
                data01[0] += $"{u.Username}\n";

            }
            return data01[0];
        }
        public async Task<string> view_all_email()
        {
            var users = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>().ToListAsync();
            foreach (var u in users)
            {
                data01[0] += $"{u.Email}\n";

            }
            return data01[0];
        }
        public async Task<string> view_all_phoneumber()
        {
            var users = await Sqlite_Manager01.conn[0].Table<Sqlite_Get_Model01>().ToListAsync();
            foreach (var u in users)
            {
                data01[0] += $"{u.Phonenumber}\n";

            }
            return data01[0];
        }

    }
}