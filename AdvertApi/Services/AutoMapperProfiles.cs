using AdvertApi.Models;
using AutoMapper;

namespace AdvertApi.Services
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AdvertModels, AdvertDbModel>();
        }
    }
}
