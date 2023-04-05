
namespace Tevux.Dashboards.Abstractions;

public interface IConnectionBackendProvider {
    public IConnectionBackend GetConnectionBackend();
}
