
using System.Reflection;

namespace E_APP02.SERVICES.FILE_SERVICES.EXTERNAL_FILES
{
    internal static class Extract_Embedded_Resource01
    {
        public static async Task<string> ExtractEmbeddedResourceAsync(
            string resourceName,
            string outputFileName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            await using Stream? resourceStream =
                assembly.GetManifestResourceStream(resourceName);

            if (resourceStream == null)
            {
                throw new FileNotFoundException(
                    $"Embedded resource not found: {resourceName}");
            }

            string appDataPath =
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            string outputDirectory =
                Path.Combine(appDataPath, "E_APP02");

            Directory.CreateDirectory(outputDirectory);

            string outputPath =
                Path.Combine(outputDirectory, outputFileName);

            await using FileStream fileStream = new FileStream(
                outputPath,
                FileMode.Create,
                FileAccess.Write,
                FileShare.None,
                bufferSize: 1024 * 1024, // 1 MB buffer
                useAsync: true);

            await resourceStream.CopyToAsync(fileStream);
            await fileStream.FlushAsync();

            return outputPath;
        }
    }
}
