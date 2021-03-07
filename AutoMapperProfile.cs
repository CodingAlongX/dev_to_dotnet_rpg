using System.Linq;
using AutoMapper;
using dev_to_dotnet_rpg.Dtos.Character;
using dev_to_dotnet_rpg.Dtos.Fight;
using dev_to_dotnet_rpg.Dtos.Skill;
using dev_to_dotnet_rpg.Dtos.Weapon;
using dev_to_dotnet_rpg.Models;

namespace dev_to_dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>()
                .ForMember(dto => dto.Skills, c => c.MapFrom(c => c.CharacterSkills.Select(cs => cs.Skill)));
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighScoreDto>();
        }
    }
}