using Domain.Constants;

namespace Infratructure.Factory;

/// <summary>
/// Factory class responsible for providing instances of <see cref="IAIModelChecker"/> based on model name.
/// </summary>
/// <param name="modelCheckers">The collection of available AI model checkers.</param>
public class AIModelFactory(IEnumerable<IAIModelChecker> modelCheckers) : IAIModelFactory
{
    private readonly IEnumerable<IAIModelChecker> _modelCheckers = modelCheckers;

    /// <summary>
    /// Retrieves the AI model checker with the specified model name.
    /// </summary>
    /// <param name="modelName">The name of the AI model to retrieve.</param>
    /// <returns>An instance of <see cref="IAIModelChecker"/> matching the name.</returns>
    /// <exception cref="Exception">Thrown if the model with the given name is not found.</exception>
    public IAIModelChecker GetModel(string modelName)
    {
        return _modelCheckers.FirstOrDefault(m => m.ModelName == modelName)
               ?? throw new Exception(Messages.AIModel.NotFound);
    }
}