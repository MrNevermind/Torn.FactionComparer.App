using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using Torn.FactionComparer.App.Base;
using Torn.FactionComparer.App.Models;

namespace Torn.FactionComparer.App.ViewModels
{
    public interface IMainViewModel
    {
    }

    public class MainViewModel : ReactiveObject, IMainViewModel
    {
        private readonly IMainModel _mainModel;

        [Reactive]
        public string TornApiKey { get; set; }
        [Reactive]
        public int FirstFactionId { get; set; }
        [Reactive]
        public int SeccondFactionId { get; set; }
        [Reactive]
        public byte[] ImageSource { get; set; }

        [Reactive]
        public Visibility FirstFactionCacheInfoVisibility { get; set; } = Visibility.Hidden;
        [Reactive]
        public Visibility SeccondFactionCacheInfoVisibility { get; set; } = Visibility.Hidden;
        [Reactive]
        public string FirstFactionCacheText { get; set; } = "";
        [Reactive]
        public string SeccondFactionCacheText { get; set; } = "";

        [Reactive]
        public Visibility SavePictureButtonVisibility { get; set; } = Visibility.Hidden;

        public MainViewModel(IMainModel mainModel)
        {
            _mainModel = mainModel;

            GetStatisticsCommand = new AsyncCommand(async () => await GetStatistics());
            ClearFirstFactionCacheCommand = new AsyncCommand(async () => await ClearFirstFactionCache());
            ClearSeccondFactionCacheCommand = new AsyncCommand(async () => await ClearSeccondFactionCache());
            SavePictureCommand = new AsyncCommand(async () => await SavePicture());

            this.WhenAnyValue(t => t.FirstFactionId).Skip(1).Subscribe(async s => await FirstFactionIdChanged());
            this.WhenAnyValue(t => t.SeccondFactionId).Skip(1).Subscribe(async s => await SeccondFactionIdChanged());
        }

        private async Task ClearFirstFactionCache()
        {
            await _mainModel.ClearFactionCache(FirstFactionId);
            HideFirstFactionCacheInfo();
        }
        private async Task ClearSeccondFactionCache()
        {
            await _mainModel.ClearFactionCache(SeccondFactionId);
            HideSeccondFactionCacheInfo();
        }

        private async Task FirstFactionIdChanged()
        {
            var date = await _mainModel.GetFactionCacheDateTime(FirstFactionId);
            if (date.HasValue)
                ShowFirstFactionCacheInfo(date.Value);
            else
                HideFirstFactionCacheInfo();
        }
        private async Task SeccondFactionIdChanged()
        {
            var date = await _mainModel.GetFactionCacheDateTime(SeccondFactionId);
            if (date.HasValue)
                ShowSeccondFactionCacheInfo(date.Value);
            else
                HideSeccondFactionCacheInfo();
        }

        private async Task GetStatistics()
        {
            var bytes = await _mainModel.GetStatisticsImage(TornApiKey, FirstFactionId, SeccondFactionId);
            if(bytes.Any())
            {
                ImageSource = bytes;
                SavePictureButtonVisibility = Visibility.Visible;
            }
            else
            {
                SavePictureButtonVisibility = Visibility.Hidden;
            }
        }
        private async Task SavePicture()
        {
            var bytes = await _mainModel.GetStatisticsImage(TornApiKey, FirstFactionId, SeccondFactionId);
            await _mainModel.SaveImage(bytes, $"{FirstFactionId} and {SeccondFactionId} compare.jpeg");
        }
        private void ShowFirstFactionCacheInfo(DateTime date)
        {
            FirstFactionCacheInfoVisibility = Visibility.Visible;
            FirstFactionCacheText = GetFactionCacheText(date);
        }
        private void ShowSeccondFactionCacheInfo(DateTime date)
        {
            SeccondFactionCacheInfoVisibility = Visibility.Visible;
            SeccondFactionCacheText = GetFactionCacheText(date);
        }
        private string GetFactionCacheText(DateTime date)
        {
            return $"Cache date UTC:\n{date.ToShortDateString()}:{date.ToShortTimeString()}";
        }
        private void HideFirstFactionCacheInfo()
        {
            FirstFactionCacheInfoVisibility = Visibility.Hidden;
            FirstFactionCacheText = "";
        }
        private void HideSeccondFactionCacheInfo()
        {
            SeccondFactionCacheInfoVisibility = Visibility.Hidden;
            SeccondFactionCacheText = "";
        }

        public IAsyncCommand GetStatisticsCommand { get; set; }
        public IAsyncCommand ClearFirstFactionCacheCommand { get; set; }
        public IAsyncCommand ClearSeccondFactionCacheCommand { get; set; }
        public IAsyncCommand SavePictureCommand { get; set; }
    }
}
