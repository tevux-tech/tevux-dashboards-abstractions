namespace Tevux.Dashboards.Abstractions;

public class EmptyLibraryMessenger : ISharedLibraryMessenger {
    public void GetValue(string token, out object value) {
        value = new();
    }

    public void Register<TMessage>(object recipient, string token, Action<TMessage> action) {

    }

    public void Register<TMessage>(object recipient, Action<TMessage> action) {

    }

    public void Register(object recipient, string token, Action<object> action) {

    }

    public void Send<TMessage>(TMessage message) {

    }

    public void Send<TMessage>(string token, TMessage message) {

    }

    public void SetValue(string token, object value) {

    }

    public void Unregister<TMessage>(object recipient, string token, Action<TMessage> action) {

    }

    public void Unregister<TMessage>(object recipient, Action<TMessage> action) {

    }

    public void Unregister(object recipient, string token, Action<object> action) {

    }

    public void Unregister(object recipient) {

    }
}
