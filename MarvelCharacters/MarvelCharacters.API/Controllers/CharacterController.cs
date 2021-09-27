using MarvelCharacters.Domain.Models;
using MarvelCharacters.Services.Models;
using MarvelCharacters.Services.Services.Character;
using Microsoft.AspNetCore.Mvc;

namespace MarvelCharacters.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CharacterController
    {
        private ICharacterService _characterService;

        public CharacterController()
        {
            _characterService = new CharactersService();
        }

        [HttpGet]
        public ResponseModel<Characters> GetAll()
        {
            return _characterService.GetAll();
        }

        [HttpPost]
        public ResponseModel<Characters> Create([FromBody] Characters character)
        {
            return _characterService.Insert(character);
        }

        [HttpPut]
        public ResponseModel<Characters> Update([FromBody] Characters character)
        {
            return _characterService.Update(character);
        }

        [HttpDelete]
        public ResponseModel<Characters> Delete(int id)
        {
            return _characterService.Delete(id);
        }
    }
}
