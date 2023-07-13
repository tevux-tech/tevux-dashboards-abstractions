namespace Tevux.Dashboards.Abstractions;

public interface IConnectionProvider {
    IConnection Connection { get; }

    [Obsolete("Replaced by ConnectionOptionsControl")]
    public object ConnectionGuiControl { get; }

    public Type ConnectionOptionsControl { get; }
}
