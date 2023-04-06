using System.ComponentModel;

namespace Tevux.Dashboards.Abstractions;
public interface IConnectionProvider : INotifyPropertyChanged {
    IConnection Connection { get; }
    public object GuiControl { get; }
}
