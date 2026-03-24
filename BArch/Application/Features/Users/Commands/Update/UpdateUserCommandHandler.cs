namespace Application.Features.Users.Commands.Update;

public class UpdateUserCommandHandler(IApplicationDbContext _context) : IRequestHandler<UpdateUserCommand, Response>
{
    public async Task<Response> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var user = await _context.Users.FindAsync(new object[] { request.user.Id }, cancellationToken);
            if (user == null)
                return new ErrorResponse();
            user.FullName = request.user.FullName;
            user.Email = request.user.Email;
            user.UserName = request.user.UserName;
            var saved = await _context.SaveChangesAsync(cancellationToken);
            return new SuccessResponse();
        }
        catch (Exception e)
        {
            return new Response(false, e.Message, Messages.User.NotCreated);
        }
    }
}
