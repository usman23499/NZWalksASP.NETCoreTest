using AutoMapper;

namespace NZWalks.API.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domian.Region, Models.DTO.Region>()
                .ReverseMap();
            //createMap<Models.Domian.Region,Models.Dto.Region>().ForMember(dest => dest.Id,  option => options.MapForm(src => src.RegionId));
        }
    }
}
