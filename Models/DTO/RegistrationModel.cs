using System.ComponentModel.DataAnnotations;

namespace Jwt_Auth_Pr.Models.DTO
{
    public class RegistrationModel
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Name { get; set; }

    }
}
