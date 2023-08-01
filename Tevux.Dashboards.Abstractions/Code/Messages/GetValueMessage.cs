namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Allows receiver to return a value to the sender.
/// </summary>
public class GetValueMessage : GenericMessage {
    /// <summary>
    /// Value of the message.
    /// </summary>
    public object? Value { get; set; }
}
