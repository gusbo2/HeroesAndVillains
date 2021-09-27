using MarvelCharacters.Domain.Models;
using MarvelCharacters.Services.Models;

namespace MarvelCharacters.Services.Services.Character
{
    public interface ICharacterService
    {
        ResponseModel<Characters> GetAll();
        ResponseModel<Characters> Insert(Characters character);
        ResponseModel<Characters> Update(Characters character);
        ResponseModel<Characters> Delete(int id);
    }
}
