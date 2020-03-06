using SettingsUWP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsUWP.Services
{
    public static class TestDataService
    {
        public static ICollection<SettingGroup> GetTestGroups()
        {
            List<SettingGroup> groups = new List<SettingGroup>();
            var system = new SettingGroup
            {
                Kind = SettingGroupKind.System,
                Title = "System",
                Description = "Display, sound, notifications, power",
            };
            system.Groups.Add(new SettingSubtitle { Text = "Display", IconGlyph = "" });

            var devices = new SettingGroup
            {
                Kind = SettingGroupKind.Devices,
                Title = "Devices",
                Description = "Bluetooth, printers, mouse",
            };
            devices.Groups.Add(new SettingSubtitle { Text = "Bluetooth & other devices", IconGlyph = "" });

            groups.Add(system);
            groups.Add(devices);

            return groups;
        }
    }

}
