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

        public async Task<List<Character>> GetAllCharacter()
        {
            return Characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return Characters.FirstOrDefault(c => c.Id == id);
        }

        public async Task<List<Character>> AddCharacter(Character character)
        {
            Characters.Add(character);

            return Characters;
        }
    }
}