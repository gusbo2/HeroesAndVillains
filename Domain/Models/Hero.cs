namespace Domain.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Durability { get; set; }
        public int Power { get; set; }
        public int Combat { get; set; }
        public string Alliance { get; set; }
    }
}