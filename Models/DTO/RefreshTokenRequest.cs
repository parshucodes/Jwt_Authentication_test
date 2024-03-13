namespace Jwt_Auth_Pr.Models.DTO
{
    public class RefreshTokenRequest
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }

    }
}
