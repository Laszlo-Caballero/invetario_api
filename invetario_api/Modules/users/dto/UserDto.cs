using System.ComponentModel.DataAnnotations;

namespace invetario_api.Modules.users.dto
{
    public class UserDto
    {
        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [MinLength(3)]
        public string password { get; set; }

        [Required]
        [MinLength(2)]
        public string firstName { get; set; }

        [Required]
        [MinLength(2)]
        public string lastName { get; set; }
    }
}
