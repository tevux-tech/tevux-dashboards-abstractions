namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Condition used to check input value against the rule.
/// </summary>
public enum AppearanceRuleCondition {
    Undefined,
    Equal,
    NotEqual,
    MoreThan,
    MoreThanOrEqual,
    LessThan,
    LessThanOrEqual,
    BitSet,
    BitNotSet
}
