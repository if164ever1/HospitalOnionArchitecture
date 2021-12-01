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
        public void Delete(T entity)
        {
            var userId = db.Users.Find(entity.Id);

            if (userId != null)
            {
                db.Users.Remove(userId);
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
            var user = db.Users.Find(id);
            return (T)user;
        }

        public void Insert(T user)
        {
            db.Users.Add(user);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void UpdateDb(T user)
        {
            db.Entry(user).State = EntityState.Modified;
        }
    }
}
