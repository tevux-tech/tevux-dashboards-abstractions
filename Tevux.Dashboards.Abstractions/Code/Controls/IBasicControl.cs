namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Defines a very basic, minimal dashboard control.
/// </summary>
public interface IBasicControl : IDisposable {
    /// <summary>
    /// Alignment. Usually of <see cref="Caption"/>, but may also be used for other grahical elements.
    /// </summary>
    string Alignment { get; set; }
    string Caption { get; set; }
    double TextSize { get; set; }
}
