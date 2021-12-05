using Domain.RequestModel;
using InfrastructureRepository;
using Microsoft.AspNetCore.Mvc;
using ServiceAcount;
using ServiceUser;

namespace HospitalOnionArchitecture.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LoginController : Controller
    {
        private readonly Register register;
        private readonly Login login;
        public LoginController(IUserService service, RepositoryDbContext context)
        {
            register = new Register(service, context);
            login = new Login(service, context);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequestUser loginRequest)
        {
            if (login.LoginUser(loginRequest))
            {
                return Ok("Login successfull");
            }
            return BadRequest("Email or password is incorect");
        }
    }
}
