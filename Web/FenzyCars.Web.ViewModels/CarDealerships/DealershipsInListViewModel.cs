namespace FenzyCars.Web.ViewModels.CarDealerships
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using FenzyCars.Data.Models;
    using FenzyCars.Services.Mapping;

    public class DealershipsInListViewModel : IMapFrom<Dealership>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string PhoneNumber { get; set; }

        public string Description { get; set; }

        public DealershipLogo Logo { get; set; }
    }
}
