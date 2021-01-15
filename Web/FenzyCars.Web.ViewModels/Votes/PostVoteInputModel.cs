namespace FenzyCars.Web.ViewModels.Votes
{
    using System.ComponentModel.DataAnnotations;

    public class PostVoteInputModel
    {
        public string DealershipId { get; set; }

        [Range(1, 5)]
        public byte Value { get; set; }
    }
}
