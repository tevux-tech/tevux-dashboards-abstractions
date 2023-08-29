namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Defines a numeric input control.
/// </summary>
public interface INumericInputControl {
    /// <summary>
    /// Minimum input value.
    /// </summary>
    decimal Minimum { get; set; }

    /// <summary>
    /// Maximum input value.
    /// </summary>
    decimal Maximum { get; set; }
    decimal Step { get; set; }
}
