using PAUYS.AspNetCore.API.Models;
using PAUYS.Entity.Entities.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using PAUYS.AspNetCore.API.Services;

namespace PAUYS.AspNetCore.API.Services
{
    public class JwtTokenService : ITokenService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public JwtTokenService(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        public async Task<TokenResult> GenerateToken(AppUser user)
        {
            var jwtTokenResult = new TokenResult();

            var jwtSettings = _configuration.GetSection("Jwt");
            var securityKey = jwtSettings["SecurityKey"] ?? "jwtSettings-null";
            var issuer = jwtSettings["Issuer"] ?? "jwtSettings-null";
            var audience = jwtSettings["Audience"] ?? "jwtSettings-null";
            DateTime expireTime = DateTime.Now.AddMinutes(double.Parse(jwtSettings["ExpireTime"] ?? "30"));

            List<Claim> userClaims = new List<Claim>();

            IList<string>? userRoles = await _userManager.GetRolesAsync(user);

            userClaims.Add(new Claim(ClaimTypes.NameIdentifier, user?.Id ?? "user-null"));
            userClaims.Add(new Claim(ClaimTypes.Name, user?.UserName ?? "user-null"));
            userClaims.Add(new Claim(ClaimTypes.Email, user?.Email ?? "user-null"));

            foreach (string userRole in userRoles)
                userClaims.Add(new Claim(ClaimTypes.Role, userRole));

            SecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

            SigningCredentials signingCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token = new JwtSecurityToken(issuer: issuer, audience: audience, claims: userClaims, expires: expireTime, signingCredentials: signingCred);

            jwtTokenResult.Token = new JwtSecurityTokenHandler().WriteToken(token);
            jwtTokenResult.ExpireTime = expireTime;

            return jwtTokenResult;
        }

        public bool ValidateToken(string token)
        {
            return false;
        }
    }
}
