using AutoMapper;
using dev_to_dotnet_rpg.Dtos.Character;
using dev_to_dotnet_rpg.Models;

namespace dev_to_dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}