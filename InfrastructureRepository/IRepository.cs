using HospitalOnionArchitecture.Domain.Core;
using System.Collections.Generic;

namespace InfrastructureRepository
{
    public interface IRepository<T> where T : User
    {
        IEnumerable<T> GetAllAsync();
        T GetByIdAsync(int id);
        void Insert(T user);
        void UpdateDb(T user);
        void Delete(int id);
        void Save();
    }
}