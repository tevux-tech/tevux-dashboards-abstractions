namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Provides a way to connect to an external system (usually hardware) and show a custom GUI for it.
/// </summary>
public interface IConnectionProvider {
    /// <summary>
    /// Stardartized connection to the external system.
    /// </summary>
    IConnection Connection { get; }

    /// <summary>
    /// Custom GUI control for the connection to the external system, that will be shown in D-Maker (or other software hosting dashboards). This must inherit from WPF 'Control' class.
    /// </summary>
    public Type ConnectionOptionsControl { get; }
}
