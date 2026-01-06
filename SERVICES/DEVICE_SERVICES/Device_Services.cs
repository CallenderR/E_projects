
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;
using Fileprompt;
using Newtonsoft.Json.Linq;
using System.Buffers.Text;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;


namespace E_APP02.SERVICES.DEVICE_SERVICES
{
    internal class Device_Services
    {
        private  string[] data01 = new string[100];
        private static Read_Textfiles01 READ = new Read_Textfiles01();
        public string launch_default_browser(string url)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
            data01[0] = "Success";
            return data01[0];
        }
        public  async Task<string> get_device_ip()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://ipinfo.io/json";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(json);
                data01[1] += $"{data["ip"]?.ToString()}\n" +
                            $"{data["city"]?.ToString()}\n" +
                            $"{data["region"]?.ToString()}\n" +
                            $"{data["country"]?.ToString()}\n" +
                            $"{data["loc"]?.ToString()}\n";

                return $"{data["loc"]?.ToString()}\n";
            }
        }
        public async Task<string> image_to_url(string input)
        {
            var account = new Account(
                  $"{READ.CloudinaryDotNet_info[0].Trim()}",   // <-- Replace with your Cloudinary cloud name
                  $"{READ.api[1].Trim()}",      // <-- Replace with your Cloudinary API key
                  $"{READ.CloudinaryDotNet_info[1].Trim()}"    // <-- Replace with your Cloudinary API secret
              );

            var cloudinary = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription($"{input.Trim()}"),
                UseFilename = true,
                UniqueFilename = false,
                Overwrite = true
            };

            // 4. Upload image
            var uploadResult = await cloudinary.UploadAsync(uploadParams);

            if (uploadResult.StatusCode == HttpStatusCode.OK)
            {
                data01[2] = $"URL: {uploadResult.SecureUrl}\n" +
                            $"Status: {uploadResult.Status}\n" +
                            $"StatusCode: {uploadResult.StatusCode}\n" +
                            $"Signature: {uploadResult.Signature}\n" +
                            $"Version: {uploadResult.Version}";

            }
            else
            {
                data01[2] = $"Upload failed: {uploadResult.Error?.Message ?? "Unknown error"}";
            }
            return $"{uploadResult.SecureUrl}\n";

        }
        public async Task<string> image_url_to_file(string input)
        {
            // input = image URL
            string folderPath = @"C:\Photo01";
            Directory.CreateDirectory(folderPath);
            // Generate a unique filename from timestamp or GUID
            string fileName = "downloaded_image_" + DateTime.Now.Ticks + ".jpg";
            string fullPath = Path.Combine(folderPath, fileName);

            using (HttpClient client = new HttpClient())
            {

                byte[] imageBytes = await client.GetByteArrayAsync(input);
                await File.WriteAllBytesAsync(fullPath, imageBytes);
                data01[3] =fullPath;

            }

            return data01[3];
        }
        public string open_files_using_windows(string input)
        {

            if (File.Exists(input.Trim()) == true)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = $"{input.Trim()}",
                    UseShellExecute = true
                });
                data01[4] = "Success";
            }
            else
            {
                data01[4] = "Fail";
            }
            return data01[4];

        }
        public  async Task<string> image_file_to_base64(string input)
        {

            byte[] imageBytes = File.ReadAllBytes(input);
            data01[5] = Convert.ToBase64String(imageBytes);
            return data01[5];
        }

        /*   public static async Task<string> take_photo()
           {
               var photo = await MediaPicker.Default.CapturePhotoAsync();
               if (photo != null)
               {
                   var newFile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
                   using var stream = await photo.OpenReadAsync();
                   using var newStream = File.OpenWrite(newFile);
                   await stream.CopyToAsync(newStream);
                   data01[6] = newFile;
               }
               else
               {
                   data01[6] = "Photo not taken";
               }
               return data01[6];
           }*/
        /* public static async Task<string> choose_photo()
         {
             var photo = await MediaPicker.Default.PickPhotoAsync();

             if (photo != null)
             {
                 var newFile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                 using var stream = await photo.OpenReadAsync();
                 using var newStream = File.OpenWrite(newFile);

                 await stream.CopyToAsync(newStream);

                 data01[8] = newFile; // store file path
             }
             else
             {
                 data01[8] = "No photo selected";
             }

             return data01[0];
         }*/


        /*    public static async Task<string> take_photo_to_url()
            {
                var account = new Account(
                     $"{READ.CloudinaryDotNet_info[0].Trim()}",   // <-- Replace with your Cloudinary cloud name
                     $"{READ.api[1].Trim()}",      // <-- Replace with your Cloudinary API key
                     $"{READ.CloudinaryDotNet_info[1].Trim()}"    // <-- Replace with your Cloudinary API secret
                 );

                var cloudinary = new Cloudinary(account);
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription($"{await take_photo()}"),
                    UseFilename = true,
                    UniqueFilename = false,
                    Overwrite = true
                };

                // 4. Upload image
                var uploadResult = cloudinary.Upload(uploadParams);

                // 5. Output public URL
                if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    data01[9] += $"{uploadResult.SecureUrl.ToString().Trim()}";
                }
                else
                {
                    data01[9] = $"Upload failed:\n";
                }
                return data01[9];
            }*/

        /* public static async Task<string> GetDeviceLocationAsync()
         {


             var location = await Geolocation.Default.GetLocationAsync(
                 new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10)));

             if (location != null)
             {
                 data01[10] = $"{location.Latitude}\n" +
                             $"{location.Longitude}\n";
             }
             else
             {
                 data01[10] = "Unable to retrieve location.";
             }
             return data01[10];
         }*/
        /* public static string get_cellphone_device_info()
         {

             data01[11] += $"{DeviceInfo.Manufacturer}\n" +
                          $"{DeviceInfo.Model}\n" +
                          $"{DeviceInfo.Name}\n" +
                          $"{DeviceInfo.VersionString}\n" +
                          $"{DeviceInfo.Platform.ToString()}\n" +
                          $"{DeviceInfo.Idiom.ToString()}\n" +
                          $"{DeviceInfo.DeviceType.ToString()}\n";

             return data01[11];
         }*/

        public  string get_windows_info()
        {
            ManagementClass managementClass = new("Win32_Processor");
            foreach (ManagementObject managementObject in managementClass.GetInstances())
            {
                data01[12] += "--- Processor information ---\n" +
                              $"Name: {managementObject["Name"]}\n" +
                              $"Architecture: {managementObject["Architecture"]}\n";
            }

            // Stopped services
            SelectQuery selectQuery = new("Win32_Service", "State = 'Stopped'");
            ManagementObjectSearcher managementObjectSearcher = new(selectQuery);
            foreach (ManagementObject service in managementObjectSearcher.Get())
            {
                data01[12] += service.ToString();
            }

            // Baseboard (Motherboard)
            ManagementObjectSearcher baseBoard = new("SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject board in baseBoard.Get())
            {
                data01[12] += "--- BaseBoard information ---\n" +
                              $"Manufacturer: {board["Manufacturer"]}\n" +
                              $"Product: {board["Product"]}\n" +
                              $"SerialNumber: {board["SerialNumber"]}\n";
            }

            // Operating System
            ManagementObjectSearcher os = new("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject o in os.Get())
            {
                data01[12] += "--- Operating System information ---\n" +
                              $"Caption: {o["Caption"]}\n" +
                              $"Version: {o["Version"]}\n" +
                              $"Manufacturer: {o["Manufacturer"]}\n" +
                              $"OSArchitecture: {o["OSArchitecture"]}\n";
            }

            // BIOS
            ManagementObjectSearcher bios = new("SELECT * FROM Win32_BIOS");
            foreach (ManagementObject b in bios.Get())
            {
                data01[12] += "--- BIOS information ---\n" +
                              $"Manufacturer: {b["Manufacturer"]}\n" +
                              $"SMBIOSBIOSVersion: {b["SMBIOSBIOSVersion"]}\n" +
                              $"SerialNumber: {b["SerialNumber"]}\n";
            }

            // Computer System
            ManagementObjectSearcher os2 = new("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject o in os2.Get())
            {
                data01[12] += "--- Computer System information ---\n" +
                              $"Manufacturer: {o["Manufacturer"]}\n" +
                              $"Model: {o["Model"]}\n" +
                              $"TotalPhysicalMemory: {o["TotalPhysicalMemory"]}\n";
            }

            // Logical Disk
            ManagementObjectSearcher bios2 = new("SELECT * FROM Win32_LogicalDisk WHERE DeviceID='C:'");
            foreach (ManagementObject d in bios2.Get())
            {
                data01[12] += "--- Logical Disk C: information ---\n" +
                              $"FileSystem: {d["FileSystem"]}\n" +
                              $"FreeSpace: {d["FreeSpace"]}\n" +
                              $"Size: {d["Size"]}\n";
            }

            // Network Adapter Configuration
            ManagementObjectSearcher os3 = new("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled=true");
            foreach (ManagementObject n in os3.Get())
            {
                data01[12] += "--- Network Adapter information ---\n" +
                              $"Description: {n["Description"]}\n" +
                              $"MACAddress: {n["MACAddress"]}\n" +
                              $"IPAddress: {string.Join(", ", (string[])n["IPAddress"])}\n";
            }

            // Time Zone
            ManagementObjectSearcher os4 = new("SELECT * FROM Win32_TimeZone");
            foreach (ManagementObject t in os4.Get())
            {
                data01[12] += "--- Time Zone information ---\n" +
                              $"Caption: {t["Caption"]}\n" +
                              $"Bias: {t["Bias"]}\n" +
                              $"StandardName: {t["StandardName"]}\n";
            }

            // Video Controller
            ManagementObjectSearcher bios4 = new("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject v in bios4.Get())
            {
                data01[12] += "--- Video Controller information ---\n" +
                              $"Name: {v["Name"]}\n" +
                              $"AdapterRAM: {v["AdapterRAM"]}\n" +
                              $"DriverVersion: {v["DriverVersion"]}\n";
            }

            // Printer
            ManagementObjectSearcher os5 = new("SELECT * FROM Win32_Printer");
            foreach (ManagementObject p in os5.Get())
            {
                data01[12] += "--- Printer information ---\n" +
                              $"Name: {p["Name"]}\n" +
                              $"PortName: {p["PortName"]}\n" +
                              $"DriverName: {p["DriverName"]}\n";
            }

            // Sound Device
            ManagementObjectSearcher bios5 = new("SELECT * FROM Win32_SoundDevice");
            foreach (ManagementObject s in bios5.Get())
            {
                data01[12] += "--- Sound Device information ---\n" +
                              $"Name: {s["Name"]}\n" +
                              $"Manufacturer: {s["Manufacturer"]}\n" +
                              $"Status: {s["Status"]}\n";
            }

            // Battery
            ManagementObjectSearcher os6 = new("SELECT * FROM Win32_Battery");
            foreach (ManagementObject b in os6.Get())
            {
                data01[12] += "--- Battery information ---\n" +
                              $"Name: {b["Name"]}\n" +
                              $"BatteryStatus: {b["BatteryStatus"]}\n" +
                              $"EstimatedChargeRemaining: {b["EstimatedChargeRemaining"]}\n";
            }

            // USB Hub
            ManagementObjectSearcher os7 = new("SELECT * FROM Win32_USBHub");
            foreach (ManagementObject u in os7.Get())
            {
                data01[12] += "--- USB Hub information ---\n" +
                              $"Name: {u["Name"]}\n" +
                              $"Status: {u["Status"]}\n" +
                              $"DeviceID: {u["DeviceID"]}\n";
            }

            // Physical Memory
            ManagementObjectSearcher bios7 = new("SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject m in bios7.Get())
            {
                data01[12] += "--- Physical Memory information ---\n" +
                              $"Capacity: {m["Capacity"]}\n" +
                              $"Speed: {m["Speed"]}\n" +
                              $"Manufacturer: {m["Manufacturer"]}\n";
            }

            // Desktop Monitor
            ManagementObjectSearcher os8 = new("SELECT * FROM Win32_DesktopMonitor");
            foreach (ManagementObject mon in os8.Get())
            {
                data01[12] += "--- Desktop Monitor information ---\n" +
                              $"Name: {mon["Name"]}\n" +
                              $"ScreenHeight: {mon["ScreenHeight"]}\n" +
                              $"ScreenWidth: {mon["ScreenWidth"]}\n";
            }

            // Environment Variables
            ManagementObjectSearcher os9 = new("SELECT * FROM Win32_Environment");
            foreach (ManagementObject env in os9.Get())
            {
                data01[12] += "--- Environment information ---\n" +
                              $"Name: {env["Name"]}\n" +
                              $"VariableValue: {env["VariableValue"]}\n";
            }

            // Account
            ManagementObjectSearcher bios9 = new("SELECT * FROM Win32_Account");
            foreach (ManagementObject acc in bios9.Get())
            {
                data01[12] += "--- Account information ---\n" +
                              $"Name: {acc["Name"]}\n" +
                              $"SID: {acc["SID"]}\n" +
                              $"Domain: {acc["Domain"]}\n";
            }

            // Process
            ManagementObjectSearcher os10 = new("SELECT * FROM Win32_Process");
            foreach (ManagementObject proc in os10.Get())
            {
                data01[12] += "--- Process information ---\n" +
                              $"Name: {proc["Name"]}\n" +
                              $"ProcessId: {proc["ProcessId"]}\n" +
                              $"ThreadCount: {proc["ThreadCount"]}\n";
            }

            // Startup Command
            ManagementObjectSearcher bios10 = new("SELECT * FROM Win32_StartupCommand");
            foreach (ManagementObject st in bios10.Get())
            {
                data01[12] += "--- Startup Command information ---\n" +
                              $"Name: {st["Name"]}\n" +
                              $"Command: {st["Command"]}\n" +
                              $"Location: {st["Location"]}\n";
            }

            return data01[12];
        }
        public string pick_file01(string starting_file_path)
        {
            data01[13] = Filepicker.Select($"{starting_file_path}"); //current location as starting point
                                                                     //     Filepicker.Select(new string[] { "xml", "json" }); //force select filetype
                                                                     //    Filepicker.Select("C:\Location"); //selects location as starting point
                                                                     //     Filepicker.Select("C:\Location", new string[] { "xml", "json" }); //select location + force select filetype

            return data01[13];
        }

        public async Task<string> GetPublicIPAsync()
        {
            using var client = new HttpClient();
            return await client.GetStringAsync("https://api.ipify.org");
        }
        public async Task<string> Base64ToImageFile(string input)
        {
      
            byte[] imageBytes = Convert.FromBase64String(input);
            string basePath = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData);

            string appFolder = Path.Combine(basePath, "E_APP02", "Images");
            Directory.CreateDirectory(appFolder);
            string filePath = Path.Combine(
                appFolder,
                $"{Guid.NewGuid()}.jpg"
            );

            await File.WriteAllBytesAsync(filePath, imageBytes);

            return filePath;
        }   
        /*   public static async Task<string> choose_file()
           {
               var photo = await FilePicker.Default.PickAsync();

               if (photo != null)
               {
                   var newFile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                   using var stream = await photo.OpenReadAsync();
                   using var newStream = File.OpenWrite(newFile);

                   await stream.CopyToAsync(newStream);

                   data01[13] = newFile; // store file path
               }
               else
               {
                   data01[13] = "No photo selected";
               }

               return data01[13];
           }*/

    }
}

