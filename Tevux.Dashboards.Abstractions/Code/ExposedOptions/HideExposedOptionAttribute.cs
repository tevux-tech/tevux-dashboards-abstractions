namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Somewhat cancels any of the <see cref="ExposedOptionAttribute"/> variants. Useful in scenarios when a derived class changes implementation so much that an exposed property coming from the base class becomes irrelevant for the host application. The base property will still be there for internal consumption, only the host application will disregard it.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class HideExposedOptionAttribute : Attribute {
    /// <param name="optionName">Name of the base exposed property to hide.</param>
    public HideExposedOptionAttribute(string optionName) {
        OptionName = optionName;
    }

    public HideExposedOptionAttribute() { }

    public string OptionName { get; } = "";
}
