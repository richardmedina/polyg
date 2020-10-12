using AutoMapper;
using Polyg.Common.Domain;
using Polyg.Contract.Domain;
using Polyg.Infrastructure.Domain;
using Polyg.Infrastructure.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polyg.Domain.Repositories
{
    public class AuthUserRepository : GenericAbstractRepository<AuthUserEntity, AuthUser>, IAuthUserRepository
    {
        private readonly IMapper _mapper;
        public AuthUserRepository(PolygDbContext context, IMapper mapper) : base(context, mapper)
        {
            _mapper = mapper;
        }

        public AuthUser GetById(long id)
        {
            var authUser = Context.AuthUsers
                .FirstOrDefault(authUser => authUser.Id == id);

            return _mapper.Map<AuthUser>(authUser);
        }

        public AuthUser GetByUserName(string userName)
        {
            var authUserEntity = Context.AuthUsers
                .FirstOrDefault(authUser => authUser.UserName == userName);

            return _mapper.Map<AuthUser>(authUserEntity);
        }
    }
}
