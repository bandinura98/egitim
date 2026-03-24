namespace Application.Features.Users.Commands.Create;

public class CreateUserCommandHandler(IApplicationDbContext _context, IPasswordHasher _passwordHasher) : IRequestHandler<CreateUserCommand, Response>
{
    public async Task<Response> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        try { 

            _context.Users.Add(request.User);
            var saved = await _context.SaveChangesAsync(cancellationToken);

            return new Response(true, null, Messages.User.Created);

        }
        catch (Exception)
        {
            return new Response(true, null, Messages.User.NotCreated);
        }
    }
}
