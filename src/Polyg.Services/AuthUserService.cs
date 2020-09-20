using AutoMapper;
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
        private readonly IMapper _mapper;

        public AuthUserService(IUnitOfWork unitOfwork, IMapper mapper)
        {
            _unitOfWork = unitOfwork;
            _mapper = mapper;
        }

        public AuthUserDto AuthenticateUser(string userName, string password)
        {
            var authUser = _unitOfWork.AuthUserRepository
                .GetByUserName(userName);

            return authUser.UserName == userName && authUser.Password == password
                ? _mapper.Map<AuthUserDto>(authUser)
                : null;
        }
    }
}
