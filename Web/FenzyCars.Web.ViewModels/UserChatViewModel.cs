namespace FenzyCars.Web.ViewModels
{
    using System.Collections.Generic;

    using FenzyCars.Data.Models;

    public class UserChatViewModel
    {
        public UserChatViewModel()
        {
            this.LastMessagesFromFirst = new List<Message>();
            this.LastMessagesFromSecond = new List<Message>();
        }

        public List<Message> LastMessagesFromFirst { get; set; }

        public List<Message> LastMessagesFromSecond { get; set; }
    }
}
