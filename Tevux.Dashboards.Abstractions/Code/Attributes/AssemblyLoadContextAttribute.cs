namespace Tevux.Dashboards.Abstractions;


[AttributeUsage(AttributeTargets.Assembly)]
public class AssemblyLoadContextAttribute : Attribute {
    [Obsolete("ContextName and ContextFriendlyName properties are obsolete.")]
    public AssemblyLoadContextAttribute(string contextName, string friendlyName) {
        ContextName = contextName;
        ContextFriendlyName = friendlyName;
    }

    public AssemblyLoadContextAttribute(string friendlyName) {
        FriendlyName = friendlyName;
    }

    public AssemblyLoadContextAttribute() { }

    [Obsolete("Use FriendlyName instead.")]
    public string ContextFriendlyName { get; set; } = "";

    [Obsolete("Multi-library contexts aren't used anymore.")]
    public string ContextName { get; set; } = "Default";

    public string FriendlyName { get; set; } = "";
}
