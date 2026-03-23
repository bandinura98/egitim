/// <summary>
/// Provides functionality to evaluate logs and determine their color or severity.
/// </summary>
public interface ILogs
{
    /// <summary>
    /// Determines the <see cref="LogColor"/> for the given <see cref="Log"/>.
    /// </summary>
    /// <param name="log">The log to evaluate.</param>
    /// <returns>The corresponding <see cref="LogColor"/>.</returns>
    LogColor CheckLog(Log log);
}