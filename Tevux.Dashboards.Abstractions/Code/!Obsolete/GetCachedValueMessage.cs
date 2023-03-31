namespace Tevux.Dashboards.Abstractions;

[Obsolete]
public class GetCachedValueMessage : GenericMessage {
    public string Key { get; set; } = "";
    public object? Value { get; set; }
}
