namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Provides a standartized way to notify hosting application that something went wrong with the control.
/// </summary>
public interface IErrorMessageProviderControl {
    /// <summary>
    /// Content of the error.
    /// </summary>
    string ErrorMessage { get; }
}
