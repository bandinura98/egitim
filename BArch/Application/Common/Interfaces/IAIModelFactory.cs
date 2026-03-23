namespace Application.Common.Interfaces;

/// <summary>
/// Factory interface for creating or retrieving AI model instances that implement <see cref="IAIModelChecker"/>.
/// </summary>
public interface IAIModelFactory
{
    /// <summary>
    /// Retrieves an <see cref="IAIModelChecker"/> instance corresponding to the specified model name.
    /// </summary>
    /// <param name="modelName">The name of the AI model (e.g., "NaiveBayes", "SVM").</param>
    /// <returns>An instance of <see cref="IAIModelChecker"/> representing the requested model.</returns>
    IAIModelChecker GetModel(string modelName);
}