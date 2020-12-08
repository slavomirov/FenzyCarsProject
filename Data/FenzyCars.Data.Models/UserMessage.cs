namespace FenzyCars.Data.Models
{
    public class UserMessage
    {
        public int Id { get; set; }

        public string SenderId { get; set; }

        public ApplicationUser Sender { get; set; }

        public string RecieverId { get; set; }

        public ApplicationUser Reciever { get; set; }

        public int MessageId { get; set; }

        public Message Message { get; set; }
    }
}
