using E_APP02.FILE_PATH;
using E_APP02.MODEL.AI_MODEL.AI_GET_MODEL;
using E_APP02.SERVICES.FILE_SERVICES.FILE_HELPER;
using Newtonsoft.Json;
using System.Diagnostics;

namespace E_APP02.SERVICES.FILE_SERVICES.PYTHONE_FILES
{
    internal class Read_Python01
    {
        private static File_Helper01 File_H01 = new File_Helper01();
        public string RunTextToImage(string userPrompt)
        {
              string pythonExe = File_H01.find_python_exe().Trim();
    string scriptPath = Path.Combine(
        AppContext.BaseDirectory,
        "python",
       File_H01.all_python_files()[0].Trim()
    );

    var psi = new ProcessStartInfo
    {
        FileName = pythonExe,
        Arguments = $"\"{scriptPath}\" \"{userPrompt}\"",
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        UseShellExecute = false,
        CreateNoWindow = true
    };

    using var process = Process.Start(psi)!;
    string output = process.StandardOutput.ReadToEnd();
    string error = process.StandardError.ReadToEnd();
    process.WaitForExit();

    if (!string.IsNullOrWhiteSpace(error))
        return "ERROR:\n" + error;

    return output.Trim(); // SUCCESS:path
        }
        public string RunTextToImage01(string userPrompt)
        {

            string pythonExe = File_Path01.file_path003[0];
            string scriptPath = Path.Combine(
                AppContext.BaseDirectory,
                "python",
                File_Path01.file_path004[1]
            );


            var psi = new ProcessStartInfo
            {
                FileName = pythonExe,
                Arguments = $"\"{scriptPath}\" \"{userPrompt}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using var process = Process.Start(psi);
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();
            return output.Trim(); // Base64 string

        }
        public string RunTextToVideo01(string userPrompt)
        {

            string pythonExe = File_Path01.file_path003[0];
            string scriptPath = Path.Combine(
                AppContext.BaseDirectory,
                "python",
                File_Path01.file_path004[1]
            );


            var psi = new ProcessStartInfo
            {
                FileName = pythonExe,
                Arguments = $"\"{scriptPath}\" \"{userPrompt}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using var process = Process.Start(psi);
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();
            return output.Trim(); // Base64 string

        }
        public async Task<string> RunTextToImage03(Ai_Model11 request)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = "Text_To_Image_python04.py",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var process = Process.Start(psi)!;

            // Send JSON → Python
            string json = JsonConvert.SerializeObject(request);
            await process.StandardInput.WriteAsync(json);
            process.StandardInput.Close();

            // Read output
            string output = await process.StandardOutput.ReadToEndAsync();
            string error = await process.StandardError.ReadToEndAsync();

            await process.WaitForExitAsync();

            if (process.ExitCode != 0)
                throw new Exception($"Python error:\n{error}");

            return output;
        }
        public string MoveImageToAppFolder(string pythonPath)
        {
            string appImages = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "E_APP02",
                "Images"
            );

            Directory.CreateDirectory(appImages);

            string fileName = Path.GetFileName(pythonPath);
            string dest = Path.Combine(appImages, fileName);

            File.Copy(pythonPath, dest, overwrite: true);

            return dest;
        }
    }
}