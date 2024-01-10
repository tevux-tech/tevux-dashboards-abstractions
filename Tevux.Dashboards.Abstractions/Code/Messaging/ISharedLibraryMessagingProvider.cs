namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Allows different libraries to communicate between host application and each other.
/// </summary>
public interface ISharedLibraryMessagingProvider {
    /// <summary>
    /// A shorthand method to quickly request some simple, unstructured data.
    /// </summary>
    public void GetValue(string token, out object value);

    /// <summary>
    /// A shorthand method to quickly send some simple, unstructured data.
    /// </summary>
    public void SetValue(string token, object value);

    /// <summary>
    /// Broadcasts a message containing structured data./>
    /// </summary>
    public void Send<TMessage>(TMessage message) where TMessage : class;

    /// <summary>
    /// Sends structured data to a specific listener, identified by a token.
    /// </summary>
    public void Send<TMessage>(string token, TMessage message) where TMessage : class;

    /// <summary>
    /// Registers to listen to structured messages, identified by a message type and the token.
    /// </summary>
    /// <param name="recipient">Usually 'this'.</param>
    public void Register<TMessage>(object recipient, string token, Action<TMessage> action) where TMessage : class;

    /// <summary>
    /// Registers to listen to structured messages, identified by a message type only.
    /// </summary>
    /// <param name="recipient">Usually 'this'.</param>
    public void Register<TMessage>(object recipient, Action<TMessage> action) where TMessage : class;

    /// <summary>
    /// Registers to listen to unstructured messages, identified by the token only.
    /// </summary>
    /// <param name="recipient">Usually 'this'.</param>
    public void Register(object recipient, string token, Action<object> action);

    /// <summary>
    /// Unregisters from structured messages, identified by a message type and the token.
    /// </summary>
    /// <param name="recipient">Usually 'this'.</param>
    public void Unregister<TMessage>(object recipient, string token, Action<TMessage> action) where TMessage : class;

    /// <summary>
    /// Unregisters from structured messages, identified by a message type only.
    /// </summary>
    /// <param name="recipient">Usually 'this'.</param>
    public void Unregister<TMessage>(object recipient, Action<TMessage> action) where TMessage : class;

    /// <summary>
    /// Unregisters from structured messages, identified by token only.
    /// </summary>
    /// <param name="recipient">Usually 'this'.</param>
    public void Unregister(object recipient, string token, Action<object> action);

    /// <summary>
    /// Unregisters completely from all messages.
    /// </summary>
    /// <param name="recipient">Usually 'this'.</param>
    public void Unregister(object recipient);
}
