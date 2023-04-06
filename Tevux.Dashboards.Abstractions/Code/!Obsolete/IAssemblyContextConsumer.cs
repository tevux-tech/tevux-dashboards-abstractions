using System.Runtime.Loader;

namespace Tevux.Dashboards.Abstractions;

[Obsolete]
public interface IAssemblyContextConsumer {
    public void SetAssemblyContext(AssemblyLoadContext loadContext);
}
