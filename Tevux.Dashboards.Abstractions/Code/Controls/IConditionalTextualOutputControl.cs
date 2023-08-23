namespace Tevux.Dashboards.Abstractions;
public interface IConditionalTextualOutputControl {
    string Rules { get; set; }

    public List<IAppearanceRuleStyle> GetStyles();
}
