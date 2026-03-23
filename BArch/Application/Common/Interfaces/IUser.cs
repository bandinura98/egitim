namespace Application.Common.Interfaces;

/// <summary>
/// Represents a user entity with a unique identifier.
/// </summary>
public interface IUser
{
    /// <summary>
    /// Gets the unique identifier of the user.
    /// </summary>
    Guid Id { get; }
}