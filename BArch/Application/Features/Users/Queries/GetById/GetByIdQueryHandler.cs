using Domain.Constants;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Users.Queries.GetById;

public class GetByIdQueryHandler(IApplicationDbContext _context) : IRequestHandler<GetByIdQuery, Response<User>>
{
    public async Task<Response<User>> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

       return new Response<User>(true, null, Messages.User.Created, user);
    }
}