using AutoMapper;
using BasicFirmSystem.Application.CQRS.CurrentCards.Commands.CreateCurrentCard;
using BasicFirmSystem.Application.CQRS.CurrentCards.Dtos;
using BasicFirmSystem.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Application.CQRS.CurrentCards.Profiles
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<CurrentCard, CreateCurrentCard_Request>().ReverseMap();
            CreateMap<CurrentCard, CreateCurrentCardDto>().ReverseMap();
        }
    }
}
