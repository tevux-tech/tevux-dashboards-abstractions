namespace Tevux.Dashboards.Abstractions;


[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class HiddenExposedOptionAttribute : Attribute {
    public HiddenExposedOptionAttribute(string optionName) {
        OptionName = optionName;
    }
    public HiddenExposedOptionAttribute() { }

    public string OptionName { get; set; } = "";
}
