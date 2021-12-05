using Domain.Model;
using HospitalOnionArchitecture.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureRepository
{
    public class RepositoryDbContext: DbContext
    {
        public RepositoryDbContext(DbContextOptions<RepositoryDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TokenModel> Tokens { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //        .HasOne(a => a.UserProfile)
        //        .WithOne(b => b.User)
        //        .HasForeignKey<UserProfile>(b => b.IdUserRef);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("Admin");
            //Map entity to table
            modelBuilder.Entity<User>().ToTable("UserInfo");
            modelBuilder.Entity<TokenModel>().ToTable("TokenInfo");
        }

    }
}
