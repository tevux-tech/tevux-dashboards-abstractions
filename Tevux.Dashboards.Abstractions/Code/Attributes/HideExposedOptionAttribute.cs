namespace Tevux.Dashboards.Abstractions;


[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class HideExposedOptionAttribute : Attribute {
    public HideExposedOptionAttribute(string optionName) {
        OptionName = optionName;
    }
    public HideExposedOptionAttribute() { }

    public string OptionName { get; set; } = "";
}
