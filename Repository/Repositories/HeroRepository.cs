using System.Collections.Generic;
using System.IO;
using Domain.Models;
using Newtonsoft.Json;
using Repository.Builders;
using Repository.Interfaces;

namespace Repository.Repositories
{
    public class HeroRepository : IHeroRepository
    {
        private readonly List<Hero> database;

        public HeroRepository()
        {
            var streamReader = new StreamReader("../Database/Heroes.json");
            var json = streamReader.ReadToEnd();
            database = JsonConvert.DeserializeObject<List<Hero>>(json);
        }

        public IEnumerable<Hero> GetHeroes(string name, string alliance)
        {
            return new HeroQueryableBuilder(database).Name(name).Alliance(alliance).Build(0, 0);
        }
    }
}