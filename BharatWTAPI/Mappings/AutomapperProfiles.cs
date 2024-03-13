using AutoMapper;
using BharatWTAPI.Models.Domain;

namespace BharatWTAPI.Mappings
{
    public class AutomapperProfiles :Profile
    {
        public AutomapperProfiles()
        {
                CreateMap<Region,RegionDto>().ReverseMap(); 
        }
    }
}
