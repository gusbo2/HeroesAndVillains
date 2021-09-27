using System.Collections.Generic;
using System.Linq;
using MarvelCharacters.Domain.Models;

namespace MarvelCharacters.Repository.Repositories.Character
{
    public class CharacterRepository : ICharacterRepository
    {
        private List<Characters> characters = new List<Characters>
        {
            new Characters
            {
                Id = 1,
                Name = "Thor",
                Hero = true
            },
            new Characters
            {
                Id = 2,
                Name = "Thanos",
                Hero = false
            }
        };

        public CharacterRepository() { }

        public IEnumerable<Characters> GetAll() => characters;

        public IEnumerable<Characters> Insert(Characters character)
        {
            characters.Add(character);
            return characters;
        }

        public IEnumerable<Characters> Update(Characters character)
        {
            var characterAux = characters.Where(x => x.Id == character.Id).FirstOrDefault();

            if (characterAux != null)
                characterAux = character;

            return characters;
        }

        public IEnumerable<Characters> Remove(int Id)
        {
            characters = characters.Where(x => x.Id != Id).ToList();
            return characters;
        }
    }
}
