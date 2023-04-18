namespace Tevux.Dashboards.Abstractions;
public interface ITextualOutputControl {
    string Format { get; set; }
    string Prefix { get; set; }
    string Suffix { get; set; }
}
