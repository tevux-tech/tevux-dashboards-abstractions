namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// A very generic bidirectional message to use in messengers, most notably in <see cref="ISharedLibraryMessagingProvider"/> implementations.
/// </summary>
public class GenericMessage {
    /// <summary>
    /// Receiving side can set the error message and thus inform sending side about what went wrong.
    /// </summary>
    public string ErrorMessage { get; set; } = "";

    /// <summary>
    /// If processing of the message takes time, receiving side may set this property to true, and thus sending side may wait for it. Use this with caution and only wait for a small amount of time (less than one second).
    /// </summary>
    public bool IsFinished { get; set; }
}
