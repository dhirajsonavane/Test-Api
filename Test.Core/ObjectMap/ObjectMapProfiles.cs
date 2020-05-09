using AutoMapper;

namespace Test.Core.ObjectMap
{
    public class ObjectMapProfiles : Profile
    {
        public ObjectMapProfiles()
        {
            CreateMap<Domain.Monitoring, DTO.Monitoring>().ReverseMap();
        }
    }
}
