using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Drugs
{
    public class DrugUpdateDTO :DrugBaseDTO
    {
        public string DrugName { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal DrugPrice { get; set; }
        public DateTime Created { get; set; }
        public bool IsActive { get; set; } = true;
        public string ImageUrl { get; set; } = "";

        public Guid CategoryId { get; set; }
    }
}
