using Application.Abstraction;
using Application.Interfaces.ServiceInterfaces;
using Domain.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class RefreshTokenService : Repository<RefreshToken>, IRefreshTokenService
    {
        IApplicatonDbcontext _db;
        public RefreshTokenService(IApplicatonDbcontext db) : base(db)
        {
            _db = db;
        }
    }
}
