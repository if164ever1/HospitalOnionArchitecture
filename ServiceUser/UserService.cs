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
            userRepository.Delete(1);
        }

        public User GetUser(int id)
        {
            return userRepository.GetByIdAsync(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetAllAsync();
        }

        public void InsertUser(User user)
        {
            userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.UpdateDb(user);
        }
    }
}
