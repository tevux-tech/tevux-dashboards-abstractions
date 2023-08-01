using System.ComponentModel;

namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Provides connection to an external system of some sort (usually hardware).
/// </summary>
public interface IConnection : INotifyPropertyChanged {
    /// <summary>
    /// Stores multiple <see cref="ConnectionDefinition"/> objects for the user to select from. Only one connection may be active at any time. 
    /// </summary>
    public IEnumerable<ConnectionDefinition> AvailableDefinitions { get; }

    /// <summary>
    /// Active <see cref="ConnectionDefinition"/> to use with <see cref="TryConnect"/>, <see cref="Disconnect"/> and other members of the class. It is usually selected by the user from the list of <see cref="AvailableDefinitions"/> (from a combobox, for example).
    /// </summary>
    public ConnectionDefinition CurrentDefinition { get; set; }

    /// <summary>
    /// Shows if external system is connected. This is not mutually exclusive with <see cref="IsDisconnected"/>, both properties can simultaneously be true of false to accomodate transient states.
    /// </summary>
    public bool IsConnected { get; }

    /// <summary>
    /// Shows if external system is disconnected. This is not mutually exclusive with <see cref="IsConnected"/>, both properties can simultaneously be true of false to accomodate transient states.
    /// </summary>
    public bool IsDisconnected { get; }

    /// <summary>
    /// Disconnects immediatelly.
    /// </summary>
    public void Disconnect();

    /// <summary>
    /// Tries connecting to the external system using the <see cref="CurrentDefinition"/>.
    /// </summary>
    /// <param name="errorMessage">Error message if connection fails.</param>
    public bool TryConnect(out string errorMessage);
}
