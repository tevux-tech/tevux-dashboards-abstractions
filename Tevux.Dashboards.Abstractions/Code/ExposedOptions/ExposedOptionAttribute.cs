namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Base class for the other exposed option attributes. Not to be created directly.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class ExposedOptionAttribute : Attribute {
    internal ExposedOptionAttribute(OptionType optionType, bool isEditable = true, bool isSaveable = true, string[]? choices = null) {
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
