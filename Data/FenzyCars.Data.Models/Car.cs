﻿namespace FenzyCars.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using FenzyCars.Data.Common.Models;
    using FenzyCars.Data.Models.Enums;

    public class Car : BaseDeletableModel<int>
    {
        public Car()
        {
            this.UserCars = new HashSet<UserCar>();
            this.Images = new HashSet<Image>();
            this.DealershipCars = new HashSet<DealershipCar>();
            this.CarExtras = new HashSet<CarExtra>();
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
        public int Year { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public ICollection<Image> Images { get; set; }

        public ICollection<UserCar> UserCars { get; set; }

        public ICollection<DealershipCar> DealershipCars { get; set; }

        public ICollection<CarExtra> CarExtras { get; set; }
    }
}
