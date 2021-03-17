using AutoMapper;
using Polyg.Common.Domain;
using Polyg.Common.Infrastructure.Jwt;
using Polyg.Common.Services;
using Polyg.Contract.Domain;
using Polyg.Contract.Services;
using Polyg.Contract.Services.AuthUser;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Services
{
    public class AuthUserService : AbstractService, IAuthUserService
    {
        private readonly IMapper _mapper;
        private readonly IJwtHandler _jwtHandler;

        public AuthUserService(IUnitOfWork unitOfWork, IMapper mapper, IJwtHandler jwtHandler) : base(unitOfWork)
        {
            _mapper = mapper;
            _jwtHandler = jwtHandler;
        }

        public async Task<AuthToken> AuthenticateUserAsync(string userName, string password)
        {
            var authUser = await UnitOfWork.AuthUserRepository
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

        public async Task<ServiceResult<AuthUserDto>> GetByUserName(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return ResultFromValidationError<AuthUserDto>("Invalid Parameters");
            }

            return ResultFromSuccess(
                _mapper.Map<AuthUserDto>(
                    await UnitOfWork
                        .AuthUserRepository
                        .GetByUserNameAsync(userName)
                )
            );
        }
    }
}
