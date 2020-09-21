using AutoMapper;
using Polyg.Common.Domain;
using Polyg.Common.Infrastructure.Jwt;
using Polyg.Common.Services;
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
        private readonly IMapper _mapper;
        private readonly IJwtHandler _jwtHandler;

        public AuthUserService(IUnitOfWork unitOfwork, IMapper mapper, IJwtHandler jwtHandler)
        {
            _unitOfWork = unitOfwork;
            _mapper = mapper;
            _jwtHandler = jwtHandler;
        }

        public AuthToken AuthenticateUser(string userName, string password)
        {
            var authUser = _unitOfWork.AuthUserRepository
                .GetByUserName(userName);

            if (authUser.UserName == userName && authUser.Password == password)
            {
                return _jwtHandler.CreateToken(userName);
            }

            return null;
        }
    }
}
