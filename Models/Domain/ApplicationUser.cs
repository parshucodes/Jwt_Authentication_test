using Microsoft.AspNetCore.Identity;

namespace Jwt_Auth_Pr.Models.Domain
{
    public class ApplicationUser:IdentityUser
    {
        public string? Name { get; set; }
    }
}
