namespace Tevux.Dashboards.Abstractions;

public class GetValueMessage : GenericMessage {
    public object? Value { get; set; }
}
