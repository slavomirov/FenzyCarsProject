namespace FenzyCars.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using FenzyCars.Data.Common.Models;

    public class UserCar : BaseModel<int>
    {
        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public Car Car { get; set; }

        public int CarId { get; set; }
    }
}
