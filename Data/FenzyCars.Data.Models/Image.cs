namespace FenzyCars.Data.Models
{
    using System;

    using FenzyCars.Data.Common.Models;

    public class Image : BaseModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int CarId { get; set; }

        public virtual Car Car { get; set; }

        public string Extension { get; set; }

        public string RemoteImageUrl { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }
    }
}
