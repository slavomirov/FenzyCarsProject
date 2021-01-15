namespace FenzyCars.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using FenzyCars.Data;
    using FenzyCars.Data.Models;

    public class VotesService : IVotesService
    {
        private readonly ApplicationDbContext dbContext;

        public VotesService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public double GetAverageVotes(string dealershipId)
        {
            var count = this.dbContext.Votes.Where(x => x.DealershipId == dealershipId).Count() > 0;

            if (count)
            {
                return this.dbContext.Votes
                .Where(x => x.DealershipId == dealershipId)
                .Average(x => x.Value);
            }

            return 0;
        }

        public async Task SetVoteAsync(string dealershipId, string userId, byte value)
        {
            var vote = this.dbContext.Votes
                .Where(x => x.DealershipId == dealershipId && x.UserId == userId)
                .FirstOrDefault();

            if (vote == null)
            {
                vote = new Vote
                {
                    DealershipId = dealershipId,
                    UserId = userId,
                };

                await this.dbContext.Votes.AddAsync(vote);
            }

            vote.Value = value;
            await this.dbContext.SaveChangesAsync();
        }
    }
}
