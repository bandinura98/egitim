namespace Application.Features.Users.Queries.GetAll;

public record GetAllUsersQuery() : IRequest<Response<List<User>>>;
