using UserService.IRepo;
using UserService.Models;

namespace UserService.Repo
{
    public class UserRepository : IUserRepository
    {
        public User AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditUser(int id, User user)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
