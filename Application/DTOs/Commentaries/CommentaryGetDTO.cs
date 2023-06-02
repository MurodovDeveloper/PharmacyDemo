using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Commentaries
{
    public class CommentaryGetDTO
    {
        public string Description { get; set; } = "";
        public User? User { get; set; }
        public Drug? drug { get; set; }
    }
}
