namespace FenzyCars.Web.ViewModels.Messages
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;
    using FenzyCars.Data.Models;
    using FenzyCars.Services.Mapping;

    public class RecievedMessagesInListViewModel : IMapFrom<RecievedMessage>
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public List<Image> Images { get; set; }

        public DateTime Time { get; set; }

        public ApplicationUser Sender { get; set; }

        public string RecieverId { get; set; }
    }
}
