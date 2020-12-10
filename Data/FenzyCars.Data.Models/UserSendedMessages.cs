namespace FenzyCars.Data.Models
{
    public class UserSendedMessages
    {
        public int Id { get; set; }

        public string RecieverId { get; set; }
        public virtual ApplicationUser Reciever { get; set; }

        public int MessageId { get; set; }
        public virtual SendedMessage Message { get; set; }
    }
}
