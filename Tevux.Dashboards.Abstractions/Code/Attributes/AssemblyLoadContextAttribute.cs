﻿namespace Tevux.Dashboards.Abstractions;

[AttributeUsage(AttributeTargets.Assembly)]
public class AssemblyLoadContextAttribute : Attribute {
    public AssemblyLoadContextAttribute(string friendlyName) {
        FriendlyName = friendlyName;
    }

    public AssemblyLoadContextAttribute() { }

    public string FriendlyName { get; set; } = "";
}
