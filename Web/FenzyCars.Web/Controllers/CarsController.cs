namespace FenzyCars.Web.Controllers
{
    using FenzyCars.Data;
    using FenzyCars.Data.Models;
    using FenzyCars.Services.Data;
    using FenzyCars.Web.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;

    public class CarsController : BaseController
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ICarsService carsService;

        public CarsController(ApplicationDbContext dbContext, ICarsService carsService)
        {
            this.dbContext = dbContext;
            this.carsService = carsService;
        }

        [Authorize]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(CarsAddViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/Shared/Error");
            }

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {
                input.UserId = userId;
            }

            this.carsService.Add(input);

            return this.Redirect("/");
        }
    }
}
