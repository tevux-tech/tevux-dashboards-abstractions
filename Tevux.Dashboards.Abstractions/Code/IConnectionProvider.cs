using System.ComponentModel;

namespace Tevux.Dashboards.Abstractions;
public interface IConnectionProvider : INotifyPropertyChanged {
    public IEnumerable<ConnectionDefinition> AvailableConnections { get; }
    public ConnectionDefinition CurrentConnection { get; set; }
    public bool IsConnected { get; }
    public bool IsDisconnected { get; }

    public void Disconnect();
    public bool TryConnect(out string errorMessage);
}

public class ConnectionDefinition : INotifyPropertyChanged {
    private string _name = "";
    private string _parameters = "";

    public event PropertyChangedEventHandler PropertyChanged = delegate { };

    public string Name {
        get { return _name; }
        set { _name = value; PropertyChanged(this, new PropertyChangedEventArgs(nameof(Name))); }
    }

    public string Parameters {
        get { return _parameters; }
        set { _parameters = value; PropertyChanged(this, new PropertyChangedEventArgs(nameof(Parameters))); }
    }
}
