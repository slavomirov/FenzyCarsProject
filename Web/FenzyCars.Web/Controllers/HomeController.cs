namespace FenzyCars.Web.Controllers
{
    using System.Diagnostics;

    using FenzyCars.Services.Data;
    using FenzyCars.Web.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ICarsService carsService;

        public HomeController(ICarsService carsService)
        {
            this.carsService = carsService;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            var viewModel = this.carsService.GetRandom();

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [Authorize]
        public IActionResult Chat()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("/error")]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
