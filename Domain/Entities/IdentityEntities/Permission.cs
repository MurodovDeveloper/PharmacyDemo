using Domain.Common;
namespace Domain.Entities.IdentityEntities;
public class Permission : BaseEntity
{
    public string PermissionName { get; set; } = "";
    public ICollection<Role>? Roles { get; set; }

}
