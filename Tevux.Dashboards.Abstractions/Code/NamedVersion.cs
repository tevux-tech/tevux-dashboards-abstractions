﻿using Semver;
using System.Text.RegularExpressions;

namespace Tevux.Dashboards.Abstractions;

public struct NamedVersion : IComparable, IEquatable<NamedVersion> {
    private readonly string _fullName = "";
    public NamedVersion(string name, SemVersion version) {
        BaseName = name;
        SemVersion = version;
        _fullName = BaseName + "." + SemVersion;
    }

    public NamedVersion() : this("Empty", new SemVersion(0)) { }

    public static NamedVersion Empty { get; } = new();
    public static Regex MsVersionRegex { get; } = new(@"^(?<name>[a-zA-z.-]+)(\.)(?<version>(?<major>0|[1-9]\d*)\.(?<minor>0|[1-9]\d*)\.(?<patch>0|[1-9]\d*)\.(?<build>0|[1-9]\d*))$");
    public static Regex SemVersionRegex { get; } = new(@"^(?<name>[a-zA-z.-]+)(\.)(?<version>(?<major>0|[1-9]\d*)\.(?<minor>0|[1-9]\d*)\.(?<patch>0|[1-9]\d*)(?:-(?<prerelease>(?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\.(?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\+(?<buildmetadata>[0-9a-zA-Z-]+(?:\.[0-9a-zA-Z-]+)*))?)$");
    public string BaseName { get; private set; } = "";
    public string FullName { get { return _fullName; } }
    public Version MsVersion { get { return SemVersion.ToVersion(); } }
    public SemVersion SemVersion { get; private set; } = new(0);

    public static NamedVersion FromString(string nameAndVersion) {
        NamedVersion returnValue;

        // Some first v3 schema files had library versions saved in MS Version format, so silently parsing (and replacing) them.
        if ((MsVersionRegex.Match(nameAndVersion) is Match msVersionMatch) && (msVersionMatch.Success == true)) {
            returnValue = new NamedVersion(msVersionMatch.Groups["name"].ToString(), SemVersion.FromVersion(Version.Parse(msVersionMatch.Groups["version"].ToString())));
        } else if ((SemVersionRegex.Match(nameAndVersion) is Match semverMatch) && (semverMatch.Success == true)) {
            returnValue = new NamedVersion(semverMatch.Groups["name"].ToString(), SemVersion.Parse(semverMatch.Groups["version"].ToString(), SemVersionStyles.Strict));
        } else {
            returnValue = new NamedVersion("InvalidInputString", new SemVersion(0));
        }

        return returnValue;
    }

    #region Operator overrides

    public static bool operator !=(NamedVersion a, NamedVersion b) {
        return a.FullName != b.FullName;
    }

    public static bool operator <(NamedVersion left, NamedVersion right) {
        return left.CompareTo(right) < 0;
    }

    public static bool operator <=(NamedVersion left, NamedVersion right) {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator ==(NamedVersion a, NamedVersion b) {
        return a.FullName == b.FullName;
    }

    public static bool operator >(NamedVersion left, NamedVersion right) {
        return left.CompareTo(right) > 0;
    }

    public static bool operator >=(NamedVersion left, NamedVersion right) {
        return left.CompareTo(right) >= 0;
    }

    #endregion

    #region IComparable
    public readonly int CompareTo(object? obj) {
        if (obj is not NamedVersion nameToCompareAgainst) { return 1; }
        if (nameToCompareAgainst.BaseName != BaseName) { return 1; }

        return SemVersion.ComparePrecedenceTo(nameToCompareAgainst.SemVersion);
    }

    #endregion

    #region IEquatable

    public bool Equals(NamedVersion other) {
        return FullName == other.FullName;
    }

    #endregion

    #region object overrides

    public override bool Equals(object? obj) {
        if (obj is not NamedVersion nameToCompareAgainst) { return false; }

        return FullName == nameToCompareAgainst.FullName;
    }

    public override readonly int GetHashCode() {
        return HashCode.Combine(BaseName, SemVersion);
    }

    public override readonly string ToString() {
        return _fullName;
    }

    #endregion
}