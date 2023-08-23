namespace Tevux.Dashboards.Abstractions;

public interface IAppearanceRuleStyle {
    public uint Background { get; }
    public uint Foreground { get; }
    public string Name { get; }
    public AppearanceRuleType Type { get; }
}

