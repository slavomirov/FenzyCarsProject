    namespace FenzyCars.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Message
    {
        public Message()
        {
            this.Images = new List<Image>();
        }

        public int Id { get; set; }

        public string Text { get; set; }

        public List<Image> Images { get; set; }

        public DateTime Time { get; set; }

        public int ChatId { get; set; }
    }
}
