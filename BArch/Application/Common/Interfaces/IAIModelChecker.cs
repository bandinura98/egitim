namespace Application.Common.Interfaces;

/// <summary>
/// Represents an AI model capable of analyzing logs and returning a corresponding <see cref="LogColor"/>.
/// </summary>
public interface IAIModelChecker
{
    /// <summary>
    /// Gets the name of the AI model (e.g., "NaiveBayes", "SVM").
    /// </summary>
    string ModelName { get; }

    /// <summary>
    /// Analyzes the given <see cref="Log"/> and determines its corresponding <see cref="LogColor"/>.
    /// </summary>
    /// <param name="log">The log to be evaluated by the AI model.</param>
    /// <returns>The color representing the log's severity or type.</returns>
    LogColor CheckLog(Log log);
}