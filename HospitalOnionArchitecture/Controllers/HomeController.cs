using HospitalOnionArchitecture.Domain.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceUser;


namespace HospitalOnionArchitecture.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController : Controller
    {
        private IUserService userService;

        public HomeController(IUserService user)
        {
            userService = user;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var user = userService.GetUser(2);
            return Ok(user);
        }


        [HttpPost("register")]
        public IActionResult Put(User user)
        {
            userService.InsertUser(user);
            return Ok();
        }
    }
}
