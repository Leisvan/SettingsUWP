using System;

using SettingsUWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace SettingsUWP.Views
{
    public sealed partial class HomePage : Page
    {
        private HomeViewModel ViewModel
        {
            get { return ViewModelLocator.Current.HomeViewModel; }
        }

        public HomePage()
        {
            InitializeComponent();
        }
    }
}
