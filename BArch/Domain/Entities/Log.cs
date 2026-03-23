namespace Domain.Entities;

/// <summary>
/// Represents a log record that stores information about a specific operation or event,
/// including source, destination, protocol, and additional details.
/// Inherits audit properties from <see cref="BaseAuditableEntity"/>.
/// </summary>
public class Log : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the source of the log (e.g., originating system or IP address).
    /// </summary>
    public string Source { get; set; } = default!;

    /// <summary>
    /// Gets or sets the destination of the log (e.g., target system or IP address).
    /// </summary>
    public string Destination { get; set; } = default!;

    /// <summary>
    /// Gets or sets additional information or message details related to the log.
    /// </summary>
    public string Info { get; set; } = default!;

    /// <summary>
    /// Gets or sets the protocol used (e.g., HTTP, TCP, UDP).
    /// </summary>
    public string Protocol { get; set; } = default!;

    /// <summary>
    /// Gets or sets the visual classification or severity color of the log.
    /// </summary>
    public LogColor logColor { get; set; } = default!;
}