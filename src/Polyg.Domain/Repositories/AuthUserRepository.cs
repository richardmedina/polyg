using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Polyg.Common.Domain;
using Polyg.Contract.Domain;
using Polyg.Infrastructure.Domain;
using Polyg.Infrastructure.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Domain.Repositories
{
    public class AuthUserRepository : GenericAbstractRepository<AuthUserEntity, AuthUser>, IAuthUserRepository
    {
        private readonly IMapper _mapper;
        public AuthUserRepository(PolygDbContext context, IMapper mapper) : base(context, mapper)
        {
            _mapper = mapper;
        }

        public async Task<AuthUser> GetByIdAsync(long id)
        {
            var authUser = await Context.AuthUsers
                .FirstOrDefaultAsync(authUser => authUser.Id == id);

            return _mapper.Map<AuthUser>(authUser);
        }

        public async Task<AuthUser> GetByUserNameAsync(string userName)
        {
            var authUserEntity = await Context.AuthUsers
                .FirstOrDefaultAsync(authUser => authUser.UserName == userName);

            return _mapper.Map<AuthUser>(authUserEntity);
        }
    }
}
