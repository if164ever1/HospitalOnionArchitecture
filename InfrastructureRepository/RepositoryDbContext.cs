
using HospitalOnionArchitecture.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureRepository
{
    class RepositoryDbContext: DbContext
    {
        public RepositoryDbContext(DbContextOptions<RepositoryDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
