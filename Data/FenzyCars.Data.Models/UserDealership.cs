namespace FenzyCars.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class UserDealership
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string DealershipId { get; set; }

        public Dealership Dealership { get; set; }
    }
}
