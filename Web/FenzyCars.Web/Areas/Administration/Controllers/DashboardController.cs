namespace FenzyCars.Web.Areas.Administration.Controllers
{
    using FenzyCars.Common;
    using FenzyCars.Services.Data;
    using FenzyCars.Web.Controllers;
    using FenzyCars.Web.ViewModels.Administration.Dashboard;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class DashboardController : AdministrationController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
