using Application.Abstraction;
using Application.Interfaces.ServiceInterfaces;
using Domain.Entities.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class RoleService : Repository<Role>, IRoleService
    {
        IApplicatonDbcontext _db;
        public RoleService(IApplicatonDbcontext db) : base(db)
        {
            _db = db;
        }
    }
}
