using System.Collections.Generic;

namespace MarvelCharacters.Domain.Models
{
    public class Characters
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Hero { get; set; }
        public IEnumerable<CharactersVehicles> CharactersVehicles { get; set; }
    }
}
