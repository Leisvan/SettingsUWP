using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using SettingsUWP.Services;

namespace SettingsUWP.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ObservableCollection<SettingGroup> Groups
        {
            get;
            set;
        }

        public HomeViewModel()
        {
            Groups = new ObservableCollection<SettingGroup>(TestDataService.GetTestGroups());
        }
    }
}
