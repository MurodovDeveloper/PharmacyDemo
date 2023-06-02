using Domain.Common;
namespace Domain.Entities.Models;
public class Drug : BaseAuditableEntity
{
    public string DrugName { get; set; }

    public decimal DrugPrice { get; set; }

    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool IsActive { get; set; }

    public string ImageUrl { get; set; }

    public Guid CategoryId { get; set; }
    public Category Category { get; set; } 

    public ICollection<Commentary>? Commentary { get; set; }

  
}



