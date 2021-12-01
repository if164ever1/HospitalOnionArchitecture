using HospitalOnionArchitecture.Domain.Core;
using System.Collections.Generic;

namespace ServiceUser
{
    interface iUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
