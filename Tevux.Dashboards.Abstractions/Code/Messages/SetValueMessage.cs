namespace Tevux.Dashboards.Abstractions;

public class SetValueMessage : GenericMessage {
    public object Value { get; private set; }

    public SetValueMessage(object value) {
        if (value is null) { throw new ArgumentNullException(nameof(value)); }

        Value = value;
    }
}
