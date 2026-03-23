namespace Application.Common.Interfaces;

/// <summary>
/// Provides functionality for hashing passwords.
/// </summary>
public interface IPasswordHasher
{
    /// <summary>
    /// Generates a hashed representation of the given plain text password.
    /// </summary>
    /// <param name="password">The plain text password to hash.</param>
    /// <returns>The hashed password as a string.</returns>
    string Hash(string password);
}