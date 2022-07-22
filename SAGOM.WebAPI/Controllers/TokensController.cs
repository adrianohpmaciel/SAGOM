// MACORATTI, JOSÉ CARLOS. Curso Clean Architecture Essencial. Disponível em: https://www.udemy.com/course/clean-architecture-essencial-asp-net-core-com-c/. Acesso em: 20 jul. 2022.

using SAGOM.Domain.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SAGOM.WebAPI.Models;

namespace SAGOM.WebAPI.Controllers
{
    [Route("sagomapi/[controller]")]
    [ApiController]
    public class TokensController : ControllerBase
    {
        private readonly IAuthenticate _authentication;

        public TokensController(IAuthenticate authenticate)
        {
            _authentication = authenticate;
        }

        [HttpPost("LoginUser")]
        public async Task<ActionResult<UserToken>> Login([FromBody] LoginModel userInfo)
        {
            var result = await _authentication.Authenticate(userInfo.Email, userInfo.Password);

            if (result)
            {
                //return GenerateToken(userInfo);
                return Ok($"User {userInfo.Email} login successfully");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid Login attempt.");
                return BadRequest(ModelState);
            }
        }

        private ActionResult<UserToken> GenerateToken(LoginModel userInfo)
        {
            throw new NotImplementedException();
        }
    }
}
