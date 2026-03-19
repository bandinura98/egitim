using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<User> Users { get; }
    DbSet<Logs> Logs { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
