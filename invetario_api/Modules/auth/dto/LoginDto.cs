using System.ComponentModel.DataAnnotations;

namespace invetario_api.Modules.auth.dto
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [MinLength(3)]
        public string password { get; set; }
    }
}
