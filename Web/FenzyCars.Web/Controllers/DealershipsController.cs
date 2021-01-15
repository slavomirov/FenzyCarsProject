namespace FenzyCars.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using FenzyCars.Data.Models;
    using FenzyCars.Services.Data;
    using FenzyCars.Web.ViewModels.CarDealerships;
    using FenzyCars.Web.ViewModels.Cars;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class DealershipsController : BaseController
    {
        private readonly IDealershipsService dealershipService;
        private readonly IWebHostEnvironment environment;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IVotesService votesService;

        public DealershipsController(IDealershipsService dealershipService, IWebHostEnvironment environment, UserManager<ApplicationUser> userManager, IVotesService votesService)
        {
            this.dealershipService = dealershipService;
            this.environment = environment;
            this.userManager = userManager;
            this.votesService = votesService;
        }

        [Authorize]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddAsync(DealershipsAddViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/error");
            }

            var ownerId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ownerId == null)
            {
                return this.Redirect("/error");
            }

            input.OwnerId = ownerId;

            try
            {
                await this.dealershipService.AddAsync(input, $"{this.environment.WebRootPath}/images");
            }
            catch (System.Exception)
            {
                return this.Redirect("/error");
            }

            this.TempData["Message"] = "Dealership added successfully.";
            return this.Redirect("/");
        }

        public IActionResult All(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int itemsPerPage = 3;
            var viewModel = new DealershipsListViewModel
            {
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                DealershipsCount = this.dealershipService.GetDealershipCount(),
                Dealerships = this.dealershipService.GetAll<DealershipsInListViewModel>(id),
            };

            return this.View(viewModel);
        }

        [HttpGet("/Dealerships/ById/{dealershipId}")]
        public IActionResult ById(string dealershipId, int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            var ownerId = this.dealershipService.GetOwnerId(dealershipId);

            const int itemsPerPage = 4;
            var viewModel = new DealershipsByIdListViewModel
            {
                AverageVote = this.votesService.GetAverageVotes(dealershipId),
                Info = this.dealershipService.Info(dealershipId),
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                CarsCount = this.dealershipService.GetCarsCount(dealershipId),
                Cars = this.dealershipService.GetAllDealershipCars<DealershipsByIdViewModel>(id, dealershipId),
                DealershipId = dealershipId,
                LoggedUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier),
                OwnerId = ownerId,
            };

            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult AddCar(string dealershipId)
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddCarAsync(CarsAddViewModel input, string dealershipId)
        {
            var user = await this.userManager.GetUserAsync(this.HttpContext.User);

            var userId = user.Id;

            await this.dealershipService.AddCarAsync(input, $"{this.environment.WebRootPath}/images", dealershipId, userId);

            return this.Redirect("/");
        }

        [Authorize]
        public IActionResult MyDealerships(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            const int itemsPerPage = 3;
            var viewModel = new DealershipsListViewModel
            {
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                DealershipsCount = this.dealershipService.GetDealershipCount(userId),
                Dealerships = this.dealershipService.GetAll<DealershipsInListViewModel>(id, userId, itemsPerPage),
            };

            return this.View(viewModel);
        }

        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            await this.dealershipService.DeleteAsync(id);

            this.TempData["Message"] = "Dealership deleted successfully.";
            return this.Redirect("/");
        }
    }
}
