namespace FenzyCars.Web.Controllers
{
    using System.Security.Claims;

    using FenzyCars.Data.Models;
    using FenzyCars.Services.Data;
    using FenzyCars.Web.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class UsersController : BaseController
    {
        private readonly IUsersService usersService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IWebHostEnvironment environment;

        public UsersController(IUsersService usersService, UserManager<ApplicationUser> userManager, IWebHostEnvironment environment)
        {
            this.usersService = usersService;
            this.userManager = userManager;
            this.environment = environment;
        }

        [Authorize]
        public IActionResult SendMessage(string id)
        {
            var senderId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            UserSendMessageViewModel view = new UserSendMessageViewModel
            {
                Reciever = this.usersService.GetUserById(id),
                Sender = this.usersService.GetUserById(senderId),
                recieverId = id,
                senderId = senderId,
            };

            return this.View(view);
        }

        [Authorize]
        [HttpPost]
        public IActionResult SendMessage(UserSendMessageViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            this.usersService.SendMessage(input, $"{this.environment.WebRootPath}/images");

            return this.RedirectToAction(nameof(this.Chat), input);
        }

        public IActionResult Chat(UserChatViewModel input)
        {
            return this.View();
        }
    }
}
