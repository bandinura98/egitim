using Domain.Constants;

namespace Infratructure.Services.AIModelCheckers;

public class GaussianNB : IAIModelChecker
{
    string IAIModelChecker.ModelName => Messages.ModelChecker.Name;

    public LogColor CheckLog(Log log)
    {
        throw new NotImplementedException();
    }
}
