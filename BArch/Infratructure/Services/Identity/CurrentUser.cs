namespace Infratructure.Services.Identity;

public class CurrentUser : IUser
{
    public Guid Id => Guid.NewGuid();
}
