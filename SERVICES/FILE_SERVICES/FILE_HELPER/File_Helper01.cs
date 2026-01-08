
using E_APP02.FILE_PATH;
using System;
using System.Diagnostics; 
using System.Reflection;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.Core;
using UglyToad.PdfPig.Fonts.Standard14Fonts;
using UglyToad.PdfPig.Writer;
using static E_APP02.MODELS.AI_MODEL.AI_GET_MODEL.Ai_Model04;

namespace E_APP02.SERVICES.FILE_SERVICES.FILE_HELPER
{
    internal class File_Helper01
    {
        private readonly PdfDocumentBuilder builder = new PdfDocumentBuilder();
        private static readonly string[] data01 = new string[100];
        private static readonly Assembly assembly = Assembly.GetExecutingAssembly();
        private static readonly string[] resources = assembly.GetManifestResourceNames();
        private static readonly string[] imageExtensions01 = { ".png", ".jpg", ".jpeg", ".gif", ".bmp", ".svg", ".webp" };
        private static readonly string[] imageExtensions02 = { ".xlsx", ".xlsb", ".xls", ".xls", ".xls", ".xls", ".xls", ".csv" };
        private static readonly string[] imageExtensions03 = { "bin", "gguf" };
        private static readonly string[] imageExtensions04 = { "py" };
        private static readonly string[] imageExtensions05 = { "exe" };

        private static readonly string[] data02 = resources.Where(r => r.EndsWith(".txt", StringComparison.OrdinalIgnoreCase)).ToArray();
        private static readonly string[] data03 = resources.Where(r => r.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase)).ToArray();
        private static readonly string[] data04 = resources.Where(r => imageExtensions01.Any(ext => r.EndsWith(ext, StringComparison.OrdinalIgnoreCase))).ToArray();
        private static readonly string[] data05 = resources.Where(r => imageExtensions02.Any(ext => r.EndsWith(ext, StringComparison.OrdinalIgnoreCase))).ToArray();
        private static readonly string[] data06 = resources.Where(r => imageExtensions03.Any(ext => r.EndsWith(ext, StringComparison.OrdinalIgnoreCase))).ToArray();
        private static readonly string[] data07 = resources.Where(r => r.EndsWith(".py", StringComparison.OrdinalIgnoreCase)).ToArray();
        private static readonly string[] data08 = resources.Where(r => imageExtensions05.Any(ext => r.EndsWith(ext, StringComparison.OrdinalIgnoreCase))).ToArray();
        private static readonly string[] data09 = resources.Where(r => r.EndsWith(".safetensors", StringComparison.OrdinalIgnoreCase)).ToArray();
        private static string[] textFiles => data02;
        private static string[] pdfFiles => data03;
        private static string[] images => data04;
        private static string[] excel => data05;
        private static string[] data_models => data06;
        private static string[] python_file => data07;
        private static string[] exe_file => data08;
        private static string[] safetensors => data09;
        public  string all_embedded_files()
        {

            foreach (var a in resources)
            {
                data01[1] += $"{a}\n";
            }
            return data01[1];
        }
        public  string all_embedded_textfiles()
        {
            foreach (var a in textFiles)
            {
                data01[2] += $"{a}\n";
            }
            return data01[2].Trim();

        }
        public  string all_embedded_pdf()
        {
            foreach (var a in pdfFiles)
            {
                data01[3] += $"{a}\n";
            }
            return data01[3].Trim();

        }
        public  string all_embedded_images()
        {


            foreach (var a in images)
            {
                data01[4] += $"{a}\n";
            }
            return data01[4].Trim();

        }
        public  string all_embedded_excel()
        {

            foreach (var a in excel)
            {
                data01[5] += $"{a}\n";
            }
            return data01[5].Trim();

        }

        public string all_embedded_gguf_models()
        {
            foreach (var a in data_models)
            {
                data01[6] += $"{a}\n";
            }
            return data01[6].Trim();


        }
        public string all_embedded_python_files()
        {
            foreach (var a in python_file)
            {
                python_file[7] += $"{a}\n";
            }
            return data01[7].Trim();


        }


        public string find_python_exe()
        {
            var psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c where python.exe",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var process = Process.Start(psi);
            string output = process!.StandardOutput.ReadToEnd();
            process.WaitForExit();

            string[] lines = output.Split(
                new[] { '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries
            );

            foreach (var a in lines)
            {
                if (a.Contains(@"Python313\python.exe", StringComparison.OrdinalIgnoreCase))
                {
                    data01[8] += a.Trim();
                    process.WaitForExit();
                    return data01[8].Trim();
                }
                else
                {
                    data01[8] = "cant find";
                    process.WaitForExit();
                    return data01[8].Trim();
                }
            }
            return data01[8].Trim();
        }
        public string all_embedded_exe_files()
        {
            foreach (var a in exe_file)
            {
                exe_file[9] += $"{a}\n";
            }
            return data01[9].Trim();


        }
        public string find_all_files_in_project()
        {


            data01[10] += $"{Directory.GetParent(AppContext.BaseDirectory)!
                              .Parent!
                              .Parent!
                              .FullName}\n";
            string projectPath = AppContext.BaseDirectory;

            string projectPath01 = AppContext.BaseDirectory;

            string[] allFiles = Directory.GetFiles(
                projectPath01,
                "*.*",
                SearchOption.AllDirectories
            );

            foreach (var a in allFiles)
            {
                data01[10] += $"{a}\n";
            }
            return data01[10].Trim();
        }
        public string find_default_face_images01()
        {
            foreach (var a in File_Path01.default_single_face_iamges)
            {
                data01[11] += $"{a}\n";
            }
            return data01[11].Trim();
        }
        public string[] find_default_single_face_images02()
        {
            var matches = images
        .Where(a => a.Contains("default_single_face", StringComparison.OrdinalIgnoreCase))
        .ToArray();
            if (matches.Length > 0)
            {
                data01[12] += string.Join("\n", matches);


            }
            else
            {
                data01[12] = "No default single face images found.";
            }

            return data01[12].Split('\n');

        }
        public string[] find_default_single_face_images03()
        {
            var assembly = Assembly.GetExecutingAssembly();

            var resources = assembly
                .GetManifestResourceNames()
                .Where(r => r.Contains("default_single_face", StringComparison.OrdinalIgnoreCase))
                .ToArray();



            foreach (var resource in resources)
            {
                using Stream stream = assembly.GetManifestResourceStream(resource);
                string tempPath = Path.Combine(
                    Path.GetTempPath(),
                    Path.GetFileName(resource)   // default_single_face_01.jpg
                );

                using FileStream fs = File.Create(tempPath);
                stream.CopyTo(fs);

                data01[13] += $"{tempPath}\n";
            }

            return data01[13].Split();

        }
        public  string[] find_default_group_face_images01()
        {
            var assembly = Assembly.GetExecutingAssembly();

            var resources = assembly
                .GetManifestResourceNames()
                .Where(r => r.Contains("default_group_face", StringComparison.OrdinalIgnoreCase))
                .ToArray();



            foreach (var resource in resources)
            {
                using Stream stream = assembly.GetManifestResourceStream(resource);
                string tempPath = Path.Combine(
                    Path.GetTempPath(),
                    Path.GetFileName(resource)
                );

                using FileStream fs = File.Create(tempPath);
                stream.CopyTo(fs);

                data01[13] += $"{tempPath}\n";
            }

            return data01[13].Split();

        }
        public static string all_embedded_safetensors_models()
        {
            foreach (var a in safetensors)
            {
                data01[14] += $"{a}\n";
            }
            return data01[14].Trim();
        }
        public string[] all_text_to_text_gguf_models()
        {
            var results = new List<string>();

            string systemDrive = Environment.GetEnvironmentVariable("SystemDrive")!;
            // Usually "C:"

            void SearchDirectory(string path)
            {

                try
                {
                    foreach (var file in Directory.GetFiles(path, "*.gguf"))
                        results.Add(file);

                    foreach (var dir in Directory.GetDirectories(path, "*"))
                    {
                        var attr = File.GetAttributes(dir);
                        if (attr.HasFlag(FileAttributes.ReparsePoint))
                            continue;
                        SearchDirectory(dir);
                    }


                }
                catch (UnauthorizedAccessException) { }
                catch (PathTooLongException) { }
            }

            SearchDirectory(systemDrive + "\\");

            data01[15] = results.Count > 0
                ? string.Join('\n', results)
                : "No .gguf files found.";


            var matches = results
     .Where(a => a.Contains("text_to_text", StringComparison.OrdinalIgnoreCase))
     .ToArray();
            if (matches.Length > 0)
            {
                data01[16] += string.Join("\n", matches);


            }
            else
            {
                data01[16] = "No gguf file found.";
            }


            return data01[16].Split("\n");
        }

        public string[] all_text_to_image_gguf_models()
        {
            var results = new List<string>();

            string systemDrive = Environment.GetEnvironmentVariable("SystemDrive")!;
            // Usually "C:"

            void SearchDirectory(string path)
            {
          
                try
                {
                    foreach (var file in Directory.GetFiles(path, "*.gguf"))
                        results.Add(file);

                    foreach (var dir in Directory.GetDirectories(path, "*"))
                    {
                        var attr = File.GetAttributes(dir);
                        if (attr.HasFlag(FileAttributes.ReparsePoint))
                            continue;
                        SearchDirectory(dir);
                    }
                    

                }
                catch (UnauthorizedAccessException) { }
                catch (PathTooLongException) { }
            }

            SearchDirectory(systemDrive + "\\");

            data01[17] = results.Count > 0
                ? string.Join('\n', results)
                : "No .gguf files found.";


            var matches = results
     .Where(a => a.Contains("text_to_image", StringComparison.OrdinalIgnoreCase))
     .ToArray();
            if (matches.Length > 0)
            {
                data01[18] += string.Join("\n", matches);


            }
            else
            {
                data01[18] = "No gguf file found.";
            }


            return data01[18].Split("\n");
        }

        public string[] all_text_to_image_safetensors_models()
        {
            var results = new List<string>();

            string systemDrive = Environment.GetEnvironmentVariable("SystemDrive")!;
            // Usually "C:"

            void SearchDirectory(string path)
            {
                try
                {
                    foreach (var file in Directory.GetFiles(path, "*.safetensors"))
                        results.Add(file);

                    foreach (var dir in Directory.GetDirectories(path, "*"))
                    {
                        var attr = File.GetAttributes(dir);
                        if (attr.HasFlag(FileAttributes.ReparsePoint))
                            continue;
                        SearchDirectory(dir);
                    }
                }
                catch (UnauthorizedAccessException) { }
                catch (PathTooLongException) { }
            }

            SearchDirectory(systemDrive + "\\");

            data01[19] = results.Count > 0
                ? string.Join('\n', results)
                : "No .gguf files found.";


            var matches = results
     .Where(a => a.Contains("text_to_image", StringComparison.OrdinalIgnoreCase))
     .ToArray();
            if (matches.Length > 0)
            {
                data01[20] += string.Join("\n", matches);


            }
            else
            {
                data01[20] = "No gguf file found.";
            }


            return data01[20].Split("\n");
        }
        public string[] all_python_files()
        {
            var results = new List<string>();

            string systemDrive = Environment.GetEnvironmentVariable("SystemDrive")!;
            // Usually "C:"

            void SearchDirectory(string path)
            {
                try
                {
                    foreach (var file in Directory.GetFiles(path, "*.py"))
                        results.Add(file);

                    foreach (var dir in Directory.GetDirectories(path, "*"))
                    {
                        var attr = File.GetAttributes(dir);
                        if (attr.HasFlag(FileAttributes.ReparsePoint))
                            continue;
                        SearchDirectory(dir);
                    }
                }
                catch (UnauthorizedAccessException) { }
                catch (PathTooLongException) { }
            }

            SearchDirectory(systemDrive + "\\");

            data01[21] = results.Count > 0
                ? string.Join('\n', results)
                : "No .gguf files found.";


            var matches = results
     .Where(a => a.Contains("Text_To_Image_python", StringComparison.OrdinalIgnoreCase))
     .ToArray();
            if (matches.Length > 0)
            {
                data01[22] += string.Join("\n", matches);


            }
            else
            {
                data01[22] = "No gguf file found.";
            }


            return data01[22].Split("\n");
        }
        public string file_creator(string input01, string input02, string input03)
        {
            //input01 = file path
            //input02 = file content
            //input03 = file type
            string input04 = "test_text";
            if (input03 == ".txt")
            {
                Directory.CreateDirectory(input01);
                string fullPath = Path.Combine(input01, input04 + ".txt");
                File.WriteAllText(fullPath, input02);
              
                return $"File created successfully at:\n{fullPath}";

            }
            else if (input03 == ".pdf")
            {
                PdfPageBuilder page = builder.AddPage(PageSize.A4);
                // Fonts must be registered with the document builder prior to use to prevent duplication.
                PdfDocumentBuilder.AddedFont font = builder.AddStandard14Font(Standard14Font.Helvetica);
                page.AddText($"{input02}", 12, new PdfPoint(25, 700), font);
                byte[] documentBytes = builder.Build();
                File.WriteAllBytes(input01, documentBytes);
                data01[23] = "PDF Created";

            }
            else
            {
                data01[23] = "file type not supported";
            }
            return data01[23];
        }
        public string[] all_gguf_translate()
        {


            var results = new List<string>();

            string systemDrive = Environment.GetEnvironmentVariable("SystemDrive")!;
            // Usually "C:"

            void SearchDirectory(string path)
            {

                try
                {
                    foreach (var file in Directory.GetFiles(path, "*.gguf"))
                        results.Add(file);

                    foreach (var dir in Directory.GetDirectories(path, "*"))
                    {
                        var attr = File.GetAttributes(dir);
                        if (attr.HasFlag(FileAttributes.ReparsePoint))
                            continue;
                        SearchDirectory(dir);
                    }


                }
                catch (UnauthorizedAccessException) { }
                catch (PathTooLongException) { }
            }

            SearchDirectory(systemDrive + "\\");

            data01[24] = results.Count > 0
                ? string.Join('\n', results)
                : "No .gguf files found.";


            var matches = results
     .Where(a => a.Contains("text_to_translate", StringComparison.OrdinalIgnoreCase))
     .ToArray();
            if (matches.Length > 0)
            {
                data01[25] += string.Join("\n", matches);


            }
            else
            {
                data01[25] = "No gguf file found.";
            }


            return data01[25].Split("\n");

        }
    }
}