using AutoMapper;
using Contracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapping
{
    public static class ModelMapper
    {
        public static MapperConfiguration Configure(MapperConfigurationExpression? cfg = null)
        {
            if (cfg == null)
                cfg = new MapperConfigurationExpression();
            cfg.CreateMap<User, UserDto>();
            cfg.CreateMap<UserDto, User>();
            cfg.CreateMap<Adventure, AdventureDto>();
            cfg.CreateMap<AdventureDto, Adventure>();
            cfg.CreateMap<ChoiceForCreationDto, Choice>();
            cfg.CreateMap<QuestionForCreationDto, Question>();
            cfg.CreateMap<AdventureForCreationDto, Adventure>();
            cfg.CreateMap<UserChoiceForCreationDto, UserChoice>();
            cfg.CreateMap<UserAdventureForCreationDto, UserAdventure>();
            cfg.CreateMap<UserForCreationDto, User>();
            cfg.CreateMap<Choice, ChoiceDto>();
            cfg.CreateMap<ChoiceDto, Choice>();
            cfg.CreateMap<Question, QuestionDto>();
            cfg.CreateMap<QuestionDto, Question>();
            cfg.CreateMap<UserAdventure, UserAdventureDto>();
            cfg.CreateMap<UserAdventureDto, UserAdventure>();
            cfg.CreateMap<UserChoice, UserChoiceDto>();
            cfg.CreateMap<UserChoiceDto, UserChoice>();

            var config = new MapperConfiguration(cfg);
            return config;
        }
    }
}
