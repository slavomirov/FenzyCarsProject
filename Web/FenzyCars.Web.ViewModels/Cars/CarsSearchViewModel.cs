﻿namespace FenzyCars.Web.ViewModels.Cars
{
    using FenzyCars.Data.Models.Enums;

    public class CarsSearchViewModel
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int? MinYear { get; set; }

        public int? MaxYear { get; set; }

        public int? MinHp { get; set; }

        public int? MaxHp { get; set; }

        public string Color { get; set; }

        public string BodyType { get; set; }

        public string FuelType { get; set; }

        public string Transmission { get; set; }

        public int? Seats { get; set; }

        public int? Doors { get; set; }

        public int? MinEngineSize { get; set; }

        public int? MaxEngineSize { get; set; }

        public int? MinPrice { get; set; }

        public int? MaxPrice { get; set; }

        public int? MinMileage { get; set; }

        public int? MaxMileage { get; set; }

        public string City { get; set; }

        public string SortBy { get; set; }

        public string Way { get; set; }
    }
}
