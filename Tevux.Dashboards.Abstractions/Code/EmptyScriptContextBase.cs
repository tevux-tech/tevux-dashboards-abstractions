namespace Tevux.Dashboards.Abstractions;

public sealed class EmptyScriptContextBase : ScriptContextBase {
    public override ISharedLibraryMessenger Messenger { get; } = new EmptyLibraryMessenger();
}
