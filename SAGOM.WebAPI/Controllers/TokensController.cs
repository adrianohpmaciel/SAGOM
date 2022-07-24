using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SAGOM.WebAPI.Models;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SAGOM.Application.Interfaces.UserInterfaces;
using SAGOM.Application.DTOs;

namespace SAGOM.WebAPI.Controllers
{
    [Route("sagomapi/[controller]")]
    [ApiController]
    public class TokensController : ControllerBase
    {
        private readonly IAuthenticateService _authentication;
        private readonly IConfiguration _configuration;
        public TokensController(IAuthenticateService authentication, IConfiguration configuration)
        {
            _authentication = authentication ??
                throw new ArgumentNullException(nameof(authentication));
            _configuration = configuration;
        }

        [HttpPost("LoginUser")]
        public async Task<ActionResult<UserToken>> Login([FromBody] LoginModel userInfo)
        {
            AuthenticateDTO auth = new AuthenticateDTO(userInfo.Email, userInfo.Password);
            var result = await _authentication.Login(auth);

            if (result)
            {
                UserToken token = GenerateToken(userInfo);
                return token;
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid Login attempt.");
                return BadRequest(ModelState);
            }
        }

        private UserToken GenerateToken(LoginModel userInfo)
        {
            HashSet<Claim> claims = new HashSet<Claim>
            {
                new Claim("email", userInfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

            };

            // To obtain private key to submit a token
            SymmetricSecurityKey privateKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SecretKey"]));

            // To generate the digital key
            SigningCredentials credentials = new SigningCredentials(privateKey, SecurityAlgorithms.HmacSha256);

            // Time to token expires
            DateTime timeToExpirateToken = DateTime.UtcNow.AddMinutes(15);

            // To generate token
            JwtSecurityToken token = new JwtSecurityToken
                (
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                signingCredentials: credentials
                );

            return new UserToken
                (
                    new JwtSecurityTokenHandler().WriteToken(token),
                    timeToExpirateToken
                );


        }
    }
}
