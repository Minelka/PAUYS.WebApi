using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PAUYS.Entity.Entities.Concrete;
using PAUYS.ViewModel.Concrete;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace PAUYS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
        public class AuthController : ControllerBase
        {
            private readonly UserManager<AppUser> _userManager;
            private readonly SignInManager<AppUser> _signInManager;
            private readonly IConfiguration _config;
            private readonly double _addMinutes;
            private readonly string _expires;

            public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IConfiguration config)
            {
                _userManager = userManager;
                _signInManager = signInManager;
                _config = config;

                double.TryParse(_config["JWTSettings:ExpireTime"], out _addMinutes);

                _expires = DateTime.Now.AddMinutes(_addMinutes).ToString();
            }

            [HttpPost("Login")]

            public async Task<ActionResult> Login([FromBody] LoginRequestViewModel model)
            {
                AppUser? kullanici = await _userManager.FindByEmailAsync(model.UserName);

                if (kullanici is null)
                    return Unauthorized("Kullanıcı Adı veya şifreniz yanlıştır.");

                SignInResult result = await _signInManager.CheckPasswordSignInAsync(kullanici, model.Password, false);

                if (result.IsNotAllowed)
                    return Unauthorized("Hesabınız aktif değildir.");

                if (result.IsLockedOut)
                    return Unauthorized("Hesabınız kilitlenmiştir.");

                if (result.RequiresTwoFactor)
                    return Unauthorized("İkili doğrulama adımı gerekiyor.");

                if (!result.Succeeded)
                    return Unauthorized("Kullanıcı Adı veya şifreniz yanlıştır.");


                var token = GenerateToken(kullanici);

                return Ok(new LoginResponseViewModel { Token = token, Expires = _expires });
            }

            private string GenerateToken(AppUser kullanici)
            {

                List<Claim> claims = new List<Claim>
                {
                new Claim(ClaimTypes.NameIdentifier, kullanici.Id),
                new Claim(JwtRegisteredClaimNames.GivenName, kullanici.FirstName),
                new Claim(JwtRegisteredClaimNames.FamilyName, kullanici.LastName),
                new Claim(JwtRegisteredClaimNames.Email, kullanici.Email),
                new Claim(JwtRegisteredClaimNames.Name, kullanici.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.Ticks.ToString())
            };

            List<string> roles = _userManager.GetRolesAsync(kullanici).Result.ToList();

            foreach(string role in roles)
                claims.Add(new Claim(ClaimTypes.Role, role));



                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWTSettings:SecretKey"]));

                var signingCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    issuer: _config["JWTSettings:Issuer"],
                    audience: _config["JWTSettings:Audience"],
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(_addMinutes),
                    signingCredentials: signingCred
                    );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }

        }
}
