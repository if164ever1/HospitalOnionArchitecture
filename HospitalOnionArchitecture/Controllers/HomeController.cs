using Domain.NewFolder;
using HospitalOnionArchitecture.Domain.Core;
using InfrastructureRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceAcount;
using ServiceUser;


namespace HospitalOnionArchitecture.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController : Controller
    {
        //private IUserService userService;
        private readonly Register register;
        private readonly Login login;
        public HomeController(IUserService service, RepositoryDbContext context)
        {
            register = new Register(service, context);
            login = new Login(service, context);
        }

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    if (register.foo() == true)
        //    {
        //        return Ok();
        //    }
        //    //var user = userService.GetUser(2);
        //    //return Ok(user);
        //    return BadRequest();
        //}

        [HttpPost("login")]
        public IActionResult Login(User loginRequest)
        {
            if (login.LoginUser(loginRequest))
            {
                return Ok("Login successfull");
            }
            return BadRequest("Email or password is incorect");
        }


        [HttpPost("register")]
        public IActionResult Put(RequestUser user)
        {

            if (register.Registration(user))
            {
                return Ok("Registration successfull");
            }
            return BadRequest("Email is already use");
        }
    }
}
