namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Defines a control that provides a custom tooltip.
/// </summary>
public interface ITooltipProvider {

    /// <summary>
    /// Text of the tooltip.
    /// </summary>
    string TooltipText { get; set; }
}
