namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// An empty implementation of <see cref="ICacheProvider"/> to use instead of <c>null</c>.
/// </summary>
public class EmptyCacheProvider : ICacheProvider {
    /// <summary>
    /// Does nothing.
    /// </summary>
    public bool TryRead(object owner, string propertyName, out int value) {
        value = new();
        return false;
    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public bool TryRead(object owner, string propertyName, out double value) {
        value = new();
        return false;
    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public bool TryRead(object owner, string propertyName, out string value) {
        value = "";
        return false;
    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public bool TryRead(object owner, string propertyName, out Dictionary<string, int> value) {
        value = new();
        return false;
    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public bool TryRead(object owner, string propertyName, out Dictionary<string, string> value) {
        value = new();
        return false;
    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public bool TryRead(object owner, string propertyName, out Dictionary<string, double> value) {
        value = new();
        return false;
    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public bool TryRead(object owner, string propertyName, out int[] value) {
        value = Array.Empty<int>();
        return false;
    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public bool TryRead(object owner, string propertyName, out double[] value) {
        value = Array.Empty<double>();
        return false;
    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public bool TryRead(object owner, string propertyName, out string[] value) {
        value = Array.Empty<string>();
        return false;
    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public void Write(object owner, string propertyName, int value) {

    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public void Write(object owner, string propertyName, double value) {

    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public void Write(object owner, string propertyName, string value) {

    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public void Write(object owner, string propertyName, Dictionary<string, int> value) {

    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public void Write(object owner, string propertyName, Dictionary<string, double> value) {

    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public void Write(object owner, string propertyName, Dictionary<string, string> value) {

    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public void Write(object owner, string propertyName, int[] value) {

    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public void Write(object owner, string propertyName, double[] value) {

    }

    /// <summary>
    /// Does nothing.
    /// </summary>
    public void Write(object owner, string propertyName, string[] value) {

    }
}
