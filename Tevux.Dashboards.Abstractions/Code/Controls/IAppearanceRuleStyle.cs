namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Style to use when a rules is matched.
/// </summary>
public interface IAppearanceRuleStyle {
    /// <summary>
    /// Background color of the control, in ARGB format.
    /// </summary>
    public uint Background { get; }

    /// <summary>
    /// Foreground color of the control, in ARGB format.
    /// </summary>
    public uint Foreground { get; }

    /// <summary>
    /// Name of the style.
    /// </summary>
    public string Name { get; }
}
