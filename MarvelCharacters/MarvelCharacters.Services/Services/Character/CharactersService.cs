using MarvelCharacters.Domain.Models;
using MarvelCharacters.Repository.Repositories.Character;
using MarvelCharacters.Services.Models;
using System.Linq;

namespace MarvelCharacters.Services.Services.Character
{
    public class CharactersService : ICharacterService
    {
        private ICharacterRepository _characterRepository;

        public CharactersService()
        {
            _characterRepository = new CharacterRepository();
        }

        public ResponseModel<Characters> GetAll()
        {
            var responseModel = new ResponseModel<Characters>();
            var characters = _characterRepository.GetAll();

            responseModel.Success(characters);

            return responseModel;
        }

        public ResponseModel<Characters> Insert(Characters character)
        {
            var responseModel = new ResponseModel<Characters>();

            character.Id = GetLastIdFromCharacters();
            responseModel.Success(_characterRepository.Insert(character));

            return responseModel;
        }

        private int GetLastIdFromCharacters()
        {
            var characters = _characterRepository.GetAll();
            return characters.Select(x => x.Id).LastOrDefault() + 1;
        }

        public ResponseModel<Characters> Update(Characters character)
        {
            var responseModel = new ResponseModel<Characters>();
            responseModel.Success(_characterRepository.Update(character));
            return responseModel;
        }

        public ResponseModel<Characters> Delete(int id)
        {
            var responseModel = new ResponseModel<Characters>();
            responseModel.Fail();
            //return _characterRepository.Remove(id);
            return responseModel;
        }
    }
}
