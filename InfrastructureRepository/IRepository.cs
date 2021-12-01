using HospitalOnionArchitecture.Domain.Core;
using System.Collections.Generic;

namespace InfrastructureRepository
{
    interface IRepository<T> where T : User
    {
        IEnumerable<T> GetAllAsync();
        T GetByIdAsync(int id);
        void Insert(T user);
        void UpdateDb(T user);
        void Delete(T user);
        void Save();
    }
}