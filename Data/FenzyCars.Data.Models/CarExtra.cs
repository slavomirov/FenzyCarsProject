namespace FenzyCars.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CarExtra
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public string CarId { get; set; }

        public Car Car { get; set; }

        public int ExtraId { get; set; }

        public Extra Extra { get; set; }
    }
}
