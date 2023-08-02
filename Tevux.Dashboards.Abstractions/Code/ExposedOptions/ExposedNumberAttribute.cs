namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Exposes a number property (<c>int</c>, <c>double</c> or <c>decimal</c>) to the host application. Exposed properties are treated in a special way, for example, automatically saved/loaded. 
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class ExposedNumberAttribute : ExposedOptionAttribute {
    /// <summary>
    /// Creates an exposed number attribute.
    /// </summary>
    /// <param name="isEditable">Set to <c>false</c> if you want to expose a read-only property to user, for example, last used connection parameters.</param>
    /// <param name="isSaveable">Set to <c>false</c> if you don't want value property to be saved in permanent storage (useful for properties that derive from other ones).</param>
    public ExposedNumberAttribute(bool isEditable = true, bool isSaveable = true) : base(OptionType.Number, isEditable, isSaveable) { }
}
