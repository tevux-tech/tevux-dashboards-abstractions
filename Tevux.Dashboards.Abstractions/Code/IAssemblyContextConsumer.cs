using System.Runtime.Loader;

namespace Tevux.Dashboards.Abstractions;

public interface IAssemblyContextConsumer {
    public void SetAssemblyContext(AssemblyLoadContext loadContext);
}
