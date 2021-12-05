using Domain.NewFolder;
using InfrastructureRepository;
using Microsoft.AspNetCore.Mvc;
using ServiceAcount;
using ServiceUser;

namespace HospitalOnionArchitecture.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RegisterController : Controller
    {
        private readonly Register register;
        private readonly Login login;
        public RegisterController(IUserService service, RepositoryDbContext context)
        {
            register = new Register(service, context);
            login = new Login(service, context);
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
