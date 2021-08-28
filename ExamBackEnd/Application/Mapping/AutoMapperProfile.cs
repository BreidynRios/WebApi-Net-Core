using Application.Dtos;
using AutoMapper;
using Domain;

namespace Application.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Ticket, TicketDto>()
                .ReverseMap()
                .ForPath(s => s.User, opt => opt.Ignore());

            CreateMap<User, UserDto>()
                .ForMember(d => d.FullName, opt => opt.MapFrom(src => $"{src.Name} {src.LastName}"))
                .ReverseMap();
        }
    }
}
