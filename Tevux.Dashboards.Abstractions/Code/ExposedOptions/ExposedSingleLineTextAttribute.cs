namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Exposes a single-line of text property to the host application. Exposed properties are treated in a special way, for example, automatically saved/loaded. 
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class ExposedSingleLineTextAttribute : ExposedOptionAttribute {
    /// <summary>
    /// Creates an exposed single-line text attribute.
    /// </summary>
    /// <param name="isEditable">Set to <c>false</c> if you want to expose a read-only property to user, for example, last used connection parameters.</param>
    /// <param name="isSaveable">Set to <c>false</c> if you don't want value property to be saved in permanent storage (useful for properties that derive from other ones).</param>
    public ExposedSingleLineTextAttribute(bool isEditable = true, bool isSaveable = true) : base(OptionType.SingleLineText, isEditable, isSaveable) { }
}
