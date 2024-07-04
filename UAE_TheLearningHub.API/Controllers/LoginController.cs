using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UAE_TheLearningHub.Core.Data;
using UAE_TheLearningHub.Core.Service;

namespace UAE_TheLearningHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {

            var result =  _loginService.Login(login);
            if (result == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(result);
            }
        }
    }
}
