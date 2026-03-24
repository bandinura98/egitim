namespace Domain.Enums;
/// <summary>
/// Represents possible colors for logs to indicate severity or type.
/// </summary>
public enum LogColor:byte
{
    /// <summary>Indicates a critical.</summary>
    Red,

    /// <summary>Indicates a successful operation.</summary>
    Green,

    /// <summary>Indicates a warning or caution.</summary>
    Yellow,

    /// <summary>Default or informational log color.</summary>
    White
}