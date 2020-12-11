namespace FenzyCars.Web.ViewModels.Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using FenzyCars.Data.Models;
    using FenzyCars.Services.Mapping;

    public class CarsByIdViewModel : IMapFrom<Car>, IHaveCustomMappings
    {
        public CarsByIdViewModel()
        {
            this.Images = new HashSet<Image>();
            this.User = new ApplicationUser();
        }

        public int Id { get; set; }

        public string LoggedUserId { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Hp { get; set; }

        public int Mileage { get; set; }

        public string BodyType { get; set; }

        public string FuelType { get; set; }

        public string Transmission { get; set; }

        public int Seats { get; set; }

        public int Doors { get; set; }

        public int EngineSize { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public int Price { get; set; }

        public ICollection<Image> Images { get; set; }

        public ApplicationUser User { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Car, CarsByIdViewModel>()
                .ForMember(x => x.User, opt =>
                    opt.MapFrom(x =>
                    x.UserCars.FirstOrDefault().User));
        }
    }
}
