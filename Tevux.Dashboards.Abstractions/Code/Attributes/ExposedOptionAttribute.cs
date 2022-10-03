namespace Tevux.Dashboards.Abstractions;

public enum OptionType {
    Number,
    SingleLineText,
    MultiLineText,
    ChoiceText,
    ChoiceTextYesNo
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

            case OptionType.ChoiceTextYesNo:
                Choices.Add("yes");
                Choices.Add("no");
                break;
        }
    }

    public List<string> Choices { get; private set; } = new List<string>();
    public OptionType OptionType { get; private set; }
    public bool IsEditable { get; private set; }
    public bool IsSaveable { get; private set; }
}
