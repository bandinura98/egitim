namespace Application.Common.Interfaces;

public interface IAIModelChecker
{
    string ModelName { get; } // "NaiveBayes", "SVM" vb. eklicez
    LogColor CheckLog (Logs log);
}
