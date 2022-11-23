using Semver;
using System.Text.RegularExpressions;

namespace Tevux.Dashboards.Abstractions;

public struct UniqueName : IComparable {
    public static Regex MsVersionRegex = new(@"^(?<name>[a-zA-z.-]+)(\.)(?<version>(?<major>0|[1-9]\d*)\.(?<minor>0|[1-9]\d*)\.(?<patch>0|[1-9]\d*)\.(?<build>0|[1-9]\d*))$");
    public static Regex SemVersionRegex = new(@"^(?<name>[a-zA-z.-]+)(\.)(?<version>(?<major>0|[1-9]\d*)\.(?<minor>0|[1-9]\d*)\.(?<patch>0|[1-9]\d*)(?:-(?<prerelease>(?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\.(?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\+(?<buildmetadata>[0-9a-zA-Z-]+(?:\.[0-9a-zA-Z-]+)*))?)$");

    private readonly string _fullName = "";
    public UniqueName(string name, SemVersion version) {
        BaseName = name;
        SemVersion = version;
        _fullName = BaseName + "." + SemVersion;
    }
    public UniqueName() : this("Empty", new SemVersion(0)) { }

    public string BaseName { get; private set; } = "";
    public string FullName { get { return _fullName; } }
    public Version MsVersion { get { return SemVersion.ToVersion(); } }
    public SemVersion SemVersion { get; private set; } = new(0);

    public static UniqueName FromString(string nameAndVersion) {
        UniqueName returnValue;

        // Some first v3 schema files had library versions saved in MS Version format, so silently parsing (and replacing) them.
        if ((MsVersionRegex.Match(nameAndVersion) is Match msVersionMatch) && (msVersionMatch.Success == true)) {
            returnValue = new UniqueName(msVersionMatch.Groups["name"].ToString(), SemVersion.FromVersion(Version.Parse(msVersionMatch.Groups["version"].ToString())));
        } else if ((SemVersionRegex.Match(nameAndVersion) is Match semverMatch) && (semverMatch.Success == true)) {
            returnValue = new UniqueName(semverMatch.Groups["name"].ToString(), SemVersion.Parse(semverMatch.Groups["version"].ToString(), SemVersionStyles.Strict));
        } else {
            returnValue = new UniqueName("InvalidInputString", new SemVersion(0));
        }

        return returnValue;
    }

    public static bool operator !=(UniqueName a, UniqueName b) {
        return a.FullName != b.FullName;
    }

    public static bool operator <(UniqueName left, UniqueName right) {
        return left.CompareTo(right) < 0;
    }

    public static bool operator <=(UniqueName left, UniqueName right) {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator ==(UniqueName a, UniqueName b) {
        return a.FullName == b.FullName;
    }

    public static bool operator >(UniqueName left, UniqueName right) {
        return left.CompareTo(right) > 0;
    }

    public static bool operator >=(UniqueName left, UniqueName right) {
        return left.CompareTo(right) >= 0;
    }

    public int CompareTo(object? obj) {
        if (obj is not UniqueName nameToCompareAgainst) { return 1; }
        if (nameToCompareAgainst.BaseName != BaseName) { return 1; }

        return SemVersion.CompareTo(nameToCompareAgainst.SemVersion);
    }

    public override bool Equals(object? obj) {
        if (obj is not UniqueName nameToCompareAgainst) { return false; }

        return FullName == nameToCompareAgainst.FullName;
    }

    public override int GetHashCode() {
        return HashCode.Combine(BaseName, SemVersion);
    }

    public override string ToString() {
        return _fullName;
    }
}
