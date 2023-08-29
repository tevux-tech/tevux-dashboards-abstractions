namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Defines a very basic, minimal dashboard control.
/// </summary>
public interface IBasicControl : IDisposable {
    /// <summary>
    /// Alignment. Usually of <see cref="Caption"/>, but may also be used for other graphical elements. Values are not enforced, but it is recommended to use stringified names from <see cref="Alignment"/>.
    /// </summary>
    string Alignment { get; set; }

    /// <summary>
    /// Caption of the control.
    /// </summary>
    string Caption { get; set; }

    /// <summary>
    /// Textsize. Usually of <see cref="Caption"/>, but may also be used for other graphical elements.
    /// </summary>
    double TextSize { get; set; }
}
