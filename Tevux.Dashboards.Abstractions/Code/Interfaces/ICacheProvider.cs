namespace Tevux.Dashboards.Abstractions;

/// <summary>
/// Provides methods to load/save simple data to a cache.
/// </summary>
public interface ICacheProvider {
    /// <summary>
    /// Tries reading an integer value from the cache.
    /// </summary>
    /// <param name="owner">Owner of the value. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">>Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings.</param>
    /// <param name="value">Value read from the cache. If unsuccessful, value will be set to 0.</param>
    public bool TryRead(object owner, string propertyName, out int value);

    /// <summary>
    /// Tries reading a double value from the cache.
    /// </summary>
    /// <param name="owner">Owner of the value. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">>Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings..</param>
    /// <param name="value">Value read from the cache. If unsuccessful, value will be set to 0.0.</param>
    public bool TryRead(object owner, string propertyName, out double value);

    /// <summary>
    /// Tries reading a string value from the cache.
    /// </summary>
    /// <param name="owner">Owner of the value. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">>Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings..</param>
    /// <param name="value">Value read from the cache. If unsuccessful, value will be set to empty string.</param>
    public bool TryRead(object owner, string propertyName, out string value);

    /// <summary>
    /// Tries reading a dictionary of integers from the cache.
    /// </summary>
    /// <param name="owner">Owner of the value. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">>Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings..</param>
    /// <param name="value">Dictionary read from the cache. If unsuccessful, dictionary will be empty.</param>
    public bool TryRead(object owner, string propertyName, out Dictionary<string, int> value);

    /// <summary>
    /// Tries reading a dictionary of doubles from the cache.
    /// </summary>
    /// <param name="owner">Owner of the value. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">>Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings..</param>
    /// <param name="value">Dictionary read from the cache. If unsuccessful, dictionary will be empty.</param>
    public bool TryRead(object owner, string propertyName, out Dictionary<string, double> value);

    /// <summary>
    /// Tries reading a dictionary of strings from the cache.
    /// </summary>
    /// <param name="owner">Owner of the value. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">>Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings..</param>
    /// <param name="value">Dictionary read from the cache. If unsuccessful, dictionary will be empty.</param>
    public bool TryRead(object owner, string propertyName, out Dictionary<string, string> value);

    /// <summary>
    /// Tries reading an array of integers from the cache.
    /// </summary>
    /// <param name="owner">Owner of the value. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">>Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings..</param>
    /// <param name="value">Array read from the cache. If unsuccessful, array will be empty.</param>
    public bool TryRead(object owner, string propertyName, out int[] value);

    /// <summary>
    /// Tries reading an array of doubles from the cache.
    /// </summary>
    /// <param name="owner">Owner of the value. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">>Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings..</param>
    /// <param name="value">Array read from the cache. If unsuccessful, array will be empty.</param>
    public bool TryRead(object owner, string propertyName, out double[] value);

    /// <summary>
    /// Tries reading an array of strings from the cache.
    /// </summary>
    /// <param name="owner">Owner of the value. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">>Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings..</param>
    /// <param name="value">Array read from the cache. If unsuccessful, array will be empty.</param>
    public bool TryRead(object owner, string propertyName, out string[] value);

    /// <summary>
    /// Writes a single integer value to cache.
    /// </summary>
    /// <param name="owner">Owner of the value. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings.</param>
    /// <param name="value">Value to store.</param>
    void Write(object owner, string propertyName, int value);

    /// <summary>
    /// Writes a single double value to cache.
    /// </summary>
    /// <param name="owner">Owner of the value. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings.</param>
    /// <param name="value">Value to store.</param>
    void Write(object owner, string propertyName, double value);

    /// <summary>
    /// Writes a single string value to cache.
    /// </summary>
    /// <param name="owner">Owner of the value. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings.</param>
    /// <param name="value">Value to store.</param>
    void Write(object owner, string propertyName, string value);

    /// <summary>
    /// Writes a dictionary of integers to cache.
    /// </summary>
    /// <param name="owner">Owner of the dictionary. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings.</param>
    /// <param name="value">Dictionary to store.</param>
    void Write(object owner, string propertyName, Dictionary<string, int> value);

    /// <summary>
    /// Writes a dictionary of doubles to cache.
    /// </summary>
    /// <param name="owner">Owner of the dictionary. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings.</param>
    /// <param name="value">Dictionary to store.</param>
    void Write(object owner, string propertyName, Dictionary<string, double> value);

    /// <summary>
    /// Writes a dictionary of strings to cache.
    /// </summary>
    /// <param name="owner">Owner of the dictionary. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings.</param>
    /// <param name="value">Dictionary to store.</param>
    void Write(object owner, string propertyName, Dictionary<string, string> value);

    /// <summary>
    /// Writes an array of integers to cache.
    /// </summary>
    /// <param name="owner">Owner of the dictionary. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings.</param>
    /// <param name="value">Array to store.</param>
    void Write(object owner, string propertyName, int[] value);

    /// <summary>
    /// Writes an array of doubles to cache.
    /// </summary>
    /// <param name="owner">Owner of the dictionary. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings.</param>
    /// <param name="value">Array to store.</param>
    void Write(object owner, string propertyName, double[] value);

    /// <summary>
    /// Writes an array of strings to cache.
    /// </summary>
    /// <param name="owner">Owner of the dictionary. It is best to use 'this' keyword.</param>
    /// <param name="propertyName">Can be anything as long as it is a unique string per owner. Using 'nameof(PropertyName)' works well, just watch out for code refactorings.</param>
    /// <param name="value">Array to store.</param>
    void Write(object owner, string propertyName, string[] value);
}
