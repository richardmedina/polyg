using Polyg.Abstract.Domain;
using Polyg.Abstract.Services;
using Polyg.Contract.Domain;
using Polyg.Contract.Services.AuthUser;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Services
{
    public class AuthUserService : IAuthUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthUserService(IUnitOfWork unitOfwork)
        {
            _unitOfWork = unitOfwork;
        }

        public AuthUserDto AuthenticateUser(string userName, string password)
        {
            var authUser = _unitOfWork.AuthUserRepository
                .GetByUserName(userName);

            return authUser.UserName == userName && authUser.Password == password
                ? new AuthUserDto
                {
                    Id = authUser.Id,
                    UserName = authUser.UserName,
                    Password = authUser.Password
                }
                : null;
        }
    }
}
