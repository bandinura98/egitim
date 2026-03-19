
namespace Application.Common.Interfaces;

public interface IAIModelFactory
{
    IAIModelChecker GetModel(string modelName);
}
