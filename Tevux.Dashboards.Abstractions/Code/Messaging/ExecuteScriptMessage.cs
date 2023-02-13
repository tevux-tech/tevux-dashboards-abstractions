namespace Tevux.Dashboards.Abstractions;

public class ExecuteScriptMessage : GenericMessage {
    public Dictionary<string, object> Arguments { get; } = new();
    public object? FeedbackObject { get; set; }
}
