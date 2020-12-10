namespace FenzyCars.Data.Models
{
    public class UserRecievedMessages
    {
        public int Id { get; set; }

        public string SenderId { get; set; }
        public virtual ApplicationUser Sender { get; set; }

        public int MessageId { get; set; }
        public virtual RecievedMessage Message { get; set; }
    }
}
