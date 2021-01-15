namespace FenzyCars.Web.ViewModels.CarDealerships
{
    using System;
    using System.Collections.Generic;

    public class DealershipsListViewModel
    {
        public DealershipsListViewModel()
        {
            this.Dealerships = new List<DealershipsInListViewModel>();
        }

        public ICollection<DealershipsInListViewModel> Dealerships { get; set; }

        public int ItemsPerPage { get; set; }

        public int PageNumber { get; set; }

        public int DealershipsCount { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public int PreviousPageNumber => this.PageNumber - 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int NextPageNumber => this.PageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.DealershipsCount / this.ItemsPerPage);
    }
}
