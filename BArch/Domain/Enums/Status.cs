namespace Domain.Enums;

/// <summary>
/// Represents the status of a <see cref="Domain.Entities.User"/> entity.
/// </summary>
public enum Status : byte
{
    /// <summary>
    /// The user is active and can use the system.
    /// </summary>
    Active,

    /// <summary>
    /// The user is inactive or temporarily disabled.
    /// </summary>
    Passived,

    /// <summary>
    /// The user has been deleted or removed from the system.
    /// </summary>
    Deleted
}