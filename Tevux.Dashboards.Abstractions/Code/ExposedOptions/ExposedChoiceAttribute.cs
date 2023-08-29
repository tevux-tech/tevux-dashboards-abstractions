namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Exposes a choice from a predefined string list property to the host application. Exposed properties are treated in a special way, for example, automatically saved/loaded. 
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class ExposedChoiceAttribute : ExposedOptionAttribute {
    /// <summary>
    /// Creates an exposed string choice attribute.
    /// </summary>
    /// <param name="isEditable">Set to <c>false</c> if you want to expose a read-only property to user, for example, last used connection parameters.</param>
    /// <param name="isSaveable">Set to <c>false</c> if you don't want value property to be saved in permanent storage (useful for properties that derive from other ones).</param>
    /// <param name="choices">An array of possible choice string values.</param>
    public ExposedChoiceAttribute(bool isEditable = true, bool isSaveable = true, params string[] choices) : base(OptionType.ChoiceText, isEditable, isSaveable, choices) { }

    /// <summary>
    /// Creates an exposed string choice attribute, which values were created from the provided enum.
    /// </summary>
    /// <param name="enumChoices">Enum to create choice names from.</param>
    /// <param name="isEditable">Set to <c>false</c> if you want to expose a read-only property to user, for example, last used connection parameters.</param>
    /// <param name="isSaveable">Set to <c>false</c> if you don't want value property to be saved in permanent storage (useful for properties that derive from other ones).</param>
    public ExposedChoiceAttribute(Enum enumChoices, bool isEditable = true, bool isSaveable = true) : base(OptionType.ChoiceText, isEditable, isSaveable, null) {
        Choices.AddRange(Enum.GetNames(enumChoices.GetType()));
    }
}
