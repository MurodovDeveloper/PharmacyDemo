using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tokens
{
    public class RefreshToken : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Refresh { get; set; } = "";
        [Required]
        public string Username { get; set; }
        public string RefreshTokenValue { get; set; }

        public DateTime ActiveDate;
        public DateTime ExpiredDate { get; set; }
        
    }
}
