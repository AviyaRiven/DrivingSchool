using AutoMapper;
using Bl.dataObjects;
using Dal.dataObjects;

namespace Bl.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressBl>().ReverseMap();
        }
    
    }
}
