namespace Domain.Entities;

/// <summary>
/// Represents an application user with audit information, including full name, username, email, and password hash.
/// Inherits audit properties from <see cref="BaseAuditableEntity"/>.
/// </summary>
public class User : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the full name of the user.
    /// </summary>
    public string FullName { get; set; } = default!;

    /// <summary>
    /// Gets or sets the unique username of the user.
    /// </summary>
    public string UserName { get; set; } = default!;

    /// <summary>
    /// Gets or sets the email address of the user.
    /// </summary>
    public string Email { get; set; } = default!;

    /// <summary>
    /// Gets or sets the hashed password of the user.
    /// </summary>
    public string PasswordHash { get; set; } = default!;
}