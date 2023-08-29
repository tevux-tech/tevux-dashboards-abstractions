namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Defines a textual output control.
/// </summary>
public interface ITextualOutputControl {
    /// <summary>
    /// Prefix that is prepended to the output at the very last step just before rendering value on screen.
    /// </summary>
    string Prefix { get; set; }

    /// <summary>
    /// Suffix that is apended to the output at the very last step just before rendering value on screen.
    /// </summary>
    string Suffix { get; set; }
}
