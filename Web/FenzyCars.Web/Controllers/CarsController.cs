namespace FenzyCars.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using FenzyCars.Data;
    using FenzyCars.Data.Models;
    using FenzyCars.Services.Data;
    using FenzyCars.Web.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;

    public class CarsController : BaseController
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ICarsService carsService;
        private readonly IWebHostEnvironment environment;

        public CarsController(ApplicationDbContext dbContext, ICarsService carsService, IWebHostEnvironment webHostEnvironment)
        {
            this.dbContext = dbContext;
            this.carsService = carsService;
            this.environment = webHostEnvironment;
        }

        [Authorize]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(CarsAddViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                // TODO: ADD ERRORS!
                return this.Redirect("/error");
            }

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                input.UserId = userId;
            }

            try
            {
                await this.carsService.AddAsync(input, $"{this.environment.WebRootPath}/images");
            }
            catch (System.Exception)
            {
                return this.Redirect("/Error");
            }

            return this.Redirect("/");
        }

        public IActionResult All(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int itemsPerPage = 2;
            var viewModel = new CarsListViewModel
            {
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                CarsCount = this.carsService.GetCount(),
                Cars = this.carsService.GetAll<CarsInListViewModel>(id),
            };

            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var car = this.carsService.ById(id);

            return this.View(car);
        }
    }
}
