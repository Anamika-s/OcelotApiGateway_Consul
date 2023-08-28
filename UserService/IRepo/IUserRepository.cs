using UserService.Models;

namespace UserService.IRepo
{
    public interface IUserRepository
    {
        User AddUser(User user);
        List<User> GetUsers();
        User GetById(int id);
        bool EditUser(int id, User user);
        bool DeleteUser(int id);

    }
}
