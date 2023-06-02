using Domain.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ValiDations
{
    public class CommentaryValidation : AbstractValidator<Commentary>
    {
        public CommentaryValidation()
        {
            RuleFor(x => x.UserId).NotEmpty().NotNull().WithMessage("UserId is not valid");
            RuleFor(x => x.DrugId).NotEmpty().NotNull().WithMessage("BookId is not valid");
            RuleFor(x => x.Text).NotEmpty().NotNull().MinimumLength(1).MaximumLength(100).WithMessage("Description is not valid");
        }
    }
}
