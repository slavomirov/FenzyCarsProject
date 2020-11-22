namespace FenzyCars.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using FenzyCars.Data.Common.Models;
    using FenzyCars.Data.Models.Enums;

    public class Car : IDeletableEntity
    {
        public Car()
        {
            this.UserCars = new HashSet<UserCar>();
        }

        [Required]
        [Key]
        public int Id { get; set; }

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

        // TODO: PHOTO
        [Required]
        public string PhotoURL { get; set; }

        public ICollection<UserCar> UserCars { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
