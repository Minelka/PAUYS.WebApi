using PAUYS.AspNetCore.API.Models;
using PAUYS.Entity.Entities.Concrete;

namespace PAUYS.AspNetCore.API.Services
{
    public interface ITokenService
    {
        Task<TokenResult> GenerateToken(AppUser user);
        bool ValidateToken(string token);
    }
}