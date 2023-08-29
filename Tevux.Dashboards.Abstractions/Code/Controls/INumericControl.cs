namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Defines a numeric input or output control.
/// </summary>
public interface INumericControl {
    /// <summary>
    /// Number of decimal places that are important for this particular control.
    /// </summary>
    int DecimalPlaces { get; set; }
}
