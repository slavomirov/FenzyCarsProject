namespace FenzyCars.Services.Data
{
    using FenzyCars.Data.Models;
    using FenzyCars.Web.ViewModels;

    public interface IUsersService
    {
        ApplicationUser GetUserById(string id);

        void SendMessage(UserSendMessageViewModel input, string imagePath);
    }
}
