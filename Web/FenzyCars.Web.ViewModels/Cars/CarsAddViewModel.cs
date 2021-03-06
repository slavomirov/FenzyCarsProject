﻿namespace FenzyCars.Web.ViewModels.Cars
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using FenzyCars.Data.Models;
    using FenzyCars.Data.Models.Enums;
    using FenzyCars.Services.Mapping;
    using Microsoft.AspNetCore.Http;

    public class CarsAddViewModel
    {
        public CarsAddViewModel()
        {
            this.Images = new HashSet<IFormFile>();
            this.Extras = new HashSet<Extra>();
            this.RealExtras = new HashSet<string>();
        }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        [Range(0, 1000)]
        public int Hp { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Mileage { get; set; }

        [Required]
        public BodyType BodyType { get; set; }

        [Required]
        public FuelType FuelType { get; set; }

        [Required]
        [Range(1, 7)]
        public int Seats { get; set; }

        [Required]
        [Range(2, 6)]
        public int Doors { get; set; }

        [Required]
        public Transmission Transmission { get; set; }

        [Required]
        public int EngineSize { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public IEnumerable<IFormFile> Images { get; set; }

        public ICollection<Extra> Extras { get; set; }

        public ICollection<string> RealExtras { get; set; }

        public string UserId { get; set; }

        public string DealershipId { get; set; }
    }
}
