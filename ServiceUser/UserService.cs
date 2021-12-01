using HospitalOnionArchitecture.Domain.Core;
using InfrastructureRepository;
using System.Collections.Generic;

namespace ServiceUser
{
    public class UserService : IUserService
    {
        private IRepository<User> userRepository;

        public UserService(IRepository<User> repository)
        {
            userRepository = repository;
        }
        public void DeleteUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetAllAsync();
        }

        public void InsertUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
