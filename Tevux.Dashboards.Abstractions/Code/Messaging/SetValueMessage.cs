namespace Tevux.Dashboards.Abstractions;

public class SetValueMessage : GenericMessage {
    public object Value { get; private set; }

    public SetValueMessage(object value) {
        if (value is null) { throw new NullReferenceException($"{nameof(value)} cannot be null."); }

        Value = value;
    }
}
