namespace Domain.Common;

/// <summary>
/// Represents a base entity that contains a unique identifier for all entities.
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the entity.
    /// </summary>
    public Guid Id { get; set; }
}