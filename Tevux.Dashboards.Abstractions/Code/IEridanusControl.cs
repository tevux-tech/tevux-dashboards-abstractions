using System.ComponentModel;

namespace Tevux.Dashboards.Abstractions;
[Obsolete()]
public interface IEridanusControl : IDisposable, INotifyPropertyChanged {
    string ErrorMessage { get; }
}
