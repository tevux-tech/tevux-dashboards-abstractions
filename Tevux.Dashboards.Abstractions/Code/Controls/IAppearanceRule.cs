namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Defines a rule to format the textual output of a control.
/// </summary>
public interface IAppearanceRule {
    /// <summary>
    /// A <see cref="AppearanceRuleCondition"/> used to evaluate whether input value fall under the rule.
    /// </summary>
    public AppearanceRuleCondition Condition { get; set; }

    /// <summary>
    /// Value to check the condition against.
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// <see cref="IAppearanceRuleStyle"/> to use if the input value matches the rule.
    /// </summary>
    IAppearanceRuleStyle Style { get; set; }

    /// <summary>
    /// Text format to use if the input value matches the rule.
    /// </summary>
    public string TextFormat { get; set; }
}
