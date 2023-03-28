namespace Tevux.Dashboards.Abstractions;
public interface ICacheConsumer {
    public bool TryGetFromCache(object owner, string propertyName, out object? value);
    void SetToCache(object owner, string propertyName, object value);
}

public class EmptyCacheConsumer : ICacheConsumer {
    public bool TryGetFromCache(object owner, string propertyName, out object? value) {
        value = null;
        return false;
    }

    public void SetToCache(object owner, string propertyName, object value) {

    }
}
