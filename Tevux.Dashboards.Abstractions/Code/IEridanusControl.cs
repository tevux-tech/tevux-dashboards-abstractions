using System.ComponentModel;

namespace Tevux.Dashboards.Abstractions;
public interface IEridanusControl : IDisposable, INotifyPropertyChanged {
    string ErrorMessage { get; }
}
