namespace FenzyCars.Web.ViewModels.CarDealerships
{
    using FenzyCars.Data.Models;
    using FenzyCars.Services.Mapping;

    public class DealershipInfoViewModel : IMapFrom<Dealership>
    {
        public string Name { get; set; }

        public string City { get; set; }

        public string PhoneNumber { get; set; }

        public string Description { get; set; }

        public DealershipLogo Logo { get; set; }
    }
}
