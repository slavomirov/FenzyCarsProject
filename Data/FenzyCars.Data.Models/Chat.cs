namespace FenzyCars.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Chat
    {
        public Chat()
        {
            this.FirstUserMessages = new List<Message>();
            this.SecondUserMessages = new List<Message>();
        }

        public int Id { get; set; }

        public string FirstUserId { get; set; }
        public virtual ApplicationUser FirstUser { get; set; }

        public string SecondUserId { get; set; }
        public virtual ApplicationUser SecondUser { get; set; }

        public List<Message> FirstUserMessages { get; set; }

        public List<Message> SecondUserMessages { get; set; }

        public void AddMessage(string senderId, Message message)
        {
            if (senderId == this.FirstUserId)
            {
                this.FirstUserMessages.Add(message);
            }
            else
            {
                this.SecondUserMessages.Add(message);
            }
        }
    }
}
