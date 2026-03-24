namespace Application.Common.Models;

public record ErrorResponse : Response
{
    public ErrorResponse(string? message = null)
        : base(false, message ?? Messages.User.NotCreated,null)
    {
    }
}