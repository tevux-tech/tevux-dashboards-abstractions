namespace Tevux.Dashboards.Abstractions;

public interface IAppearanceRule {
    public AppearanceRuleCondition Condition { get; set; }
    IAppearanceRuleStyle Style { get; }
    public string TextFormat { get; set; }
}
