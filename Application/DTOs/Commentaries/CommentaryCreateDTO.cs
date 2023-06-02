﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Commentaries
{

    public class CommentaryCreateDTO
    {
        public string Description { get; set; } = "";
        public Guid UserId { get; set; }
        public Guid DrugId { get; set; }
    }
}