using System.Collections.Generic;
using Domain.Models;

namespace Service.Interfaces
{
    public interface IHeroService
    {
        IEnumerable<Hero> GetHeroes(string name, string alliance);
    }
}