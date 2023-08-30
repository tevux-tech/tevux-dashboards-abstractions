using Semver;
using System.Text.RegularExpressions;

namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// The <see cref="NamedVersion"/> class is used to create a unique identifier for libraries, which have name and version.
/// </summary>
public struct NamedVersion : IComparable, IEquatable<NamedVersion> {
    private readonly string _fullName = "";

    /// <summary>
    /// Creates <see cref="NamedVersion"/>.
    /// </summary>
    public NamedVersion(string baseName, SemVersion version) {
        BaseName = baseName;
        SemVersion = version;
        _fullName = BaseName + "." + SemVersion;
    }

    /// <summary>
    /// Creates an default, "Empty.0.0.0", object.
    /// </summary>
    public NamedVersion() : this("Empty", new SemVersion(0)) { }

    /// <summary>
    /// A default "Empty.0.0.0" object.
    /// </summary>
    public static NamedVersion Empty { get; } = new();

    /// <summary>
    /// Regex for the old Microsoft-style MAJOR.MINOR.PATCH.BUILD versioning.
    /// </summary>
    public static Regex MsVersionRegex { get; } = new(@"^(?<name>[a-zA-z.-]+)(\.)(?<version>(?<major>0|[1-9]\d*)\.(?<minor>0|[1-9]\d*)\.(?<patch>0|[1-9]\d*)\.(?<build>0|[1-9]\d*))$");

    /// <summary>
    /// Regex for the Semantic versioning style.
    /// </summary>
    public static Regex SemVersionRegex { get; } = new(@"^(?<name>[a-zA-z.-]+)(\.)(?<version>(?<major>0|[1-9]\d*)\.(?<minor>0|[1-9]\d*)\.(?<patch>0|[1-9]\d*)(?:-(?<prerelease>(?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\.(?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\+(?<buildmetadata>[0-9a-zA-Z-]+(?:\.[0-9a-zA-Z-]+)*))?)$");

    /// <summary>
    /// Text that identifies the library.
    /// </summary>
    public string BaseName { get; private set; } = "";

    /// <summary>
    /// Fully qualified name of the library, containing text portion of the name and the version.
    /// </summary>
    public readonly string FullName { get { return _fullName; } }

    /// <summary>
    /// Microsoft-style version.
    /// </summary>
    public readonly Version MsVersion { get { return SemVersion.ToVersion(); } }

    /// <summary>
    /// Sematinc-style version.
    /// </summary>
    public SemVersion SemVersion { get; private set; } = new(0);

    /// <summary>
    /// Creates a <see cref="NamedVersion"/> object from a string representation.
    /// </summary>
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

    /// <inheritdoc/>
    public static bool operator !=(NamedVersion a, NamedVersion b) {
        return a.FullName != b.FullName;
    }

    /// <inheritdoc/>
    public static bool operator <(NamedVersion left, NamedVersion right) {
        return left.CompareTo(right) < 0;
    }

    /// <inheritdoc/>
    public static bool operator <=(NamedVersion left, NamedVersion right) {
        return left.CompareTo(right) <= 0;
    }

    /// <inheritdoc/>
    public static bool operator ==(NamedVersion a, NamedVersion b) {
        return a.FullName == b.FullName;
    }

    /// <inheritdoc/>
    public static bool operator >(NamedVersion left, NamedVersion right) {
        return left.CompareTo(right) > 0;
    }

    /// <inheritdoc/>
    public static bool operator >=(NamedVersion left, NamedVersion right) {
        return left.CompareTo(right) >= 0;
    }

    #endregion

    #region IComparable

    /// <inheritdoc/>
    public readonly int CompareTo(object? obj) {
        if (obj is not NamedVersion nameToCompareAgainst) { return 1; }
        if (nameToCompareAgainst.BaseName != BaseName) { return 1; }

        return SemVersion.ComparePrecedenceTo(nameToCompareAgainst.SemVersion);
    }

    #endregion

    #region IEquatable

    /// <inheritdoc/>
    public bool Equals(NamedVersion other) {
        return FullName == other.FullName;
    }

    #endregion

    #region object overrides

    /// <inheritdoc/>
    public override bool Equals(object? obj) {
        if (obj is not NamedVersion nameToCompareAgainst) { return false; }

        return FullName == nameToCompareAgainst.FullName;
    }

    /// <inheritdoc/>
    public override readonly int GetHashCode() {
        return HashCode.Combine(BaseName, SemVersion);
    }

    /// <inheritdoc/>
    public override readonly string ToString() {
        return _fullName;
    }

    #endregion
}
