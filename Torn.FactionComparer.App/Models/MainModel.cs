using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Torn.FactionComparer.App.Services;

namespace Torn.FactionComparer.App.Models
{
    public interface IMainModel
    {
        Task<byte[]> GetStatisticsImage(string apiKey, int firstFactionId, int seccondFactionId);
        Task ClearFactionCache(int factionId);
        Task<DateTime?> GetFactionCacheDateTime(int factionId);
        Task SaveImage(byte[] bytes, string imageName);
    }

    public class MainModel : IMainModel
    {
        private readonly ICompareDataRetriever _compareDataRetriever;
        private readonly IHtmlRenderer _htmlRenderer;
        private readonly IImageGenerator _imageGenerator;
        private readonly IDbService _dbService;

        public MainModel(ICompareDataRetriever compareDataRetriever, IHtmlRenderer htmlRenderer, IImageGenerator imageGenerator, IDbService dbService)
        {
            _compareDataRetriever = compareDataRetriever;
            _htmlRenderer = htmlRenderer;
            _imageGenerator = imageGenerator;
            _dbService = dbService;
        }

        public async Task<byte[]> GetStatisticsImage(string apiKey, int firstFactionId, int seccondFactionId)
        {
            var compareData = await _compareDataRetriever.GetFactionCompareImageData(apiKey, firstFactionId, seccondFactionId);
            var htmlContent = await _htmlRenderer.GetHtml(compareData);
            return await _imageGenerator.GenerateImage(htmlContent);
        }

        public async Task ClearFactionCache(int factionId)
        {
            await _dbService.ClearFactionCache(factionId);
        }

        public async Task<DateTime?> GetFactionCacheDateTime(int factionId)
        {
            return await _dbService.GetFactionCacheDateTime(factionId);
        }

        public async Task SaveImage(byte[] bytes, string imageName)
        {
            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), imageName);
            await File.WriteAllBytesAsync(fileName, bytes);

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                FileName = "explorer.exe"
            };

            Process.Start(startInfo);
        }
    }
}
