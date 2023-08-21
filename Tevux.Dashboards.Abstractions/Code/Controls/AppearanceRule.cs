namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Base class for <see cref="NumericAppearanceRule"/> and <see cref="TextualAppearanceRule"/>.
/// </summary>
public abstract class AppearanceRule {
    internal AppearanceRule() { }

    internal AppearanceRule(AppearanceRuleCondition condition, AppearanceRuleType type = AppearanceRuleType.Warning, string textFormat = "") {
        Condition = condition;
        TextFormat = textFormat;
        Style = AppearanceRuleStyle.FromType(type);
    }

    /// <summary>
    /// A <see cref="AppearanceRuleCondition"/> used to evaluate whether input value fall under the rule.
    /// </summary>
    public AppearanceRuleCondition Condition { get; set; } = AppearanceRuleCondition.Equal;

    /// <summary>
    /// Style to use if the input value matches the rule.
    /// </summary>
    public AppearanceRuleStyle Style { get; set; } = AppearanceRuleStyle.Normal;

    /// <summary>
    /// Text format to use if the input value matches the rule.
    /// </summary>
    public string TextFormat { get; set; } = "";

    /// <summary>
    /// Gets the normalized tule output string after all the rules and formats were applied.
    /// </summary>
    public virtual string Value { get; protected set; } = "";

    /// <inheritdoc/>
    public override string ToString() {
        var returnString = $"{ShortenCondition(Condition)}|{Value}|{Style.Type}";

        if (string.IsNullOrEmpty(TextFormat) == false) { returnString += $"|{TextFormat}"; }

        return returnString;
    }

    protected static bool TryParseCondition(string rawString, out AppearanceRuleCondition condition) {
        var returnValue = true;

        switch (rawString.Trim().ToLowerInvariant()) {
            case "equal":
            case "==":
                condition = AppearanceRuleCondition.Equal;
                break;

            case "notequal":
            case "!=":
                condition = AppearanceRuleCondition.NotEqual;
                break;

            case "lessthan":
            case "<":
                condition = AppearanceRuleCondition.LessThan;
                break;

            case "morethan":
            case ">":
                condition = AppearanceRuleCondition.MoreThan;
                break;

            case "lessthanorequal":
            case "<=":
                condition = AppearanceRuleCondition.LessThanOrEqual;
                break;

            case "morethanorequal":
            case ">=":
                condition = AppearanceRuleCondition.MoreThanOrEqual;
                break;

            case "bitset":
                condition = AppearanceRuleCondition.BitSet;
                break;

            case "bitnotset":
                condition = AppearanceRuleCondition.BitNotSet;
                break;

            default:
                condition = AppearanceRuleCondition.Undefined;
                returnValue = false;
                break;
        }

        return returnValue;
    }

    protected static bool TryParseStyle(string rawString, out AppearanceRuleType style) {
        var returnValue = true;

        switch (rawString.Trim().ToLowerInvariant()) {
            case "normal":
            case "norm":
            case "n":
                style = AppearanceRuleType.Normal;
                break;

            case "passive":
            case "pass":
                style = AppearanceRuleType.Passive;
                break;

            case "selected":
            case "sel":
                style = AppearanceRuleType.Selected;
                break;

            case "warning":
            case "warn":
                style = AppearanceRuleType.Warning;
                break;

            case "error":
            case "err":
                style = AppearanceRuleType.Error;
                break;

            default:
                style = AppearanceRuleType.Undefined;
                returnValue = false;
                break;
        }

        return returnValue;
    }

    private static string ShortenCondition(AppearanceRuleCondition condition) {
        switch (condition) {
            case AppearanceRuleCondition.Equal:
                return "==";

            case AppearanceRuleCondition.NotEqual:
                return "!=";

            case AppearanceRuleCondition.LessThan:
                return "<";

            case AppearanceRuleCondition.LessThanOrEqual:
                return "<=";

            case AppearanceRuleCondition.MoreThan:
                return ">";

            case AppearanceRuleCondition.MoreThanOrEqual:
                return ">=";

            case AppearanceRuleCondition.BitSet:
                return "BitSet";

            case AppearanceRuleCondition.BitNotSet:
                return "BitNotSet";

            default:
                return "==";
        }
    }
}
