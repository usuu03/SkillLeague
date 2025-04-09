using System;
using AutoMapper;
using SkillLeague.Domain;

namespace SkillLeague.Application.Common;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Challenge, Challenge>();
    }

}
