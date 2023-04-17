namespace Tevux.Dashboards.Abstractions;
public interface ITextualOutputControlBase {
    string Format { get; set; }
    string Prefix { get; set; }
    string Suffix { get; set; }
}
