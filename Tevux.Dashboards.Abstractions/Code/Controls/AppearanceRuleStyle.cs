namespace Tevux.Dashboards.Abstractions;
public class AppearanceRuleStyle {
    static AppearanceRuleStyle() {
        Normal = new AppearanceRuleStyle() { Type = AppearanceRuleType.Normal, Foreground = 0xFF000000, Background = 0xFFD3D3D3 };
        Passive = new AppearanceRuleStyle() { Type = AppearanceRuleType.Passive, Foreground = 0xFF808080, Background = 0xFFD3D3D3 };
        Selected = new AppearanceRuleStyle() { Type = AppearanceRuleType.Selected, Foreground = 0xFFFFFFFF, Background = 0xFF008000 };
        Warning = new AppearanceRuleStyle() { Type = AppearanceRuleType.Warning, Foreground = 0xFF000000, Background = 0xFFFFA500 };
        Error = new AppearanceRuleStyle() { Type = AppearanceRuleType.Error, Foreground = 0xFFFFFFFF, Background = 0xFFFF0000 };
    }

    public static AppearanceRuleStyle Error { get; private set; }
    public static AppearanceRuleStyle Normal { get; private set; }
    public static AppearanceRuleStyle Passive { get; private set; }
    public static AppearanceRuleStyle Selected { get; private set; }
    public static AppearanceRuleStyle Warning { get; private set; }

    public uint Background { get; private set; } = 0x00FFFFFF;
    public uint Foreground { get; private set; } = 0x00FFFFFF;

    public string Name {
        get { return Type.ToString(); }
    }
    public AppearanceRuleType Type { get; private set; }
    public static AppearanceRuleStyle FromType(AppearanceRuleType type) {
        switch (type) {
            case AppearanceRuleType.Normal:
                return Normal;

            case AppearanceRuleType.Passive:
                return Passive;

            case AppearanceRuleType.Selected:
                return Selected;

            case AppearanceRuleType.Warning:
                return Warning;

            case AppearanceRuleType.Error:
                return Error;

            default:
                return Normal;
        }
    }

    public static List<AppearanceRuleStyle> GetAllStyles() {
        return new List<AppearanceRuleStyle>() { Normal, Passive, Selected, Warning, Error };
    }
}
