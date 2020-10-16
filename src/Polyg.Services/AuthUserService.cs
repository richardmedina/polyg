using AutoMapper;
using Polyg.Common.Domain;
using Polyg.Common.Infrastructure.Jwt;
using Polyg.Common.Services;
using Polyg.Contract.Domain;
using Polyg.Contract.Services.AuthUser;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<AuthToken> AuthenticateUserAsync(string userName, string password)
        {
            var authUser = await _unitOfWork.AuthUserRepository
                .GetByUserNameAsync(userName);

            if (authUser == null)
            {
                return null;
            }

            if (authUser.UserName == userName && authUser.Password == password)
            {
                return _jwtHandler.CreateToken(userName);
            }

            return null;
        }
    }
}
