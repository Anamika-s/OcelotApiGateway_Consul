using Microsoft.EntityFrameworkCore;
using UserService.Models;

namespace UserService.Context
{
    public class UserDBContext  : DbContext
    {
          public UserDBContext(DbContextOptions<UserDBContext> context)
                : base(context)
            {

            }

        public DbSet<User> Users { get; set; }

    }
    }
