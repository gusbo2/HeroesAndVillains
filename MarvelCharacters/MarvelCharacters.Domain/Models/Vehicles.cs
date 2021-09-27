using System;
using System.Collections.Generic;

namespace MarvelCharacters.Domain.Models
{
    public class Vehicles
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public IEnumerable<CharactersVehicles> CharactersVehicles { get; set; }
    }
}
