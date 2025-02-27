namespace PAUYS.AspNetCore.API.Models
{
    public class TokenResult
    {
        public string Token { get; set; } = null!;
        public DateTime ExpireTime { get; set; }
    }
}
