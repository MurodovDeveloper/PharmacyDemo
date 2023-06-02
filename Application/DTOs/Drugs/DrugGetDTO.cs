using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Drugs
{
    public class DrugGetDTO
    {
        public string DrugName { get; set; } = "";

        public decimal DrugPrice { get; set; }

        public string Description { get; set; } = "";

        public DateTime CreatedAt { get; set; }

        public bool IsActive { get; set; }

        public string ImageUrl { get; set; } = "";

      
        public Category? Category { get; set; }

        public ICollection<Guid>? CommentariesId{ get; set; }


    }
}
