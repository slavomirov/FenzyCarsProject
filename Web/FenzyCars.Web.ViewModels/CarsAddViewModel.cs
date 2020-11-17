namespace FenzyCars.Web.ViewModels
{
    using FenzyCars.Data.Models;

    public class CarsAddViewModel
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Hp { get; set; }

        public int Mileage { get; set; }

        public string BodyType { get; set; }

        public string FuelType { get; set; }

        public int Seats { get; set; }

        public int Doors { get; set; }

        public Transmission Transmission { get; set; }

        public int EngineSize { get; set; }

        public string Description { get; set; }

        public string PhotoURL { get; set; }
    }
}
