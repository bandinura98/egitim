namespace Domain.Common;

public abstract class BaseAuditableEntity : BaseEntity
{
    public DateTimeOffset Created { get; set; }
    public string CreatedBy { get; set; } = default!;
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    public Status? Status{ get; set; }
}
