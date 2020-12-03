namespace FenzyCars.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using FenzyCars.Data;
    using FenzyCars.Data.Models;
    using FenzyCars.Services.Mapping;
    using FenzyCars.Web.ViewModels;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class CarsService : ICarsService
    {
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif" };
        private readonly ApplicationDbContext dbContext;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager;

        public CarsService(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        public async Task AddAsync(CarsAddViewModel input, string imagePath)
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
                Seats = input.Seats,
                Transmission = input.Transmission,
                Price = input.Price,
                Year = input.Year,
            };

            var userCars = new UserCar
            {
                CarId = car.Id,
                UserId = input.UserId,
            };

            Directory.CreateDirectory($"{imagePath}/cars/");

            foreach (var image in input.Images)
            {
                var extension = Path.GetExtension(image.FileName).TrimStart('.');

                if (!this.allowedExtensions.Any(x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid image extension {extension}");
                }

                var dbImage = new Image
                {
                    AddedByUserId = input.UserId,
                    Extension = extension,
                    CarId = car.Id,
                };

                car.Images.Add(dbImage);

                var physicalPath = $"{imagePath}/cars/{dbImage.Id}.{extension}";

                // "/images/cars/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension
                dbImage.RemoteImageUrl = "/images/cars/" + dbImage.Id + "." + dbImage.Extension;
                using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
            }

            var user = this.dbContext.Users.FirstOrDefault(x => x.Id == input.UserId);
            user.CountOfPosts++;

            car.UserCars.Add(userCars);

            await this.dbContext.Cars.AddAsync(car);
            await this.dbContext.SaveChangesAsync();
        }

        public CarsByIdViewModel ById(int id)
        {
            var car = this.dbContext.Cars
                .Where(x => x.Id == id)
                .To<CarsByIdViewModel>()
                .FirstOrDefault();

            return car;
        }

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 3)
        {
            var cars = this.dbContext.Cars.AsNoTracking()
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .To<T>()
                .ToList();

            return cars;
        }

        public int GetCount()
        {
            return this.dbContext.Cars.Count();
        }

        public ICollection<CarsByIdViewModel> Search(CarsSearchViewModel input)
        {
            var cars = this.dbContext.Cars.AsNoTracking()
                .OrderByDescending(x => x.Id)
                .To<CarsByIdViewModel>()
                .ToList();

            cars = Search(input, cars);

            return cars;
        }

        private static List<CarsByIdViewModel> Search(CarsSearchViewModel input, List<CarsByIdViewModel> cars)
        {
            if (input.BodyType != null)
            {
                cars = cars.Where(x => x.BodyType == input.BodyType).ToList();
            }

            if (input.City != null)
            {
                cars = cars.Where(x => x.User.CityLiving.ToLower().Contains(input.City.ToLower())).ToList();
            }

            if (input.Color != null)
            {
                cars = cars.Where(x => x.Color.ToLower().Contains(input.Color.ToLower())).ToList();
            }

            if (input.Doors != null)
            {
                cars = cars.Where(x => x.Doors == input.Doors).ToList();
            }

            if (input.FuelType != null)
            {
                cars = cars.Where(x => x.FuelType == input.FuelType).ToList();
            }

            if (input.Seats != null)
            {
                cars = cars.Where(x => x.Seats == input.Seats).ToList();
            }

            if (input.Transmission != null)
            {
                cars = cars.Where(x => x.Transmission == input.Transmission).ToList();
            }

            if (input.Make != null)
            {
                cars = cars.Where(x => x.Make.ToLower().Contains(input.Make.ToLower())).ToList();
            }

            if (input.Model != null)
            {
                cars = cars.Where(x => x.Model.ToLower().Contains(input.Model.ToLower())).ToList();
            }

            if (input.MinEngineSize != null)
            {
                cars = cars.Where(x => x.EngineSize >= input.MinEngineSize).ToList();
            }

            if (input.MaxEngineSize != null)
            {
                cars = cars.Where(x => x.EngineSize <= input.MaxEngineSize).ToList();
            }

            if (input.MinHp != null)
            {
                cars = cars.Where(x => x.Hp >= input.MinHp).ToList();
            }

            if (input.MaxHp != null)
            {
                cars = cars.Where(x => x.Hp <= input.MaxHp).ToList();
            }

            if (input.MinYear != null)
            {
                cars = cars.Where(x => x.Year >= input.MinYear).ToList();
            }

            if (input.MaxYear != null)
            {
                cars = cars.Where(x => x.Year <= input.MaxYear).ToList();
            }

            if (input.MinMileage != null)
            {
                cars = cars.Where(x => x.Mileage >= input.MinMileage).ToList();
            }

            if (input.MaxMileage != null)
            {
                cars = cars.Where(x => x.Mileage <= input.MaxMileage).ToList();
            }

            if (input.MinPrice != null)
            {
                cars = cars.Where(x => x.Mileage >= input.MinPrice).ToList();
            }

            if (input.MaxPrice != null)
            {
                cars = cars.Where(x => x.Mileage <= input.MaxPrice).ToList();
            }

            return cars;
        }
    }
}
