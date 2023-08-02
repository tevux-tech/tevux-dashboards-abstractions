
namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Properties marked with this attribute will get their values injected by host application at runtime.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class InjectedByHostAttribute : Attribute { }
