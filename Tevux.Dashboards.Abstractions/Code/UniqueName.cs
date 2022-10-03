using System;
using System.Text.RegularExpressions;

namespace Tevux.Dashboards.Designer;

public struct UniqueName : IComparable {
    private readonly string _fullName = "";
    public UniqueName(string name, Version version) {
        BaseName = name;
        Version = version;
        _fullName = BaseName + "." + Version;
    }
    public UniqueName() : this("Empty", new Version()) { }

    public string BaseName { get; private set; } = "";
    public string FullName { get { return _fullName; } }
    public Version Version { get; private set; } = new();

    public static UniqueName FromString(string nameAndVersion) {
        UniqueName returnValue;
        var regex = new Regex("^((?:[a-zA-z]+\\.)+)((?:\\d+\\.){2,3}\\d+)$");

        var parts = regex.Match(nameAndVersion);
        if (parts.Groups.Count == 3) {
            returnValue = new UniqueName(parts.Groups[1].Value.TrimEnd('.'), Version.Parse(parts.Groups[2].Value));
        } else {
            returnValue = new UniqueName("InvalidInputString", new Version(0, 0));
        }

        return returnValue;
    }

    public static bool operator !=(UniqueName a, UniqueName b) {
        return a.FullName != b.FullName;
    }

    public static bool operator ==(UniqueName a, UniqueName b) {
        return a.FullName == b.FullName;
    }

    public int CompareTo(object? obj) {
        if (obj is not UniqueName nameToCompareAgainst) { return 1; }
        if (nameToCompareAgainst.BaseName != BaseName) { return 1; }

        return Version.CompareTo(nameToCompareAgainst.Version);
    }

    public override string ToString() {
        return _fullName;
    }
}
