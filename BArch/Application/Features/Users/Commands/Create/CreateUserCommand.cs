namespace Application.Features.Users.Commands.Create;

public record CreateUserCommand(string Email, string Password) : IRequest<Response>;
