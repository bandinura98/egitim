namespace Infratructure.Factory;

public class AIModelFactory : IAIModelFactory
{
    private readonly IEnumerable<IAIModelChecker> _modelCheckers;
    public AIModelFactory(IEnumerable<IAIModelChecker> modelCheckers)
    {
        _modelCheckers = modelCheckers;
    }
    public IAIModelChecker GetModel(string modelName)
    {
        return _modelCheckers.FirstOrDefault(m => m.ModelName == modelName)
               ?? throw new Exception("Model bulunamadı!");
    }
}
