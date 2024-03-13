using Jwt_Auth_Pr.Models.DTO;
using System.Security.Claims;

namespace Jwt_Auth_Pr.Repositories.Abstact
{
    public interface ITokenService
    {
        TokenResponse GetToken(IEnumerable<Claim> claim);
        string GetRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
