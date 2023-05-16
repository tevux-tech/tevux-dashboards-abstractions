namespace Tevux.Dashboards.Abstractions;
public interface ILoggingProvider {
    public void Error(string message);
    public void Info(string message);
    public void Warn(string message);
}

public class EmptyLoggingProvider : ILoggingProvider {
    public void Error(string message) { }
    public void Info(string message) { }
    public void Warn(string message) { }
}
