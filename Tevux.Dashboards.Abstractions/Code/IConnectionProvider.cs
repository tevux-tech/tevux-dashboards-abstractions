namespace Tevux.Dashboards.Abstractions;

public interface IConnectionProvider {
    IConnection Connection { get; }

    public Type ConnectionOptionsControl { get; }
}
