using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class Commentary : BaseAuditableEntity
    {
        public string Text { get; set; } = "";
        public Guid UserId { get; set; }
        public User? User { get; set; } 
        public Guid DrugId { get; set; }
        public Drug? Drug { get; set; }
    }
}
