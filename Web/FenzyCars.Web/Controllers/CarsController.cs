namespace FenzyCars.Web.Controllers
{
    using FenzyCars.Data;
    using FenzyCars.Data.Models;
    using FenzyCars.Web.ViewModels;
    using Microsoft.AspNetCore.Mvc;

    public class CarsController : BaseController
    {
        private readonly ApplicationDbContext dbContext;

        public CarsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Add(CarsAddViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/Shared/Error");
            }

            var car = new Car
            {
                BodyType = input.BodyType,
                Color = input.Color,
                Description = input.Description,
                Doors = input.Doors,
                EngineSize = input.EngineSize,
                FuelType = input.FuelType,
                Hp = input.Hp,
                Make = input.Make,
                Mileage = input.Mileage,
                Model = input.Model,
                PhotoURL = input.PhotoURL,
                Seats = input.Seats,
                Transmission = input.Transmission,
            };

            this.dbContext.SaveChanges();

            return this.Redirect("/");
        }
    }
}
