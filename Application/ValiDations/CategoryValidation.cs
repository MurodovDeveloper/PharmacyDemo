using Domain.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ValiDations
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(c => c.CategoryName).NotEmpty().NotEmpty().MaximumLength(30).MinimumLength(3).WithMessage("Name is not valid");

        }
    }
}
