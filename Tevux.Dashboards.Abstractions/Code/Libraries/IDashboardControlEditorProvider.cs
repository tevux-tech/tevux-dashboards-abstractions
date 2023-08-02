namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Provides custom WPF controls that are custom editors to utilise in Edit mode. Ususally it is the same class that implements <see cref="ILibrary"/>.
/// </summary>
public interface IDashboardControlEditorProvider {
    /// <summary>
    /// Available editor controls for each normal dashboard control (provided by <see cref="IDashboardControlProvider"/>). Each normal control may have multiple editors.
    /// </summary>
    public Dictionary<Type, List<Type>> DashboardControlEditors { get; }
}
