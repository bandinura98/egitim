using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

/// <summary>
/// Represents the contract for the application's database context, exposing DbSet properties
/// and SaveChangesAsync functionality.
/// </summary>
public interface IApplicationDbContext
{
    /// <summary>
    /// Gets the <see cref="DbSet{User}"/> representing the Users table in the database.
    /// </summary>
    DbSet<User> Users { get; }

    /// <summary>
    /// Gets the <see cref="DbSet{Log}"/> representing the Logs table in the database.
    /// </summary>
    DbSet<Log> Logs { get; }

    /// <summary>
    /// Saves all changes made in this context to the database asynchronously.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>The number of state entries written to the database.</returns>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

}