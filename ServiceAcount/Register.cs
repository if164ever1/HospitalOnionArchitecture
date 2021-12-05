using Domain.NewFolder;
using HospitalOnionArchitecture.Domain.Core;
using InfrastructureRepository;
using ServiceAcount.PassHash;
using ServiceUser;
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

        public bool Registration(RequestUser user)
        {
            if (dbContext.Users.FirstOrDefault(db => db.Email == user.Email) != null)  //remake
            {
                return false;
            }
            else
            {
                User userModel = new User
                {
                    Email = user.Email,
                    Password = CustomHash.HashPassword(user.Password)
                };
                userService.InsertUser(userModel);
                userService.Save();
                return true;
            }
        }
    }
}
