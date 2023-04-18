namespace Tevux.Dashboards.Abstractions;
public interface IBasicControl : IDisposable {
    string Alignment { get; set; }
    string Caption { get; set; }
    double TextSize { get; set; }
}
