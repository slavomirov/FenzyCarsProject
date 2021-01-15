namespace FenzyCars.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using FenzyCars.Data.Common.Models;
    using Microsoft.AspNetCore.Identity;

    public class Dealership : IAuditInfo, IDeletableEntity
    {
        public Dealership()
        {
            this.Id = Guid.NewGuid().ToString();
            this.DealershipCars = new HashSet<DealershipCar>();
            this.Added = false;
            this.UserDealerships = new HashSet<UserDealership>();
            this.Votes = new HashSet<Vote>();
        }

        [Required]
        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        public DealershipLogo Logo { get; set; }

        public ICollection<UserDealership> UserDealerships { get; set; }

        public ICollection<DealershipCar> DealershipCars { get; set; }

        public ICollection<Vote> Votes { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool Added { get; set; }
    }
}
