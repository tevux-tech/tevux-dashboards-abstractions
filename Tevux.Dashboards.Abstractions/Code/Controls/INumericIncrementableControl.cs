namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Defines a numeric input control which value may be incremented or decremented.
/// </summary>
public interface INumericIncrementableControl {
    /// <summary>
    /// Increment/decrement step.
    /// </summary>
    decimal Step { get; set; }
}
