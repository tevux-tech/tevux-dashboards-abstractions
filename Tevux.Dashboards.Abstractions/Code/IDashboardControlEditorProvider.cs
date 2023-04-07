namespace Tevux.Dashboards.Abstractions;

public interface IDashboardControlEditorProvider {
    public Dictionary<Type, List<Type>> DashboardControlEditors { get; }
}
