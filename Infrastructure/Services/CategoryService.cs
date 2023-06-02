using Application.Abstraction;
using Application.Interfaces.ServiceInterfaces;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CategoryService : Repository<Category>, ICategoryService
    {
        private readonly IApplicatonDbcontext _db;

        public CategoryService(IApplicatonDbcontext db) : base(db)
        {
            _db = db;
        }
    }
}
