namespace FenzyCars.Web.ViewModels
{
    using System.Collections.Generic;

    using FenzyCars.Data.Models;
    using Microsoft.AspNetCore.Http;

    public class UserSendMessageViewModel
    {
        public UserSendMessageViewModel()
        {
            this.Images = new List<IFormFile>();
        }

        public string Message { get; set; }

        public List<IFormFile> Images { get; set; }

        public ApplicationUser Sender { get; set; }
        public string senderId { get; set; }

        public ApplicationUser Reciever { get; set; }
        public string recieverId { get; set; }
    }
}
