﻿namespace FenzyCars.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using FenzyCars.Data.Common.Models;

    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.UserCars = new HashSet<UserCar>();
            this.RecievedMessages = new HashSet<RecievedMessage>();
            this.SendedMessages = new HashSet<SendedMessage>();
            this.UserDealerships = new HashSet<UserDealership>();
            this.Votes = new HashSet<Vote>();
            this.CountOfPosts = 0;
        }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        public string CityLiving { get; set; }

        public int CountOfPosts { get; set; }

        public ICollection<UserCar> UserCars { get; set; }

        public ICollection<RecievedMessage> RecievedMessages { get; set; }

        public ICollection<SendedMessage> SendedMessages { get; set; }

        public ICollection<UserDealership> UserDealerships { get; set; }

        public ICollection<Vote> Votes { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
