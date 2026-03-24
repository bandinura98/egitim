using FluentValidation;

namespace Application.Features.Users.Commands.Update;

public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(x => x.user.Email)
            .NotEmpty();

        RuleFor(x => x.user.UserName)
            .NotEmpty();

        RuleFor(x => x.user.FullName)
            .NotEmpty();

        RuleFor(x => x.user.UserName)
            .NotEmpty().WithMessage(Messages.User.Empty)
            .MinimumLength(Constants.minimumUserNameLength)
            .WithMessage(Messages.User.MinimumLength(Constants.minimumUserNameLength))
            .Matches(@"^[a-zA-Z0-9]*$").WithMessage(Messages.User.CantContainError);
    }
}
