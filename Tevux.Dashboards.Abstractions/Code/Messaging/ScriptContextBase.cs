namespace Tevux.Dashboards.Abstractions;

public abstract class ScriptContextBase {
    public abstract ISharedLibraryMessenger Messenger { get; }
    public void WriteLine(string text) {
        Messenger.Send("editor-debug-output", new SetValueMessage(text));
    }
}
