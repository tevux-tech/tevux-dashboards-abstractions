namespace Tevux.Dashboards.Abstractions;

public class TextualAppearanceRule : AppearanceRule {
    private string _stringValue = "";
    public TextualAppearanceRule(AppearanceRuleCondition condition, string value, AppearanceRuleType style = AppearanceRuleType.Warning, string textFormat = "") : base(condition, style, textFormat) {
        Value = value;
    }

    public override string Value {
        get {
            return _stringValue;
        }
        set {
            _stringValue = value;
        }
    }

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
}
