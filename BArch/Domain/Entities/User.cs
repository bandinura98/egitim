namespace Domain.Entities;

public class User : BaseAuditableEntity
{
    public string FullName { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PasswordHash { get; set; } = default!;
}
