using AutoMapper;
using Polyg.Contract.Domain;
using Polyg.Contract.Services.AuthUser;
using Polyg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polyg.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<AuthUser, AuthUserDto>();
            CreateMap<AuthUserDto, AuthUserModel>();
        }
    }
}
