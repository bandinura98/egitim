using Domain.Constants;

namespace Domain.Exceptions;

/// <summary>
/// Represents an exception thrown when a user is unauthorized or not found.
/// </summary>
public class UnauthorizedUserException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnauthorizedUserException"/> class for the specified user.
    /// </summary>
    /// <param name="user">The user that caused the unauthorized access exception.</param>
    public UnauthorizedUserException()
        : base(Messages.User.NotFound)
    {
    }
}