using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dev_to_dotnet_rpg.Models;

namespace dev_to_dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static readonly List<Character> Characters = new()
        {
            new Character(),
            new Character {Id = 1, Name = "Sam"}
        };

        public async Task<ServiceResponse<List<Character>>> GetAllCharacter()
        {
            var serviceResponse = new ServiceResponse<List<Character>> {Data = Characters};
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character> {Data = Characters.FirstOrDefault(c => c.Id == id)};


            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character character)
        {
            Characters.Add(character);

            var serviceResponse = new ServiceResponse<List<Character>> {Data = Characters};

            return serviceResponse;
        }
    }
}