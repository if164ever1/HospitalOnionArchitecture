using HospitalOnionArchitecture.Domain.Core;
using InfrastructureRepository;
using ServiceAcount.PassHash;
using ServiceUser;
using System;
using System.Linq;

namespace ServiceAcount
{
    public class Login
    {
        private IUserService userService;
        private RepositoryDbContext dbContext;

        public Login(IUserService service, RepositoryDbContext context)
        {
            dbContext = context;
            userService = service;
        }

        public bool LoginUser(User user)
        {
            var validUser = dbContext.Users.SingleOrDefault(x => x.Email == user.Email);

            var token = Guid.NewGuid().ToString();

            if (validUser == null || !(CustomHash.PasswordCheck(user.Password, validUser.Password)))
            {
                return false;
            }

            var currentUserId = dbContext.Tokens.SingleOrDefault(u => u.IdUserRef == validUser.Id);

            if (currentUserId == null)
            {
                dbContext.Tokens.Add(new Domain.Model.TokenModel { Token = token, IdUserRef = validUser.Id });
            }
            else
            {
                currentUserId.Token = token;
            }
                
            userService.Save();

            return true;
        }

    }
}
