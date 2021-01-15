namespace FenzyCars.Web.ViewModels.CarDealerships
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using FenzyCars.Data.Models;
    using Microsoft.AspNetCore.Http;

    public class DealershipsAddViewModel
    {
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

        [Required]
        public IFormFile Logo { get; set; }

        public string OwnerId { get; set; }
    }
}
