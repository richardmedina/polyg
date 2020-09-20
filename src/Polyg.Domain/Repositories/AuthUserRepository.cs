using Polyg.Abstract.Domain;
using Polyg.Contract.Domain;
using Polyg.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polyg.Domain.Repositories
{
    public class AuthUserRepository : GenericAbstractRepository<AuthUser>, IAuthUserRepository
    {
        internal AuthUserRepository(PolygDbContext context) : base(context)
        {

        }

        public AuthUser GetById(long id)
        {
            return Context.AuthUsers
                .FirstOrDefault(authUser => authUser.Id == id);
        }

        public AuthUser GetByUserName(string userName)
        {
            return Context.AuthUsers
                .FirstOrDefault(authUser => authUser.UserName == userName);
        }
    }
}
