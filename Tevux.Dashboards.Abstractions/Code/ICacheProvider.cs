namespace Tevux.Dashboards.Abstractions;

public interface ICacheProvider {
    [Obsolete]
    public bool TryRead(object owner, string propertyName, out object? value);

    [Obsolete]
    void Write(object owner, string propertyName, object value);

    public bool TryRead(object owner, string propertyName, out int value);
    public bool TryRead(object owner, string propertyName, out double value);
    public bool TryRead(object owner, string propertyName, out string value);
    public bool TryRead(object owner, string propertyName, out Dictionary<string, int> value);
    public bool TryRead(object owner, string propertyName, out Dictionary<string, string> value);
    public bool TryRead(object owner, string propertyName, out Dictionary<string, double> value);
    public bool TryRead(object owner, string propertyName, out int[] value);
    public bool TryRead(object owner, string propertyName, out double[] value);
    public bool TryRead(object owner, string propertyName, out string[] value);

    void Write(object owner, string propertyName, int value);
    void Write(object owner, string propertyName, double value);
    void Write(object owner, string propertyName, string value);
    void Write(object owner, string propertyName, Dictionary<string, int> value);
    void Write(object owner, string propertyName, Dictionary<string, double> value);
    void Write(object owner, string propertyName, Dictionary<string, string> value);
    void Write(object owner, string propertyName, int[] value);
    void Write(object owner, string propertyName, double[] value);
    void Write(object owner, string propertyName, string[] value);
}


public class EmptyCacheProvider : ICacheProvider {
    public bool TryRead(object owner, string propertyName, out object? value) {
        value = new();
        return false;
    }

    public bool TryRead(object owner, string propertyName, out int value) {
        value = new();
        return false;
    }

    public bool TryRead(object owner, string propertyName, out double value) {
        value = new();
        return false;
    }

    public bool TryRead(object owner, string propertyName, out string value) {
        value = "";
        return false;
    }

    public bool TryRead(object owner, string propertyName, out Dictionary<string, int> value) {
        value = new();
        return false;
    }

    public bool TryRead(object owner, string propertyName, out Dictionary<string, string> value) {
        value = new();
        return false;
    }

    public bool TryRead(object owner, string propertyName, out Dictionary<string, double> value) {
        value = new();
        return false;
    }

    public bool TryRead(object owner, string propertyName, out int[] value) {
        value = Array.Empty<int>();
        return false;
    }

    public bool TryRead(object owner, string propertyName, out double[] value) {
        value = Array.Empty<double>();
        return false;
    }

    public bool TryRead(object owner, string propertyName, out string[] value) {
        value = Array.Empty<string>();
        return false;
    }

    public void Write(object owner, string propertyName, object value) {

    }

    public void Write(object owner, string propertyName, int value) {

    }

    public void Write(object owner, string propertyName, double value) {

    }

    public void Write(object owner, string propertyName, string value) {

    }

    public void Write(object owner, string propertyName, Dictionary<string, int> value) {

    }

    public void Write(object owner, string propertyName, Dictionary<string, double> value) {

    }

    public void Write(object owner, string propertyName, Dictionary<string, string> value) {

    }

    public void Write(object owner, string propertyName, int[] value) {

    }

    public void Write(object owner, string propertyName, double[] value) {

    }

    public void Write(object owner, string propertyName, string[] value) {

    }
}
