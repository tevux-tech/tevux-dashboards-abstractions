using System.ComponentModel;

namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Used to construct a connection string to an external system (usually hardware).
/// </summary>
public class ConnectionDefinition : INotifyPropertyChanged {
    private string _name = "";
    private string _parameters = "";

    /// <inheritdoc/>
    public event PropertyChangedEventHandler PropertyChanged = delegate { };

    /// <summary>
    /// Name of the definition.
    /// </summary>
    public string Name {
        get { return _name; }
        set { _name = value; PropertyChanged(this, new PropertyChangedEventArgs(nameof(Name))); }
    }

    /// <summary>
    /// Parameters (or connection string). Can be anything, format is left for the implementer, although semicolon separated pairs ("propertyName=propertyValue;propertyName2=propertyvalue2;") are recommended.
    /// </summary>
    public string Parameters {
        get { return _parameters; }
        set { _parameters = value; PropertyChanged(this, new PropertyChangedEventArgs(nameof(Parameters))); }
    }
}
