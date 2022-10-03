namespace Tevux.Dashboards.Abstractions;

public class SetCachedValueMessage : GenericMessage {
    public string Key { get; set; } = "";
    public object? Value { get; set; }
}
