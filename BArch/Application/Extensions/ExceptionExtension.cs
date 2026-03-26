namespace Application.Extensions;

public static class ExceptionExtension
{
    private static IEnumerable<Exception> Flatten(this Exception ex)
    {
        yield return ex;
        if (ex.InnerException != null)
        {
            foreach (var inner in ex.InnerException.Flatten())
                yield return inner;
        }
    }
    public static string[] ToStringArray(this Exception ex) {
        string[] errorArray = ex.Flatten().Select(e => e.Message).ToList().ToArray();

        return errorArray;
    }
}
