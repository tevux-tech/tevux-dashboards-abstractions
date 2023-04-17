namespace Tevux.Dashboards.Abstractions;
public interface INumericInputControlBase {
    decimal Minimum { get; set; }
    decimal Maximum { get; set; }
    decimal Step { get; set; }
}
