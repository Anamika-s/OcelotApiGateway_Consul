using System.ComponentModel.DataAnnotations;

namespace UserService.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MinLength(10)]
        public string UserName { get; set; }

        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
