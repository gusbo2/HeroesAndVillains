using System.Collections.Generic;
using System.Linq;
using Domain.Models;

namespace Repository.Builders
{
    public class HeroQueryableBuilder
    {
        private IQueryable<Hero> heroBuilder;

        public HeroQueryableBuilder(IEnumerable<Hero> database)
        {
            heroBuilder = database.AsQueryable();
        }

        public HeroQueryableBuilder Name(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                heroBuilder = heroBuilder.Where(x => x.Name.ToLower() == name.ToLower());
            return this;
        }

        public HeroQueryableBuilder Alliance(string alliance)
        {
            if (!string.IsNullOrWhiteSpace(alliance))
                heroBuilder = heroBuilder.Where(x => x.Alliance.ToLower() == alliance.ToLower());
            return this;
        }

        public IEnumerable<Hero> Build(int page, int items)
        {
            if(page > 0)
                heroBuilder.Skip(items > 0 ? page * items : page * 100);
                
            return heroBuilder.Take(items > 0 ? items : 100).ToArray();
        }
    }
}