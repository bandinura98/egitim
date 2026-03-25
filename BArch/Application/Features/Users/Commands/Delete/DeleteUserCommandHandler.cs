using MediatR;

namespace Application.Features.Users.Commands.Delete;

public class DeleteUserCommandHandler(IApplicationDbContext _context) : IRequestHandler<DeleteUserCommand, Response>
{
    public async Task<Response> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        User? user = await _context.Users.FindAsync([request.User.Id], cancellationToken);

        if (user == null) return new ErrorResponse();
        user.Id = request.User.Id;
        
        _context.Users.Remove(user);
        var result = await _context.SaveChangesAsync(cancellationToken);

        return result > 0 ? new SuccessResponse()
        : new ErrorResponse();

    }
}
