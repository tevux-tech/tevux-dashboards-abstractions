namespace Tevux.Dashboards.Abstractions;

public sealed class EmptyScriptContextBase : ScriptContextBase {
    public override ISharedLibraryMessagingProvider Messenger { get; } = new EmptySharedLibraryMessagingProvider();
}
