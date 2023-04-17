using System.Globalization;

namespace Tevux.Dashboards.Abstractions;
public class AppearanceRule {
    private decimal? _decimalValue;
    private string _stringValue = "";
    public AppearanceRule() { }

    public AppearanceRule(AppearanceRuleCondition condition, AppearanceRuleType type = AppearanceRuleType.Warning, string textFormat = "") {
        Condition = condition;
        TextFormat = textFormat;
        Style = AppearanceRuleStyle.FromType(type);
    }

    public AppearanceRule(AppearanceRuleCondition condition, decimal value, AppearanceRuleType style = AppearanceRuleType.Warning, string textFormat = "") : this(condition, style, textFormat) {
        _decimalValue = value;
        _stringValue = value.ToString(CultureInfo.InvariantCulture);
    }

    public AppearanceRule(AppearanceRuleCondition condition, string value, AppearanceRuleType style = AppearanceRuleType.Warning, string textFormat = "") : this(condition, style, textFormat) {
        Value = value;
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

    public string Value {
        get {
            return _stringValue;
        }
        set {
            if (decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out var number)) {
                _stringValue = value;
                _decimalValue = number;
            } else {
                _stringValue = value;
                _decimalValue = null;
            }
            _stringValue = value;

        }
    }

    public static bool TryParse(string rawString, out AppearanceRule rule) {
        var ruleParts = rawString.Split('|');

        if (ruleParts.Length < 3) { goto error; }

        if (TryParseCondition(ruleParts[0], out var condition) == false) { goto error; }
        if (TryParseStyle(ruleParts[2], out var style) == false) { goto error; }

        var format = "";
        if (ruleParts.Length > 3) {
            format = ruleParts[3];
        }

        if (decimal.TryParse(ruleParts[1], NumberStyles.Number, CultureInfo.InvariantCulture, out var number)) {
            rule = new AppearanceRule(condition, number, style, format);
        } else {
            rule = new AppearanceRule(condition, ruleParts[1], style, format);
        }

        return true;

    error:
        rule = new AppearanceRule();
        return false;
    }

    public bool Matches(decimal checkValue) {
        return Matches(checkValue, _decimalValue);
    }

    public bool Matches(string checkValue) {
        return Matches(checkValue, _stringValue);
    }

    public override string ToString() {
        var returnString = $"{ShortenCondition(Condition)}|{_stringValue}|{Style.Type}";

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

    private bool Matches(decimal x, decimal? y) {
        if (y.HasValue == false) { return false; }

        switch (Condition) {
            case AppearanceRuleCondition.Equal:
                return x == y;

            case AppearanceRuleCondition.NotEqual:
                return x != y;

            case AppearanceRuleCondition.LessThan:
                return x < y;

            case AppearanceRuleCondition.LessThanOrEqual:
                return x <= y;

            case AppearanceRuleCondition.MoreThan:
                return x > y;

            case AppearanceRuleCondition.MoreThanOrEqual:
                return x >= y;

            case AppearanceRuleCondition.BitSet:
                return ((((int)(x) >> (int)(y)) & 1) == 1);

            case AppearanceRuleCondition.BitNotSet:
                return ((((int)(x) >> (int)(y)) & 1) == 0);

            default:
                return false;
        }
    }
    private bool Matches(string x, string y) {
        switch (Condition) {
            case AppearanceRuleCondition.Equal:
                return x == y;

            case AppearanceRuleCondition.NotEqual:
                return x != y;

            default:
                return false;
        }
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
