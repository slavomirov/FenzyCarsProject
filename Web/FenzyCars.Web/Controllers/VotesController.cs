namespace FenzyCars.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using FenzyCars.Services.Data;
    using FenzyCars.Web.ViewModels.Votes;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("/api/[controller]")]
    public class VotesController : BaseController
    {
        private readonly IVotesService votesService;

        public VotesController(IVotesService votesService)
        {
            this.votesService = votesService;
        }

        [Authorize]
        [HttpPost]
        [IgnoreAntiforgeryToken]
        public async Task<ActionResult<PostVoteResponseModel>> Post(PostVoteInputModel input)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.votesService.SetVoteAsync(input.DealershipId, userId, input.Value);
            var averageVote = this.votesService.GetAverageVotes(input.DealershipId);
            return new PostVoteResponseModel { AverageVote = averageVote };
        }
    }
}
