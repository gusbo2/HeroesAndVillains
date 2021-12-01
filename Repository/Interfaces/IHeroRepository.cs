using System.Collections.Generic;
using Domain.Models;

namespace Repository.Interfaces
{
    public interface IHeroRepository
    {
        IEnumerable<Hero> GetHeroes(string name, string alliance);
    }
}