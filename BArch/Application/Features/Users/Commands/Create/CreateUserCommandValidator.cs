using Domain.Constants;
using FluentValidation;
using SQLitePCL;

namespace Application.Features.Users.Commands.Create;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.User.Email)
            .NotEmpty();

        RuleFor(x => x.User.PasswordHash)
            .NotEmpty();

        RuleFor(x => x.User.FullName.ToCharArray().Length)
            .GreaterThanOrEqualTo(3);
        
        RuleFor(x => x.User.UserName.ToCharArray().Length)
            .GreaterThanOrEqualTo(5);

        RuleFor(x => x.User.UserName)
            .NotEmpty().WithMessage(Messages.User.Empty)
            .MinimumLength(Constants.minimumUserNameLength)
            .WithMessage(Messages.User.MinimumLength(Constants.minimumUserNameLength))
            .Matches(@"^[a-zA-Z0-9]*$").WithMessage(Messages.User.CantContainError);
    }
}
