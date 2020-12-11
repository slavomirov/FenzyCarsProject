namespace FenzyCars.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using FenzyCars.Data;
    using FenzyCars.Data.Models;
    using FenzyCars.Services.Data;
    using FenzyCars.Web.ViewModels;
    using FenzyCars.Web.ViewModels.Cars;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class CarsController : BaseController
    {
        private readonly ICarsService carsService;
        private readonly IWebHostEnvironment environment;
        private readonly UserManager<ApplicationUser> userManager;

        public CarsController(ICarsService carsService, IWebHostEnvironment webHostEnvironment, UserManager<ApplicationUser> userManager)
        {
            this.carsService = carsService;
            this.environment = webHostEnvironment;
            this.userManager = userManager;
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
                return this.Redirect("/error");
            }

            this.TempData["Message"] = "Car added successfully.";
            return this.Redirect("/");
        }

        public IActionResult ById(int id)
        {
            var car = this.carsService.ById<CarsByIdViewModel>(id);
            var loggedUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (car != null)
            {
                car.LoggedUserId = loggedUserId;
            }

            return this.View(car);
        }

        public IActionResult All(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int itemsPerPage = 4;
            var viewModel = new CarsListViewModel
            {
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                CarsCount = this.carsService.GetCount(),
                Cars = this.carsService.GetAll<CarsInListViewModel>(id),
            };

            return this.View(viewModel);
        }

        public IActionResult Search()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Search(CarsSearchViewModel viewModel)
        {
            var cars = this.carsService.Search(viewModel);

            return this.View(nameof(this.ResultFromSearch), cars);
        }

        public IActionResult ResultFromSearch(ICollection<CarsByIdViewModel> viewModel)
        {
            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var input = this.carsService.ById<CarEditViewModel>(id);

            input.Id = id;
            return this.View(input);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(int id, CarEditViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.Id = id;
                return this.View(input);
            }

            await this.carsService.UpdateAsync(id, input);
            return this.RedirectToAction(nameof(this.ById), new { id });
        }

        [Authorize]
        public IActionResult MyCars(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            const int itemsPerPage = 4;

            var viewModel = this.carsService.GetCarsByUserId(userId, id);
            viewModel.ItemsPerPage = itemsPerPage;
            viewModel.PageNumber = id;

            return this.View(viewModel);
        }

        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            await this.carsService.DeleteAsync(id);
            return this.RedirectToAction(nameof(this.All));
        }
    }
}
