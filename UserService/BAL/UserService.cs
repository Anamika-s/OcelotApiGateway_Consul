using UserService.IRepo;
using UserService.Models;
using UserService.Repo;

namespace BAL
{
    public class UserS
    {
        IUserRepository _repo;
        public UserS(IUserRepository repo)
        {
            _repo = repo;
        }

        public User AddUser(User user)
        {
            return _repo.AddUser(user);
        }

        public List<User> GetUsers()
        {   
            return _repo.GetUsers();
        }
        public User GetUser(int id)
        {
            return _repo.GetById(id);
        }

    }
}
