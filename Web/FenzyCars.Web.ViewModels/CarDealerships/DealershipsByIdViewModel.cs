namespace FenzyCars.Web.ViewModels.CarDealerships
{
    using System.Linq;

    using AutoMapper;
    using FenzyCars.Data.Models;
    using FenzyCars.Services.Mapping;

    public class DealershipsByIdViewModel : IMapFrom<Car>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public int Price { get; set; }

        public string UserCity { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Car, DealershipsByIdViewModel>()
                .ForMember(x => x.ImageUrl, opt =>
                   opt.MapFrom(x =>
                    x.Images.FirstOrDefault().RemoteImageUrl != null ?
                    x.Images.FirstOrDefault().RemoteImageUrl :
                   "/images/cars/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension))
                .ForMember(c => c.UserCity, optc =>
                    optc.MapFrom(c =>
                    c.UserCars.FirstOrDefault().User.CityLiving));
        }
    }
}
