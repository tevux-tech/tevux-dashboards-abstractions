namespace Tevux.Dashboards.Abstractions;
public interface INumericInputControl {
    decimal Minimum { get; set; }
    decimal Maximum { get; set; }
    decimal Step { get; set; }
}
