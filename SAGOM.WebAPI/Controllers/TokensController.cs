using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SAGOM.WebAPI.Models;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SAGOM.Application.Interfaces.UserInterfaces;
using SAGOM.Application.DTOs;
using SAGOM.Domain.Entities;

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
        public async Task<ActionResult<UserTokenModel>> Login([FromBody] LoginModel userInfo)
        {
            AuthenticateDTO auth = new AuthenticateDTO(userInfo.Email, userInfo.Password);
            var result = await _authentication.Login(auth);

            if (result)
            {
                UserTokenModel token = GenerateToken(userInfo);
                return token;
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid Login attempt.");
                return BadRequest(ModelState);
            }
        }

        [HttpPost("CreateCostumer")]
        public async Task<ActionResult> CreateCostumer([FromBody] ClienteCadastroModel auth)
        {
            AuthenticateDTO authDTO = new AuthenticateDTO(auth.Email, auth.Password);
            CostumerDTO costumer = new CostumerDTO(auth.Cpf, new PersonDTO(auth.Cpf, auth.Email, auth.Nome, auth.SobreNome, auth.Endereco, auth.Celular));

            var result = false;

            try
            {
                result = await _authentication.SignUp(costumer, authDTO);
            }
            catch
            {
                return BadRequest("Informações inválidas.");
            }

            if (result)
            {
                return Ok("Cliente cadastrado com sucesso.");
            }
            else
            {
                return BadRequest("Informações inválidas.");
            }
        }

        [HttpPost("CreateEmployee")]
        public async Task<ActionResult> CreateEmployee([FromBody] ColaboradorCadastroModel auth)
        {
            AuthenticateDTO authDTO = new AuthenticateDTO(auth.Email, auth.Password, auth.NomeCargo);

            EmployeeDTO employee = new EmployeeDTO(new PersonDTO(auth.Cpf, auth.Email, auth.Nome, auth.SobreNome, auth.Endereco, auth.Celular));

            var result = false;

            try
            {
                result = await _authentication.SignUp(employee, authDTO);
            }
            catch
            {
                return  NotFound("Falha ao tentar realizar o cadastro");
            }

            if (result)
            {
                return Ok("Cliente cadastrado com sucesso.");
            }
            else
            {
                return BadRequest("Informações inválidas.");
            }
        }

        private UserTokenModel GenerateToken(LoginModel userInfo)
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

            return new UserTokenModel
                (
                    new JwtSecurityTokenHandler().WriteToken(token),
                    timeToExpirateToken
                );


        }
    }
}
