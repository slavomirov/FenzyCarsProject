namespace FenzyCars.Services.Data
{
    using FenzyCars.Data;
    using FenzyCars.Data.Models;
    using FenzyCars.Web.ViewModels;
    using Microsoft.AspNetCore.Identity;
    using System.Security.Claims;

    public class CarsService : ICarsService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager;

        public CarsService(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        public async void Add(CarsAddViewModel input)
        {
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

            var userCars = new UserCar
            {
                CarId = car.Id,
                UserId = input.UserId,
            };

            car.UserCars.Add(userCars);

            this.dbContext.Cars.Add(car);
            this.dbContext.SaveChanges();
        }
    }
}
