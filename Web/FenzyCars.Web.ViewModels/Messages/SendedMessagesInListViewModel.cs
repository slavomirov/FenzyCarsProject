namespace FenzyCars.Web.ViewModels.Messages
{
    using System;
    using System.Collections.Generic;

    using FenzyCars.Data.Models;
    using FenzyCars.Services.Mapping;

    public class SendedMessagesInListViewModel : IMapFrom<SendedMessage>
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public List<Image> Images { get; set; }

        public DateTime Time { get; set; }

        public ApplicationUser Reciever { get; set; }

        public string SenderId { get; set; }
    }
}
