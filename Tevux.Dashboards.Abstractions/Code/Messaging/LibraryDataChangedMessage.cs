namespace Tevux.Dashboards.Abstractions;

public class LibraryDataChangedMessage : GenericMessage {
    public Dictionary<string, LibraryData> AvailableLibraryData { get; } = new();
}
