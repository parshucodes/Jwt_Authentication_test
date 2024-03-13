using System.ComponentModel.DataAnnotations;

namespace Jwt_Auth_Pr.Models.DTO
{
    public class ChangePasswordModel
    {
        [Required]
        public string CurrentPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Required]
        [Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }
        [Required]
        public string Username { get; set; }
    }
}
