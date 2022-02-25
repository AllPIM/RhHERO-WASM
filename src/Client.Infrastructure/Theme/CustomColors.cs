using MudBlazor;

namespace FSH.BlazorWebAssembly.Client.Infrastructure.Theme;

public static class CustomColors
{
    public static readonly List<string> ThemeColors = new()
    {
        Light.Primary,
        Colors.Blue.Default,
        Colors.BlueGrey.Default,
        Colors.Purple.Default,
        Colors.Orange.Default,
        Colors.Red.Default,
        Colors.Amber.Default,
        Colors.DeepPurple.Default,
        Colors.Pink.Default,
        Colors.Indigo.Default,
        Colors.LightBlue.Default,
        Colors.Cyan.Default,
    };

    public static class Light
    {
        public const string Primary = "#194875";
        public const string Secondary = "#F0C168";
        public const string Background = "#F1F7F6";
        public const string AppbarBackground = "#F1F7F6";
        public const string AppbarText = "#6e6e6e";
        public const string DrawerBackground = "#EDDDD0";
        public const string Surface = "#202528";
        public const string Disabled = "#545454";
    }

    public static class Dark
    {
        public const string Primary = "#3eaf7c";
        public const string Secondary = "#2196f3";
        public const string Background = "#1b1f22";
        public const string AppbarBackground = "#1b1f22";
        public const string AppbarText = "#6e6e6e";
        public const string DrawerBackground = "#121212";
        public const string Surface = "#202528";
        public const string Disabled = "#545454";
    }
}