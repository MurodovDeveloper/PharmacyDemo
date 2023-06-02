using Domain.Common;
using Domain.Entities.Models;
namespace Domain.Entities.IdentityEntities;
public class Role : BaseAuditableEntity
{
    public string? RoleName { get; set; } = "";
    public ICollection<Permission>? permissions { get; set; }
    public ICollection<User>? Users { get; set; }
}
