using HospitalOnionArchitecture.Domain.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace InfrastructureRepository
{
    public class Repository<T> : IRepository<T> where T : User
    {
        private readonly RepositoryDbContext db;

        public Repository(RepositoryDbContext context)
        {
            db = context;
        }
        public void Delete(int id)
        {
            var user = GetUserById(id);

            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        public IEnumerable<T> GetAllAsync()
        {
            var users = db.Users.AsEnumerable();
            return (IEnumerable<T>)users;
        }

        public T GetByIdAsync(int id)
        {
            var user = GetUserById(id);
            return (T)user;
        }

        public void Insert(T user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void UpdateDb(T user)
        {
            db.Entry(user).State = EntityState.Modified;
        }

        public T GetUserById(int id)
        {
            return (T)db.Users.FirstOrDefault(user => user.Id == id);
        }
    }
}
