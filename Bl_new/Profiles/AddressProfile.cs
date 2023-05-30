using AutoMapper;
using Bl.dataObjects;
using Dal.dataObjects;

namespace Bl.Profiles
{
    internal class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressBl>().ReverseMap();
        }
    
    }
}
