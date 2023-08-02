namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Allows sender to set value on the receiver.
/// </summary>
public class SetValueMessage : GenericMessage {
    /// <summary>
    /// Value to set.
    /// </summary>
    public object Value { get; private set; }

    public SetValueMessage(object value) {
        if (value is null) { throw new ArgumentNullException(nameof(value)); }

        Value = value;
    }
}
