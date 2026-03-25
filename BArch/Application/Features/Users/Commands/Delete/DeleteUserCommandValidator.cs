using FluentValidation;

namespace Application.Features.Users.Commands.Delete;

public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
{
    public DeleteUserCommandValidator()
    {
        RuleFor(x => x.User.Id)
            .NotEmpty();
    }
}
