namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Appearance rule for texts.
/// </summary>
public class TextualAppearanceRule : AppearanceRule {
    private string _stringValue = "";

    public TextualAppearanceRule(AppearanceRuleCondition condition, string value, AppearanceRuleType style = AppearanceRuleType.Warning, string textFormat = "") : base(condition, style, textFormat) {
        Value = value;
    }

    /// <inheritdoc/>
    public override string Value {
        get {
            return _stringValue;
        }
        protected set {
            _stringValue = value;
        }
    }

    /// <summary>
    /// Tries parsing a rule from a string.
    /// </summary>
    public static bool TryParse(string rawString, out TextualAppearanceRule rule) {
        var ruleParts = rawString.Split('|');

        if (ruleParts.Length < 3) { goto error; }

        if (TryParseCondition(ruleParts[0], out var condition) == false) { goto error; }
        if (TryParseStyle(ruleParts[2], out var style) == false) { goto error; }

        var format = "";
        if (ruleParts.Length > 3) {
            format = ruleParts[3];
        }

        rule = new TextualAppearanceRule(condition, ruleParts[1], style, format);

        return true;

    error:
        rule = new TextualAppearanceRule(AppearanceRuleCondition.Undefined, "");
        return false;
    }

    /// <summary>
    /// Checks if a value matches any conditions in the rule list.
    /// </summary>
    public bool Matches(string checkValue) {
        return Matches(checkValue, _stringValue);
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
}
