using SAGOM.Domain.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SAGOM.WebAPI.Models;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace SAGOM.WebAPI.Controllers
{
    [Route("sagomapi/[controller]")]
    [ApiController]
    public class TokensController : ControllerBase
    {
        private readonly IAuthenticate _authentication;
        private readonly IConfiguration _configuration;
        public TokensController(IAuthenticate authentication, IConfiguration configuration)//, ISeedUserRoleInitial seedUserRoleInitial)
        {
            _authentication = authentication ??
                throw new ArgumentNullException(nameof(authentication));
            _configuration = configuration;
            //seedUserRoleInitial.SeedUsers();
            //seedUserRoleInitial.SeedRoles();
        }

        [HttpPost("LoginUser")]
        public async Task<ActionResult<UserToken>> Login([FromBody] LoginModel userInfo)
        {
            var result = await _authentication.Authenticate(userInfo.Email, userInfo.Password);

            if (result)
            {
                UserToken token = GenerateToken(userInfo);
                return token;
                //return Ok($"User {userInfo.Email} login successfully");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid Login attempt.");
                return BadRequest(ModelState);
            }
        }

        private UserToken GenerateToken(LoginModel userInfo)
        {
            var claims = new HashSet<Claim>
            {
                new Claim("email", userInfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

            };

            // To obtain private key to submit a token
            var privateKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SecretKey"]));

            // To generate the digital key
            var credentials = new SigningCredentials(privateKey, SecurityAlgorithms.HmacSha256);

            // Time to token expires
            var timeToExpirateToken = DateTime.UtcNow.AddMinutes(15);

            // To generate token
            JwtSecurityToken token = new JwtSecurityToken
                (
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                signingCredentials: credentials
                );

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = timeToExpirateToken
            };


        }
    }
}
