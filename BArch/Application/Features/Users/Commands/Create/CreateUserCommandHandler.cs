using Domain.Constants;

namespace Application.Features.Users.Commands.Create;

public class CreateUserCommandHandler(IApplicationDbContext _context, IPasswordHasher _passwordHasher) : IRequestHandler<CreateUserCommand, Response>
{
    public async Task<Response> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        try { 
            User item = new User();
            item.Email = request.Email;
            item.PasswordHash = _passwordHasher.Hash(request.Password);
            item.FullName = "Deneme";
            item.UserName = "Deneme";

            _context.Users.Add(item);
            var saved = await _context.SaveChangesAsync(cancellationToken);

            return new Response(true, null, Messages.User.Created);

        }
        catch (Exception)
        {
            return new Response(true, null, Messages.User.NotCreated);
        }
    }
}
