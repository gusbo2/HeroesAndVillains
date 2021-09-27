using MarvelCharacters.Domain.Models;
using System.Collections.Generic;

namespace MarvelCharacters.Repository.Repositories.Character
{
    public interface ICharacterRepository
    {
        IEnumerable<Characters> GetAll();
        IEnumerable<Characters> Insert(Characters character);
        IEnumerable<Characters> Update(Characters character);
        IEnumerable<Characters> Remove(int Id);
    }
}
