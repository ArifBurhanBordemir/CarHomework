using System.ComponentModel.DataAnnotations.Schema;

namespace CarHomework.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string CarPlate { get; set; }
        public int Km { get; set; }
        public int Model { get; set; }
        public string Color { get; set; }
        public string GearType { get; set; }
        public string Brand { get; set; }

    }
}
