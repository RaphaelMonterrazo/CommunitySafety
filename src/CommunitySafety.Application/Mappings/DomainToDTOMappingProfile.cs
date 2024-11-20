using AutoMapper;
using CommunitySafety.Application.DTOs;
using CommunitySafety.Domain.Entities;

namespace CommunitySafety.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Incident, IncidentDTO>().ReverseMap();
            CreateMap<Location, LocationDTO>().ReverseMap();
        }
    }
}
