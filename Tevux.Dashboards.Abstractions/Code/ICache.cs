namespace Tevux.Dashboards.Abstractions;

public interface ICache {
    public bool TryRead(object owner, string propertyName, out object? value);
    void Write(object owner, string propertyName, object value);
}

public class EmptyCache : ICache {
    public bool TryRead(object owner, string propertyName, out object? value) {
        value = null;
        return false;
    }

    public void Write(object owner, string propertyName, object value) {

    }
}
