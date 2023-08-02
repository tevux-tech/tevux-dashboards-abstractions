namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// The most important interface for the 3rd party libraries to implement, and the only one that is mandatory.
/// </summary>
public interface ILibrary : IDisposable {
    /// <summary>
    /// Initializes the library. This method is a called automatically by library loader at the very end of the process. All the library runtime initialization should be done here (like, reading from cache, creting internal connection objects, etc.).
    /// </summary>
    public void Initialize();
}
