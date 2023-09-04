using UserService.Context;
using UserService.IRepo;
using UserService.Models;

namespace UserService.Repo
{
    public class UserRepository : IUserRepository
    {
        UserDBContext _context;
        public UserRepository(UserDBContext context)
        {
            _context = context;
        }
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
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
