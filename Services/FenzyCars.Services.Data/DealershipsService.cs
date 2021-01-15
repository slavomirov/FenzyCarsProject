namespace FenzyCars.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using FenzyCars.Data;
    using FenzyCars.Data.Models;
    using FenzyCars.Services.Mapping;
    using FenzyCars.Web.ViewModels.CarDealerships;
    using FenzyCars.Web.ViewModels.Cars;
    using Microsoft.EntityFrameworkCore;

    public class DealershipsService : IDealershipsService
    {
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif", "jpeg" };
        private readonly ApplicationDbContext dbContext;

        public DealershipsService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddAsync(DealershipsAddViewModel input, string imagePath)
        {
            Dealership carDealership = new Dealership
            {
                City = input.City,
                Name = input.Name,
                PhoneNumber = input.PhoneNumber,
                Description = input.Description,
            };

            var userDealership = new UserDealership
            {
                DealershipId = carDealership.Id,
                UserId = input.OwnerId,
            };

            Directory.CreateDirectory($"{imagePath}/DealershipsLogo/");

            var image = input.Logo;

            if (image != null)
            {
                var extension = Path.GetExtension(image.FileName).TrimStart('.');

                if (!this.allowedExtensions.Any(x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid image extension {extension}");
                }

                var logo = new DealershipLogo
                {
                    Extension = extension,
                    Dealership = carDealership,
                    DealershipId = carDealership.Id,
                };

                carDealership.Logo = logo;

                var physicalPath = $"{imagePath}/DealershipsLogo/{logo.Id}.{extension}";

                logo.RemoteImageUrl = "/images/DealershipsLogo/" + logo.Id + "." + logo.Extension;
                using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
            }

            await this.dbContext.Dealerships.AddAsync(carDealership);
            await this.dbContext.UserDealerships.AddAsync(userDealership);
            await this.dbContext.SaveChangesAsync();
        }

        public int GetDealershipCount()
        {
            return this.dbContext.Dealerships
                // .Where(x => x.Added == true)
                .Count();
        }

        public ICollection<T> GetAll<T>(int page, int itemsPerPage = 3)
        {
            var dealerships = this.dbContext.Dealerships
                // .Where(x => x.Added == true)
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .To<T>()
                .ToList();

            return dealerships;
        }

        public ICollection<T> GetAllDealershipCars<T>(int page, string dealershipId, int itemsPerPage = 3)
        {
            var cars = this.dbContext.DealershipCars
                .OrderByDescending(x => x.Id)
                .Where(x => x.Dealership.Id == dealershipId)
                .Select(x => x.Car)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .To<T>()
                .ToList();

            return cars;
        }

        public async Task AddCarAsync(CarsAddViewModel input, string imagePath, string dealershipId, string userId)
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
                Car = car,
                UserId = userId,
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

                dbImage.RemoteImageUrl = "/images/cars/" + dbImage.Id + "." + dbImage.Extension;
                car.Images.Add(dbImage);

                var physicalPath = $"{imagePath}/cars/{dbImage.Id}.{extension}";

                // "/images/cars/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension
                using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
            }

            var user = this.dbContext.Users.FirstOrDefault(x => x.Id == userId);
            user.CountOfPosts++;

            var dealership = this.dbContext.Dealerships.Where(x => x.Id == dealershipId).FirstOrDefault();

            var dealershipCar = new DealershipCar
            {
                Car = car,
                Dealership = dealership,
            };

            await this.dbContext.Cars.AddAsync(car);
            await this.dbContext.UserCars.AddAsync(userCars);
            await this.dbContext.DealershipCars.AddAsync(dealershipCar);
            await this.dbContext.SaveChangesAsync();
        }

        public int GetCarsCount(string dealershipId)
        {
            return this.dbContext.DealershipCars.Where(x => x.DealershipId == dealershipId).Count();
        }

        public string GetOwnerId(string dealershipId)
        {
            return this.dbContext.UserDealerships
                .Where(x => x.DealershipId == dealershipId)
                .Select(x => x.UserId)
                .FirstOrDefault();
        }

        public ICollection<T> GetAll<T>(int page, string userId, int itemsPerPage = 3)
        {
            var dealerships = this.dbContext.UserDealerships
               // .Where(x => x.Added == true)
               .Where(x => x.UserId == userId)
               .Select(x => x.Dealership)
               .OrderByDescending(x => x.Id)
               .Skip((page - 1) * itemsPerPage)
               .Take(itemsPerPage)
               .To<T>()
               .ToList();

            return dealerships;
        }

        public int GetDealershipCount(string userId)
        {
            return this.dbContext.UserDealerships
               // .Where(x => x.Added == true)
               .Where(x => x.UserId == userId)
               .Count();
        }

        public async Task DeleteAsync(string id)
        {
            var dealership = this.dbContext.Dealerships.Where(x => x.Id == id).FirstOrDefault();

            dealership.DeletedOn = DateTime.UtcNow;
            dealership.IsDeleted = true;

            await this.dbContext.SaveChangesAsync();
        }

        public DealershipInfoViewModel Info(string dealershipId)
        {
            return this.dbContext.Dealerships
                 .Where(x => x.Id == dealershipId)
                 .To<DealershipInfoViewModel>()
                 .FirstOrDefault();
        }
    }
}
