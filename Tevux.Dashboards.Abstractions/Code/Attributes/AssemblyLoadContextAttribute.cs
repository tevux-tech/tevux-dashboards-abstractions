namespace Tevux.Dashboards.Abstractions;


[AttributeUsage(AttributeTargets.Assembly)]
public class AssemblyLoadContextAttribute : Attribute {
    public AssemblyLoadContextAttribute(string contextName, string friendlyName) {
        ContextName = contextName;
        ContextFriendlyName = friendlyName;
    }
    public AssemblyLoadContextAttribute() { }

    public string ContextName { get; set; } = "Default";
    public string ContextFriendlyName { get; set; } = "";
}
