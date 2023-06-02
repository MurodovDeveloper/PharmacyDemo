using Application.Abstraction;
using Domain.Entities.IdentityEntities;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAcces.Interceptor
{
    public class AppDbContext : DbContext, IApplicatonDbcontext
    {
        //private AuditableEntitySaveChangesInterceptor _interceptor;

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
           
        }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Commentary> Commentarys { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Category> Categories { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.AddInterceptors(_interceptor);
        //}

    }
}
