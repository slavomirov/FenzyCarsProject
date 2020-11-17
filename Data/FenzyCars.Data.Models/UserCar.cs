namespace FenzyCars.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class UserCar
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public Car Car { get; set; }

        public int CarId { get; set; }
    }
}
