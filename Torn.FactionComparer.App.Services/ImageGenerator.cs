using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Torn.FactionComparer.App.Services
{
    public interface IImageGenerator
    {
        Task<byte[]> GenerateImage(string html);
    }

    public class ImageGenerator : IImageGenerator
    {
        public async Task<byte[]> GenerateImage(string html)
        {
            var guid = Guid.NewGuid();

            var fileDir = Path.Combine(Path.GetTempPath(), "TornFactionComparerApp");
            if (!Directory.Exists(fileDir))
                Directory.CreateDirectory(fileDir);

            var inputFile = Path.Combine(fileDir, $"{guid}.html");
            var outputFile = Path.Combine(fileDir, $"{guid}.jpeg");
            await File.WriteAllTextAsync(inputFile, html);

            var pProcess = new Process();
            pProcess.StartInfo.FileName = Path.Combine(Directory.GetCurrentDirectory(), "wkhtmltoimage.exe");
            pProcess.StartInfo.Arguments = $"--format jpeg --crop-w 1000 {inputFile} {outputFile}";
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.Start();
            await pProcess.WaitForExitAsync();
            pProcess.Close();

            var bytes = await File.ReadAllBytesAsync(outputFile);

            SafeFileDelete(inputFile);
            SafeFileDelete(outputFile);

            return bytes;
        }

        private void SafeFileDelete(string fileName)
        {
            try
            {
                File.Delete(fileName);
            }
            catch (Exception ex)
            {
                Thread.Sleep(100);
                SafeFileDelete(fileName);
            }
        }
    }
}
