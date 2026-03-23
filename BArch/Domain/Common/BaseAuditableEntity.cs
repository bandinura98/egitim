namespace Domain.Common;

/// <summary>
/// Represents a base entity that includes audit information such as creation and modification details.
/// Inherits from <see cref="BaseEntity"/>.
/// </summary>
public abstract class BaseAuditableEntity : BaseEntity
{
    /// <summary>
    /// Gets or sets the date and time when the entity was created.
    /// </summary>
    public DateTimeOffset Created { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user who created the entity.
    /// </summary>
    public string CreatedBy { get; set; } = default!;

    /// <summary>
    /// Gets or sets the date and time when the entity was last modified, if applicable.
    /// </summary>
    public DateTimeOffset? LastModified { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user who last modified the entity, if applicable.
    /// </summary>
    public string? LastModifiedBy { get; set; }

    /// <summary>
    /// Gets or sets the current status of the entity.
    /// </summary>
    public Status? Status { get; set; }
}