namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Allows sender to set value on the receiver.
/// </summary>
public class SetValueMessage : GenericMessage {
    public SetValueMessage(object value) {
        ArgumentNullException.ThrowIfNull(value);

        Value = value;
    }

    /// <summary>
    /// Value to set.
    /// </summary>
    public object Value { get; private set; }
}
