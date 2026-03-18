namespace Application.Features.Users.Commands.Create;

public class CreateUserCommandHandler(IApplicationDbContext _context, IPasswordHasher _passwordHasher) : IRequestHandler<CreateUserCommand, bool>
{
    public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        User item = new User();
        item.Email = request.Email;
        item.PasswordHash = _passwordHasher.Hash(request.Password);
        item.FullName = "Deneme";
        item.UserName = "Deneme";

        _context.Users.Add(item);
        var saved = await _context.SaveChangesAsync(cancellationToken);

        return saved > 0;
    }
}
