using Domain.Entities.IdentityEntities;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
namespace Application.Abstraction;
public interface IApplicatonDbcontext
{
    DbSet<T> Set<T>() where T : class;
    DbSet<Category> Categories { get; set; }
    DbSet<Drug> Drugs { get; set; }
    DbSet<Commentary> Commentarys { get; set; }
    DbSet<User> Users { get; set; }
    DbSet<Role> Roles { get; set; }
    DbSet<Permission> Permissions { get; set; }

    Task<int> SaveChangesAsync(CancellationToken token = default);
}
