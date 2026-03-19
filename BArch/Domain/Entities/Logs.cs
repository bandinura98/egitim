
namespace Domain.Entities;

public class Logs : BaseAuditableEntity
{
    public string Source { get; set; } = default!;
    public string Destination { get; set; } = default!;
    public string Info { get; set; } = default!;
    public string Protocol { get; set; } = default!;
    public LogColor logColor { get; set; } = default!;
}
