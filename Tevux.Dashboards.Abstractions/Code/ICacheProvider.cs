namespace Tevux.Dashboards.Abstractions;

public interface ICacheProvider {
    public bool TryRead(object owner, string propertyName, out object? value);
    void Write(object owner, string propertyName, object value);
}


public class EmptyCacheProvider : ICacheProvider {
    public bool TryRead(object owner, string propertyName, out object? value) {
        value = null;
        return false;
    }

    public void Write(object owner, string propertyName, object value) {

    }
}
