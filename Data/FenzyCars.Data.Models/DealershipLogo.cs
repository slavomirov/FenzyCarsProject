namespace FenzyCars.Data.Models
{
    using System;

    using FenzyCars.Data.Common.Models;

    public class DealershipLogo : BaseModel<string>
    {
        public DealershipLogo()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string DealershipId { get; set; }

        public Dealership Dealership { get; set; }

        public string Extension { get; set; }

        public string RemoteImageUrl { get; set; }
    }
}
