using E_APP02.MODEL.SQLITE_MODEL.SQLITE_DEVICES.SQLITE_GET_MODEL;
using E_APP02.MODELS.DEVICE_MODEL.DEVICE_GET_MODEL;
using E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_MANAGER;
using E_APP02.TEMPLATE.TEXTS;

namespace E_APP02.SERVICES.SQL_SERVICES.SQLITE.SQLITE_SERVICE.SQLITE_SERVICES_DEVICES
{
    internal class Sqlite_Services01
    {
        private static readonly string[] data01 = new string[100];

        public  async Task<string> insert_device_table(
         string input01, string input02, string input03,
         string input04, string input05, string input06,
         string input07)
        {

            try
            {
                var user = new Device_Get_Model01
                {
                    Manufacturer = input01,
                    Model = input02,
                    Name01 = input03,
                    VersionString = input04,
                    Platform01 = input05,
                    Idiom = input06,
                    DeviceType = input07,
                };

                await Sqlite_Manager01.conn[3].InsertAsync(user);

                data01[0] = Default_Text01.text02[3]; // "Inserted Successfully"
                return data01[0];
            }
            catch (Exception ex)
            {
                data01[0] = $"{Default_Text01.text02[2]}\n{ex.Message}";
                return data01[0];
            }

        }
        public async Task<string> find_device_by_ip(string input)
        {
            var resualt = await Sqlite_Manager01.conn[3].Table<Sqlite_Model01>()
                .Where(x => x.IP == input)
                .FirstOrDefaultAsync();
            if (resualt != null)
            {
                return data01[1] = $"IP: {resualt.IP}\n" +
                                   $"Country: {resualt.Country}\n" +
                                   $"Region: {resualt.Region}\n" +
                                   $"City: {resualt.City}\n" +
                                   $"ISP: {resualt.ISP}\n" +
                                   $"Lat: {resualt.Lat}\n" +
                                   $"Lon: {resualt.Lon}\n";
    }
            else
            {
                return data01[1] = Default_Text01.text02[2];
            }
        }

        public  async Task<string> view_device_table()
        {
            data01[2] = string.Empty;
            try
            {
                var users = await Sqlite_Manager01.conn[3].Table<Device_Get_Model01>().ToListAsync();
                foreach (var user in users)
                {
                    data01[2] +=
                                  $"Manufacturer: {user.Manufacturer}\n" +
                                  $"Model: {user.Model}\n" +
                                  $"Name01: {user.Name01}\n" +
                                  $"VersionString: {user.VersionString}\n" +
                                  $"Platform01: {user.Platform01}\n" +
                                  $"Idiom: {user.Idiom}\n" +
                                  $"DeviceType: {user.DeviceType}\n\n";
                }
                return data01[2];
            }
            catch (Exception ex)
            {
                data01[2] = $"{Default_Text01.text02[2]}\n{ex.Message}";
                return data01[2];
            }
        }
    }
}