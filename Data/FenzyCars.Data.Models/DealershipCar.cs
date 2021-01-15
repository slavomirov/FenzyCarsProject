namespace FenzyCars.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class DealershipCar
    {
        [Key]
        public int Id { get; set; }

        public Car Car { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }

        public Dealership Dealership { get; set; }

        [ForeignKey("Dealership")]
        public string DealershipId { get; set; }
    }
}
