using AutoMapper;
using Polyg.Contract.Domain;
using Polyg.Contract.Services.AuthUser;
using Polyg.Contract.Services.Language;
using Polyg.Infrastructure.Domain.Entities;
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
            CreateMap<AuthUserEntity, AuthUser>();
            CreateMap<AuthUser, AuthUserDto>();
            CreateMap<AuthUserDto, AuthUserModel>();

            CreateMap<LanguageEntity, Language>();
            CreateMap<Language, LanguageDto>();
        }
    }
}
