using System.Collections.Generic;
using System.Linq;
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

        public List<Character> GetAllCharacter()
        {
            return Characters;
        }

        public Character GetCharacterById(int id)
        {
            return Characters.FirstOrDefault(c => c.Id == id);
        }

        public List<Character> AddCharacter(Character character)
        {
            Characters.Add(character);

            return Characters;
        }
    }
}