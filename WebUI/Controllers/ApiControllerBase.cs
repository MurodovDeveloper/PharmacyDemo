using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Pharmacy.Controllers
{
    public abstract class ApiControllerBase<TModel>:ControllerBase
    {
        protected IMapper _ => HttpContext.RequestServices.GetRequiredService<Mapper>();

        protected IValidator<TModel> _validator =>HttpContext.RequestServices.GetRequiredService<IValidator<TModel>>(); 
    }
}
