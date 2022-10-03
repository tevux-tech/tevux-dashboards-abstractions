
namespace Tevux.Dashboards.Abstractions;
public interface IConnection {
    public bool IsConnected { get; }
    public bool IsDisconnected { get; }

    public string ConnectionString { get; }

    public bool Connect(string connectionString, out string errorMessage);
    public void Disconnect();

    public string Status { get; }
}
