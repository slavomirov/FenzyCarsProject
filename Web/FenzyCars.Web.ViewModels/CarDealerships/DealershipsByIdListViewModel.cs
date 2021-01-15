namespace FenzyCars.Web.ViewModels.CarDealerships
{
    using System;
    using System.Collections.Generic;

    using FenzyCars.Web.ViewModels.Cars;

    public class DealershipsByIdListViewModel
    {
        public int ItemsPerPage { get; set; }

        public IEnumerable<DealershipsByIdViewModel> Cars { get; set; }

        public DealershipInfoViewModel Info { get; set; }

        public int PageNumber { get; set; }

        public int CarsCount { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public int PreviousPageNumber => this.PageNumber - 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int NextPageNumber => this.PageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.CarsCount / this.ItemsPerPage);

        public string LoggedUserId { get; set; }

        public string OwnerId { get; set; }

        public string DealershipId { get; set; }

        public double AverageVote { get; set; }
    }
}
