namespace Tevux.Dashboards.Abstractions;

public class GetCachedValueMessage : GenericMessage {
    public string Key { get; set; } = "";
    public object? Value { get; set; }
}
