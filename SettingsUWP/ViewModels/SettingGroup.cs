using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsUWP.ViewModels
{
    public class SettingGroup
    {
        public SettingGroupKind Kind { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<SettingSubtitle> Groups { get; set; } = new List<SettingSubtitle>();
    }

    public class SettingSubtitle
    {
        public string Text { get; set; }
        public string IconGlyph { get; set; }
    }

    public enum SettingGroupKind
    {
        System,
        Devices,
        Phone,
        NetworkAndInternet,
        Personalization,
        Apps,
        Account,
        TimeAndLanguage,
        Gaming,
        EaseOfAccess,
        CortanaAndSearch,
        Privacy,
        UpdateAndSecurity,
    }
}
