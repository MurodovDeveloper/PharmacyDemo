﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Categories
{
    public class CategoryGetDTO
    {
        public string Name { get; set; } = "";
        public ICollection<Guid>? DrugsId { get; set; }
    }
}
