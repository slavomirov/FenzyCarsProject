namespace FenzyCars.Services.Data
{
    using System.Collections.Generic;

    using FenzyCars.Data.Models;
    using FenzyCars.Web.ViewModels;
    using FenzyCars.Web.ViewModels.Messages;

    public interface IUsersService
    {
        ApplicationUser GetUserById(string id);

        void SendMessage(UserSendMessageViewModel input, string imagePath);

        IEnumerable<RecievedMessagesInListViewModel> GetAllRecieved(int page, string userId, int itemsPerPage = 4);

        int GetRecievedCount(string userId);

        IEnumerable<SendedMessagesInListViewModel> GetAllSended(int page, string userId, int itemsPerPage = 4);

        int GetSendedCount(string userId);
    }
}
