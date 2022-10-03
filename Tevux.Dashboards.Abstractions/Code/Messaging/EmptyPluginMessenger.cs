namespace Tevux.Dashboards.Abstractions;

public class EmptyPluginMessenger : ISharedLibraryMessenger {
    public void Get(GenericMessage message) {
        throw new NotImplementedException();
    }

    void ISharedLibraryMessenger.GetValue(string token, out object value) {
        throw new NotImplementedException();
    }

    void ISharedLibraryMessenger.Register<TMessage>(object recipient, string token, Action<TMessage> action) {
        throw new NotImplementedException();
    }

    void ISharedLibraryMessenger.Register<TMessage>(object recipient, Action<TMessage> action) {
        throw new NotImplementedException();
    }

    void ISharedLibraryMessenger.Register(object recipient, string token, Action<object> action) {
        throw new NotImplementedException();
    }

    void ISharedLibraryMessenger.Send<TMessage>(TMessage message) {
        throw new NotImplementedException();
    }

    void ISharedLibraryMessenger.Send<TMessage>(string token, TMessage message) {
        throw new NotImplementedException();
    }

    void ISharedLibraryMessenger.SetValue(string token, object value) {
        throw new NotImplementedException();
    }

    void ISharedLibraryMessenger.Unregister<TMessage>(object recipient, string token, Action<TMessage> action) {
        throw new NotImplementedException();
    }

    void ISharedLibraryMessenger.Unregister<TMessage>(object recipient, Action<TMessage> action) {
        throw new NotImplementedException();
    }

    void ISharedLibraryMessenger.Unregister(object recipient, string token, Action<object> action) {
        throw new NotImplementedException();
    }

    void ISharedLibraryMessenger.Unregister(object recipient) {
        throw new NotImplementedException();
    }
}
