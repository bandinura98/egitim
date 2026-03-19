namespace Infratructure.Models;

public class GaussianNB : IAIModelChecker
{
    string IAIModelChecker.ModelName => "GaussianNB";

    public LogColor CheckLog(Logs log)
    {
        throw new NotImplementedException();
    }
}
