using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestNetCore.Business;
using RestNetCore.Data.VO;

namespace RestNetCore.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private ILoginBusiness _loginBusiness;

        public AuthController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }

        [HttpPost]
        [Route("signin")]
        public IActionResult Signin([FromBody] UserVO user)
        {
            if (user is null) return BadRequest("Ivalid client request");
            var token = _loginBusiness.ValidadeCredentials(user);

            if (token is null) return Unauthorized();

            return Ok(token);
        }

        [HttpPost]
        [Route("refresh")]
        public IActionResult Refresh([FromBody] TokenVO tokenVo)
        {
            if (tokenVo is null) return BadRequest("Ivalid client request");
            var token = _loginBusiness.ValidadeCredentials(tokenVo);
            if (token is null) return BadRequest("Ivalid client request");
            return Ok(token);
        }

        [HttpGet]
        [Route("revoke")]
        [Authorize("Bearer")]
        public IActionResult Revoke()
        {
            var userName = User.Identity.Name;
            var result = _loginBusiness.RevokeToken(userName);

            if (!result) return BadRequest("Ivalid client request");
            return NoContent();
        }
    }
}
