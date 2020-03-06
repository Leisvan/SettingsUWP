using SettingsUWP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace SettingsUWP.Views.Coverters
{
    public class GroupKindToImageSourceConverter: IValueConverter
    {
        const string UriFormat = "ms-appx:///Assets/SettingTiles/{0}.png";
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is SettingGroupKind kind)
            {
                string uriAddress = string.Format(UriFormat, GetAssetName(kind));
                return new BitmapImage(new Uri(uriAddress));
            }
            return null;
        }

        private string GetAssetName(SettingGroupKind kind)
        {
            return "DeviceTest";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return SettingGroupKind.Unknown;
        }
    }
}
