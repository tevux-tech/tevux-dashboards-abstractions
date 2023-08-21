using System.Globalization;

namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Appearance rule for numbers. Note that final formatted output will be a string, not a number.
/// </summary>
public class NumericAppearanceRule : AppearanceRule {
    private decimal? _decimalValue;
    private string _stringValue = "0";

    public NumericAppearanceRule(AppearanceRuleCondition condition, decimal value, AppearanceRuleType style = AppearanceRuleType.Warning, string textFormat = "") : base(condition, style, textFormat) {
        _decimalValue = value;
    }

    /// <inheritdoc/>
    public override string Value {
        get {
            return _stringValue;
        }
        protected set {
            if (decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out var number)) {
                _stringValue = value;
                _decimalValue = number;
            }
        }
    }

    /// <summary>
    /// Tries parsing a rule from a string.
    /// </summary>
    public static bool TryParse(string rawString, out NumericAppearanceRule rule) {
        var ruleParts = rawString.Split('|');

        if (ruleParts.Length < 3) { goto error; }

        if (TryParseCondition(ruleParts[0], out var condition) == false) { goto error; }
        if (TryParseStyle(ruleParts[2], out var style) == false) { goto error; }

        var format = "";
        if (ruleParts.Length > 3) {
            format = ruleParts[3];
        }

        if (decimal.TryParse(ruleParts[1], NumberStyles.Number, CultureInfo.InvariantCulture, out var number)) {
            rule = new NumericAppearanceRule(condition, number, style, format);
        } else {
            goto error;
        }

        return true;

    error:
        rule = new NumericAppearanceRule(AppearanceRuleCondition.Undefined, 0);
        return false;
    }

    /// <summary>
    /// Checks if a value matches any conditions in the rule list.
    /// </summary>
    public bool Matches(decimal checkValue) {
        return Matches(checkValue, _decimalValue);
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
}
