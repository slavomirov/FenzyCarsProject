namespace FenzyCars.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class RecievedMessage
    {
        public RecievedMessage()
        {
            this.Images = new List<Image>();
        }

        public int Id { get; set; }

        public string Text { get; set; }

        public List<Image> Images { get; set; }

        public DateTime Time { get; set; }

        public string SenderId { get; set; }
        public virtual ApplicationUser Sender { get; set; }

        public string RecieverId { get; set; }
    }
}
