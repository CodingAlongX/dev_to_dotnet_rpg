using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dev_to_dotnet_rpg.Dtos.Character;
using dev_to_dotnet_rpg.Models;

namespace dev_to_dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private readonly IMapper _mapper;

        private static readonly List<Character> Characters = new()
        {
            new Character(),
            new Character {Id = 1, Name = "Sam"}
        };

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacter()
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>
                {Data = Characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList()};
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<GetCharacterDto>
                {Data = _mapper.Map<GetCharacterDto>(Characters.FirstOrDefault(c => c.Id == id))};

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            Character character = _mapper.Map<Character>(newCharacter);
            character.Id = Characters.Max(c => c.Id) + 1;
            Characters.Add(character);

            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>
                {Data = Characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList()};

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            ServiceResponse<GetCharacterDto> serviceResponse = new ServiceResponse<GetCharacterDto>();

            try
            {
                Character character = Characters.FirstOrDefault(c => c.Id == updatedCharacter.Id);

                character.Name = updatedCharacter.Name;
                character.Class = updatedCharacter.Class;
                character.Defense = updatedCharacter.Defense;
                character.HitPoints = updatedCharacter.HitPoints;
                character.Intelligence = updatedCharacter.Intelligence;
                character.Strength = updatedCharacter.Strength;

                serviceResponse.Data = _mapper.Map<GetCharacterDto>(character);
            }
            catch (Exception e)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = e.Message;
            }


            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id)
        {
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();

            try
            {
                Character character = Characters.First(c => c.Id == id);

                Characters.Remove(character);

                serviceResponse.Data = (Characters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();
            }
            catch (Exception e)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = e.Message;
            }


            return serviceResponse;
        }
    }
}