using System.ComponentModel;

namespace Tevux.Dashboards.Abstractions;

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
