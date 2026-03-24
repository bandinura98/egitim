namespace Application.Features.Users.Queries.GetById;

public record GetByIdQuery(Guid Id) : IRequest<Response<User>>;
