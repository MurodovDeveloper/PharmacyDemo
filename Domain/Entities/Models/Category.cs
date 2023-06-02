using Domain.Common;

namespace Domain.Entities.Models;
public class Category :BaseAuditableEntity
{
    public string CategoryName { get; set; } = "";
    public ICollection<Drug>? Drugs { get; set; }
}
