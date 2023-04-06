namespace Tevux.Dashboards.Abstractions;

public interface ICacheService {
    public bool TryRead(object owner, string propertyName, out object? value);
    void Write(object owner, string propertyName, object value);
}

[Obsolete]
public interface ICache {
    public bool TryRead(object owner, string propertyName, out object? value);
    void Write(object owner, string propertyName, object value);
}

[Obsolete]
public class EmptyCache : ICache {
    public bool TryRead(object owner, string propertyName, out object? value) {
        value = null;
        return false;
    }

    public void Write(object owner, string propertyName, object value) {

    }
}


public class EmptyCacheService : ICacheService {
    public bool TryRead(object owner, string propertyName, out object? value) {
        value = null;
        return false;
    }

    public void Write(object owner, string propertyName, object value) {

    }
}
