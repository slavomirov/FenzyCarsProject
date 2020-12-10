﻿namespace FenzyCars.Web.ViewModels.Messages
{
    using System;
    using System.Collections.Generic;

    using FenzyCars.Data.Models;
    using FenzyCars.Services.Mapping;

    public class SendedMessagesListViewModel
    {
        public int ItemsPerPage { get; set; }

        public IEnumerable<SendedMessagesInListViewModel> Messages { get; set; }

        public int PageNumber { get; set; }

        public int MessagesCount { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public int PreviousPageNumber => this.PageNumber - 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int NextPageNumber => this.PageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.MessagesCount / this.ItemsPerPage);
    }
}
