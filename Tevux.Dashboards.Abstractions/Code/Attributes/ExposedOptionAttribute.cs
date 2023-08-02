namespace Tevux.Dashboards.Abstractions;

public enum OptionType {
    Number,
    SingleLineText,
    MultiLineText,
    ChoiceText
}

[AttributeUsage(AttributeTargets.Property)]
public class ExposedChoiceAttribute : ExposedOptionAttribute {
    public ExposedChoiceAttribute(bool isEditable = true, bool isSaveable = true, params string[] choices) : base(OptionType.ChoiceText, isEditable, isSaveable, choices) { }
}

[AttributeUsage(AttributeTargets.Property)]
public class ExposedNumberAttribute : ExposedOptionAttribute {
    public ExposedNumberAttribute(bool isEditable = true, bool isSaveable = true) : base(OptionType.Number, isEditable, isSaveable) { }
}

[AttributeUsage(AttributeTargets.Property)]
public class ExposedOptionAttribute : Attribute {
    public ExposedOptionAttribute(OptionType optionType, bool isEditable = true, bool isSaveable = true, string[]? choices = null) {
        OptionType = optionType;
        IsEditable = isEditable;
        IsSaveable = isSaveable;

        switch (optionType) {
            case OptionType.ChoiceText:
                if (choices != null) {
                    foreach (var parameter in choices) {
                        Choices.Add(parameter.ToString());
                    }
                }
                break;
        }
    }

    public List<string> Choices { get; private set; } = new();
    public bool IsEditable { get; private set; }
    public bool IsSaveable { get; private set; }
    public OptionType OptionType { get; private set; }
}

[AttributeUsage(AttributeTargets.Property)]
public class ExposedSingleLineTextAttribute : ExposedOptionAttribute {
    public ExposedSingleLineTextAttribute(bool isEditable = true, bool isSaveable = true) : base(OptionType.SingleLineText, isEditable, isSaveable) { }
}

[AttributeUsage(AttributeTargets.Property)]
public class ExposedMultiLineTextAttribute : ExposedOptionAttribute {
    public ExposedMultiLineTextAttribute(bool isEditable = true, bool isSaveable = true) : base(OptionType.MultiLineText, isEditable, isSaveable) { }
}
