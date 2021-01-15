namespace FenzyCars.Data.Models
{
    using FenzyCars.Data.Common.Models;

    public class Vote : BaseModel<int>
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string DealershipId { get; set; }

        public virtual Dealership Dealership { get; set; }

        public byte Value { get; set; }
    }
}
