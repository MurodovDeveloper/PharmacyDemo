using Domain.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ValiDations
{
    public class DrugValidation :AbstractValidator<Drug>
    {
        public DrugValidation()
        {
            RuleFor(x => x.DrugPrice).NotEmpty().GreaterThan(0).WithMessage("Price is not valid");
            RuleFor(x => x.Description).NotNull().NotEmpty().MinimumLength(30).MaximumLength(200).WithMessage("Description is not valid");
            RuleFor(x => x.ImageUrl).NotNull().NotEmpty().MinimumLength(5).WithMessage("ImageUrl is not valid");
            RuleFor(x => x.IsActive).NotNull().NotEmpty().WithMessage("IsActive is not valid");
            RuleFor(x => x.Created);
            RuleFor(x => x.DrugName).NotNull().NotEmpty().MinimumLength(5).MinimumLength(50).WithMessage("Name is not valid");
            RuleFor(x => x.CategoryId).NotNull().NotEmpty().WithMessage("CategoryId is not valid");
           

        }
    }
}
