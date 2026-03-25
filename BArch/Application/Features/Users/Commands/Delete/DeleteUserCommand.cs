namespace Application.Features.Users.Commands.Delete;

public record DeleteUserCommand(User User) : IRequest<Response>;
