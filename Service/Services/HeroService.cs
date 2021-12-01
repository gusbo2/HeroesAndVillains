using System.Collections.Generic;
using Domain.Models;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Services
{
    public class HeroService : IHeroService
    {
        private readonly IHeroRepository _heroRepository;

        public HeroService(IHeroRepository heroRepository)
        {
            _heroRepository = heroRepository;
        }

        public IEnumerable<Hero> GetHeroes(string name, string alliance) => _heroRepository.GetHeroes(name, alliance);
    }
}