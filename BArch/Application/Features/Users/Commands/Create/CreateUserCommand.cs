namespace Application.Features.Users.Commands.Create;

public record CreateUserCommand(User User) : IRequest<Response>;
