namespace FenzyCars.Web.ViewModels
{
    using System;
    using System.Collections.Generic;

    public class CarsListViewModel
    {
        public int ItemsPerPage { get; set; }

        public IEnumerable<CarsInListViewModel> Cars { get; set; }

        public int PageNumber { get; set; }

        public int CarsCount { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public int PreviousPageNumber => this.PageNumber - 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int NextPageNumber => this.PageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.CarsCount / this.ItemsPerPage);
    }
}
