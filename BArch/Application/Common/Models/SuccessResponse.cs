namespace Application.Common.Models;

public record SuccessResponse : Response
{
    public SuccessResponse(string? message = null)
        : base(true, null, message ?? Messages.User.Created)
    {
    }
}