namespace Tevux.Dashboards.Abstractions;

[AttributeUsage(AttributeTargets.Class)]
public class OptionEditorAttribute : Attribute {
    public OptionEditorAttribute(Type control, string header) {
        Control = control;
        Header = header;
    }

    public Type Control { get; private set; }
    public string Header { get; private set; }
}
