using Domain.Entities;

namespace Application.Services
{
    public class UserService
    {
        public User Get(string name)
        {
            return new User() { Name = name };
        }
    }
}
