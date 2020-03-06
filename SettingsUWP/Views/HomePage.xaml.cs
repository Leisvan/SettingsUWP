using System;
using Microsoft.Toolkit.Uwp.UI.Controls;
using SettingsUWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace SettingsUWP.Views
{
    public sealed partial class HomePage : Page
    {
        private HomeViewModel Home => ViewModelLocator.Current.HomeViewModel;

        public HomePage()
        {
            InitializeComponent();
        }

        private void SettingItemClicked(object sender, ItemClickEventArgs e)
        {
            if (e.ClickedItem is SettingGroup group && sender is AdaptiveGridView control)
            {
                control.PrepareConnectedAnimation("ForwardSetting", group, "LayoutRoot");
                ViewModelLocator.Current.NavigationService.Navigate(typeof(SettingGroup).FullName, group);
            }
        }
    }
}
