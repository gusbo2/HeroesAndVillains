using Api.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController : Controller
    {
        private readonly IHeroService _heroService;

        public HeroController(IHeroService heroService) => _heroService = heroService;

        [HttpGet]
        public IActionResult GetHeroes(HeroFilterModel model)
        {
            return Json(new { heroes = _heroService.GetHeroes(model.name, model.alliance) });
        }
    }
}