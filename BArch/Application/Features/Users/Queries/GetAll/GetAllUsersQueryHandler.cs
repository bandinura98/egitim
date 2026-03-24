
using Domain.Constants;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Users.Queries.GetAll;

public class GetAllUsersQueryHandler(IApplicationDbContext _context) : IRequestHandler<GetAllUsersQuery, Response<List<User>>>
{
    public async Task<Response<List<User>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var response = await _context.Users
            .AsNoTracking()
            .ToListAsync(cancellationToken);

        return new Response<List<User>>(true, null, Messages.User.Getted, response);
    }

}
