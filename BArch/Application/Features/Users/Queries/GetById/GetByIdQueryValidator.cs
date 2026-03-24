using Domain.Constants;
using FluentValidation;

namespace Application.Features.Users.Queries.GetById;

public class GetByIdQueryValidator : AbstractValidator<GetByIdQuery>
{
    public GetByIdQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(Messages.User.Empty);

        RuleFor(x => x.Id)
            .NotEqual(Guid.Empty)
            .WithMessage(Messages.User.FormatInconsistency);
    }
}
