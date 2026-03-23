namespace Application.Common.Models;

/// <summary>
/// Represents a standard response returned from an operation,
/// indicating whether it was successful along with optional error and message details.
/// </summary>
public class Response
{
    /// <summary>
    /// Gets or sets a value indicating whether the operation was successful.
    /// </summary>
    public static bool IsSuccess { get; set; }

    /// <summary>
    /// Gets or sets the error message if the operation failed.
    /// </summary>
    public static string? Error { get; set; }

    /// <summary>
    /// Gets or sets an informational message about the operation result.
    /// </summary>
    public static string? Message { get; set; }

    /// <summary>
    /// Gets or sets an informational message about the operation result.
    /// </summary>
    public static Object? Data { get; set; }


    /// <summary>
    /// Initializes a new instance of the <see cref="Response"/> class
    /// with the specified success status, error message, and informational message.
    /// </summary>
    /// <param name="_IsSuccess">Indicates whether the operation was successful.</param>
    /// <param name="_Error">The error message if the operation failed.</param>
    /// <param name="_Message">An informational message about the operation result.</param>

    public Response(bool _IsSuccess, string? _Error, string? _Message) {
        IsSuccess = _IsSuccess;
        Error = _Error;
        Message = _Message;
    }
}