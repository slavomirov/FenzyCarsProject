namespace FenzyCars.Web.ViewModels
{
    using System.Collections.Generic;

    using FenzyCars.Data.Models;
    using FenzyCars.Data.Models.Enums;
    using FenzyCars.Services.Mapping;

    public class CarEditViewModel : IMapFrom<Car>
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Hp { get; set; }

        public int Mileage { get; set; }

        public BodyType BodyType { get; set; }

        public FuelType FuelType { get; set; }

        public Transmission Transmission { get; set; }

        public int Seats { get; set; }

        public int Doors { get; set; }

        public int EngineSize { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public int Price { get; set; }
    }
}
