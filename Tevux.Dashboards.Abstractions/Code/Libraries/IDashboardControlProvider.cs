namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Provides graphical dashboard controls. Usually it is the same class that implements <see cref="ILibrary"/>.
/// </summary>
public interface IDashboardControlProvider {
    /// <summary>
    /// List of graphical WPF controls that could be used in a dashboard. Although not specifically resctricted here, type must inherit from <c>FrameworkElement</c>, or it will not be recognised otherwise. />
    /// </summary>
    public List<Type> DashboardControls { get; }
}
