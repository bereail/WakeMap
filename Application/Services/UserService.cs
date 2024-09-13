using Domain.Entities;

namespace Application.Services
{
    public class UserService
    {
        public User Get(string username)
        {
            return new User() { Username = username };
        }
    }
}
