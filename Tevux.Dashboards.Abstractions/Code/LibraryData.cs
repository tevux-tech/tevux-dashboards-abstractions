using System.Runtime.Loader;
using Tevux.Dashboards.Designer;

namespace Tevux.Dashboards.Abstractions;

public class LibraryData {
    public AssemblyLoadContext AssemblyContext { get; init; } = null!;
    public Dictionary<ConnectionProviderAttribute, Type> ConnectionProviders { get; } = new();
    public string FriendlyName { get; init; } = "";
    public UniqueName Name { get; init; } = new();
    public Dictionary<OptionEditorAttribute, Type> OptionEditors { get; } = new();
    public FileInfo RootAssemblyInfo { get; init; } = null!;
    public Type? ScriptContext { get; set; }

    public override string ToString() {
        return Name.ToString();
    }
}
