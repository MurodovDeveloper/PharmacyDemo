using Application.Models;
using Domain.Entities.Models;
using Domain.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ServiceInterfaces
{
    public interface ITokenService
    {
        Task<string> CreateAccesToken(User user);
        Task<string> CreateRefreshAccesToken(User user);
        Task<bool> IsActive(string token);
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
        public IQueryable<RefreshToken> Get(Expression<Func<RefreshToken, bool>> predicate);
        public bool Delete(RefreshToken token);
        public Task<Token> CreateTokensFromRefresh(ClaimsPrincipal principal, RefreshToken savedRefreshToken);
    }
}
