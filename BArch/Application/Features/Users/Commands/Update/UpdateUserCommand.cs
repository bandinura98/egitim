namespace Application.Features.Users.Commands.Update;

public record UpdateUserCommand(User user) : IRequest<Response>;