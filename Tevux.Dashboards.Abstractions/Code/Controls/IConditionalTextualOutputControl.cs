namespace Tevux.Dashboards.Abstractions;
/// <summary>
/// Control that has a text-based output, which appearance (color, text, font, etc.) depends on the input value. Input may not be text-based.
/// </summary>
public interface IConditionalTextualOutputControl {
    /// <summary>
    /// Rules that define appearane of the final output text.
    /// </summary>
    string Rules { get; set; }

    /// <summary>
    /// Returns styles available for this control.
    /// </summary>
    /// <returns></returns>
    public List<IAppearanceRuleStyle> GetStyles();
}
