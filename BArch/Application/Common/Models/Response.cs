namespace Application.Common.Models;

/// <summary>
/// Represents a standard response returned from an operation,
/// indicating whether it was successful along with optional error and message details.
/// </summary>
public record Response(bool _IsSuccess, string? _Error, string? _Message);
/// <summary>
/// Represents a standard response returned from an operation,
/// indicating whether it was successful along with optional error and message details.
/// </summary>
public record Response<T>(bool _IsSuccess, string? _Error, string? _Message, T? _Data);
