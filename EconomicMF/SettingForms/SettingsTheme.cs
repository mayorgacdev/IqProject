using System.Drawing;

namespace EconomicMF.SettingForms
{
    public static class SettingsTheme
    {
        public static Color DarkColorBottom { get; set; } = Color.FromArgb(33, 30, 39);
        public static Color DarkColorABove { get; set; } = Color.FromArgb(33, 30, 50);
        public static Color DarkColorButton { get; set; } = Color.FromArgb(33, 30, 70);

        public static Color WhiteColorBottom { get; set; } = Color.FromArgb(255, 255, 255);
        public static Color WhiteColorABove { get; set; } = Color.FromArgb(110, 203, 200);
        public static Color WhiteColorButton { get; set; } = Color.FromArgb(113, 201, 206);
        public static bool IsDark { get; set; }
    }
}
