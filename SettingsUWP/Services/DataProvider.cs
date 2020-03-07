using SettingsUWP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsUWP.Services
{
    public static class DataProvider
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
            system.Groups.Add(new SettingSubtitle { Text = "Common System Settings", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "Display", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "Sound", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "Notifications & actions", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "Focus asist", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "Power & sleep", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "Battery", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "Storage", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "Tablet mode", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "Multitasking", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "Projecting to this PC", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "Shared experiences", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "Clipboard", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "Remote Desktop", IconGlyph = "" });
            system.Groups.Add(new SettingSubtitle { Text = "About", IconGlyph = "" });

            var devices = new SettingGroup
            {
                Kind = SettingGroupKind.Devices,
                Title = "Devices",
                Description = "Bluetooth, printers, mouse",
            };
            
            var phone = new SettingGroup
            {
                Kind = SettingGroupKind.Phone,
                Title = "Phone",
                Description = "Link your Android, iPhone",
            };

            var network = new SettingGroup
            {
                Kind = SettingGroupKind.NetworkAndInternet,
                Title = "Network & Internet",
                Description = "Wi-Fi, airplane mode, VPN",
            };

            var personalization = new SettingGroup
            {
                Kind = SettingGroupKind.Personalization,
                Title = "Personalization",
                Description = "Background, lock screen, colors",
            };

            var apps = new SettingGroup
            {
                Kind = SettingGroupKind.Apps,
                Title = "Apps",
                Description = "Uninstall, defaults, optional features",
            };

            var accounts = new SettingGroup
            {
                Kind = SettingGroupKind.Account,
                Title = "Accounts",
                Description = "Your accounts, email, sync, work, family",
            };

            var time = new SettingGroup
            {
                Kind = SettingGroupKind.TimeAndLanguage,
                Title = "Time & Language",
                Description = "Speech, region, date",
            };

            var gaming = new SettingGroup
            {
                Kind = SettingGroupKind.Gaming,
                Title = "Gaming",
                Description = "Game bar, captues, broadcasting, game Mode",
            };

            var easeAccess = new SettingGroup
            {
                Kind = SettingGroupKind.EaseOfAccess,
                Title = "Ease of Access",
                Description = "Narrator, magnifier, high contrast",
            };

            var cortanaAndSearch = new SettingGroup
            {
                Kind = SettingGroupKind.CortanaAndSearch,
                Title = "Cortana & Search",
                Description = "Cortana language, permissions, notifications, find my files",
            };

            var privacy = new SettingGroup
            {
                Kind = SettingGroupKind.Privacy,
                Title = "Privacy",
                Description = "Location, camera, microphone",
            };

            var update = new SettingGroup
            {
                Kind = SettingGroupKind.UpdateAndSecurity,
                Title = "Update & Security",
                Description = "Windows update, recovery, backup",
            };


            groups.Add(system);
            groups.Add(devices);
            groups.Add(phone);
            groups.Add(network);
            groups.Add(personalization);
            groups.Add(apps);
            groups.Add(accounts);
            groups.Add(time);
            groups.Add(gaming);
            groups.Add(easeAccess);
            groups.Add(cortanaAndSearch);
            groups.Add(privacy);
            groups.Add(update);

            return groups;
        }
    }

}
