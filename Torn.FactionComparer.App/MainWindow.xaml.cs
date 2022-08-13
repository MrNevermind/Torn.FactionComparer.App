using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Torn.FactionComparer.App.ViewModels;

namespace Torn.FactionComparer.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IMainViewModel mainViewModel)
        {
            EnsureApplicationResources();
            InitializeComponent();
            this.DataContext = this;
            View = mainViewModel;
        }

        private object view;
        public object View
        {
            get
            {
                return view;
            }
            set
            {
                view = value;
                NotifyPropertyChanged();
            }
        }

        public void EnsureApplicationResources()
        {
            this.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Torn.FactionComparer.App;component/Resources/ResourcesMerge.xaml", UriKind.Relative)
            });
        }
        public event PropertyChangedEventHandler PropertyChanged = (s, e) => { };
        protected virtual void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
