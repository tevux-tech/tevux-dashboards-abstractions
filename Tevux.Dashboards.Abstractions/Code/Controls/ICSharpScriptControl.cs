namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Control which contains a C# script code.
/// </summary>
public interface ICSharpScriptControl {
    /// <summary>
    /// The C# script code.
    /// </summary>
    string Script { get; set; }
}
