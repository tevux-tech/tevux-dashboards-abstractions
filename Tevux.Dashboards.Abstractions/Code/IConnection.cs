using System.ComponentModel;

namespace Tevux.Dashboards.Abstractions;
public interface IConnection : INotifyPropertyChanged {
    public IEnumerable<ConnectionDefinition> AvailableDefinitions { get; }
    public ConnectionDefinition CurrentDefinition { get; set; }
    public bool IsConnected { get; }
    public bool IsDisconnected { get; }

    public void Disconnect();
    public bool TryConnect(out string errorMessage);
}
