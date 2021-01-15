namespace FenzyCars.Services.Data.Tests
{
    using System.Threading.Tasks;

    using FenzyCars.Data;
    using FenzyCars.Data.Models;
    using FenzyCars.Web.Controllers;
    using FenzyCars.Web.ViewModels.Cars;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Xunit;

    public class CarsControllerTest
    {
        [Fact]
        public void CarAddWorkingProperly()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("test");

            var dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var service = new CarsService(dbContext);

            dbContext.Cars.Add(new Car
            {
                Id = 1,
                BodyType = FenzyCars.Data.Models.Enums.BodyType.Coupe,
                Color = "TEST",
                Description = "TEST",
                Doors = 4,
                Price = 1500,
                EngineSize = 2500,
                FuelType = FenzyCars.Data.Models.Enums.FuelType.Diesel,
                Hp = 150,
                Make = "TEST",
                Mileage = 150,
                Model = "TEST",
                Seats = 4,
                Transmission = FenzyCars.Data.Models.Enums.Transmission.Automatic,
                Year = 2000,
            });

            var car = service.ById<Car>(1);
          

            Assert.Equal(1, car.Id);
        }
    }
}
