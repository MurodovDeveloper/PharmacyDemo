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
    public class PermissionService : Repository<Permission>, IPermissionService
    {
        IApplicatonDbcontext _db;
        public PermissionService(IApplicatonDbcontext db) : base(db)
        {
            _db = db;
        }
    }
}
