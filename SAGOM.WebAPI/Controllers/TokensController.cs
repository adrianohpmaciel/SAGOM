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

        public TokensController(IAuthenticate authentication, ISeedUserRoleInitial seedUserRoleInitial)
        {
            _authentication = authentication ??
                throw new ArgumentNullException(nameof(authentication));
            //seedUserRoleInitial.SeedUsers();
            //seedUserRoleInitial.SeedRoles();
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
