namespace MarvelCharacters.Domain.Models
{
    public class CharactersVehicles
    {
        public int Id { get; set; }
        public int CharactersId { get; set; }
        public virtual Characters Character { get; set; }
        public int VehiclesId { get; set; }
        public virtual Vehicles Vehicle { get; set; }
    }
}
