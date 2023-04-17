namespace Tevux.Dashboards.Abstractions;
public interface IControlBase : IDisposable {
    string Alignment { get; set; }
    string Caption { get; set; }
    double TextSize { get; set; }
}
