using System.ComponentModel;

namespace Tevux.Dashboards.Abstractions;
public class EmptyConnection : IConnection {
    public event PropertyChangedEventHandler? PropertyChanged = delegate { };

    public IEnumerable<ConnectionDefinition> AvailableDefinitions => new List<ConnectionDefinition>();
    public ConnectionDefinition CurrentDefinition { get; set; } = new();
    public bool IsConnected => false;
    public bool IsDisconnected => true;

    public void Disconnect() { }

    public bool TryConnect(out string errorMessage) {
        errorMessage = "";
        return true;
    }
}
