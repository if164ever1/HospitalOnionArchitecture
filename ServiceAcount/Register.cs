using Domain.MapModel;
using InfrastructureRepository;
using ServiceUser;
using System;
using System.Linq;

namespace ServiceAcount
{
    public class Register
    {
        private IUserService userService;
        private RepositoryDbContext dbContext;
        public Register(IUserService service, RepositoryDbContext context)
        {
            dbContext = context;
            userService = service;
        }

        public void Registration(UserMap userMap)
        {
            //if (dbContext.Users.FirstOrDefault(db => db.Email == userMap.) != null)
            //{

            //}



            //if (userService.FirstOrDefault(u => u.Email == registerRequest.Email) != null)
            //{
            //    return BadRequest(new { message = "Login already use" });
            //}

            //UserModel userModel = new UserModel
            //{
            //    FirstName = registerRequest.FirstName,
            //    LastName = registerRequest.LastName,
            //    Email = registerRequest.Email,
            //    Password = CustomHash.HashPassword(registerRequest.Password)
            //};

            //userContext.Users.Add(userModel);
            //await userContext.SaveChangesAsync();

            //return Ok(new { message = "Registration is succesfuly" });
        }




    }
}
