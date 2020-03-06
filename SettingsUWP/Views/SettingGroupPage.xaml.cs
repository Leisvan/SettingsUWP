using SettingsUWP.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SettingsUWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingGroupPage : Page
    {
        public SettingGroup Group
        {
            get;
            private set;
        }
        
        public SettingGroupPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            //Parameter init:
            if (e.Parameter is SettingGroup group)
            {
                Group = group;
            }
            //Animation
            var service = ConnectedAnimationService.GetForCurrentView();
            var animation = service.GetAnimation("ForwardSetting");
            if (animation != null)
            {
                animation.Configuration = new BasicConnectedAnimationConfiguration();
                animation.TryStart(NavigationHeader);
            }
            //In-Page Navigation
            var type = GetPageTypeForGroupKind(Group.Kind);
            if (type != null && Group != null)
            {
                navigationFrame.Navigate(typeof(GroupPageSystem));
            }
        }

        private void NavView_BackRequested(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewBackRequestedEventArgs args)
        {
            ViewModelLocator.Current.NavigationService.GoBack();
        }

        private Type GetPageTypeForGroupKind(SettingGroupKind kind)
        {
            //Improve this practice later
            switch (kind)
            {
                case SettingGroupKind.System: return typeof(GroupPageSystem);
                case SettingGroupKind.Devices:
                case SettingGroupKind.Phone:
                case SettingGroupKind.NetworkAndInternet:
                case SettingGroupKind.Personalization:
                case SettingGroupKind.Apps:
                case SettingGroupKind.Account:
                case SettingGroupKind.TimeAndLanguage:
                case SettingGroupKind.Gaming:
                case SettingGroupKind.EaseOfAccess:
                case SettingGroupKind.CortanaAndSearch:
                case SettingGroupKind.Privacy:
                case SettingGroupKind.UpdateAndSecurity:
                default:
                case SettingGroupKind.Unknown: return null;
            }
        }
    }
}
