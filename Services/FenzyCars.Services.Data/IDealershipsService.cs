namespace FenzyCars.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using FenzyCars.Web.ViewModels.CarDealerships;
    using FenzyCars.Web.ViewModels.Cars;

    public interface IDealershipsService
    {
        Task AddAsync(DealershipsAddViewModel input, string imagePath);

        int GetDealershipCount();

        int GetDealershipCount(string userId);

        ICollection<T> GetAll<T>(int page, int itemsPerPage = 3);

        ICollection<T> GetAll<T>(int page, string userId, int itemsPerPage = 3);

        int GetCarsCount(string dealershipId);

        ICollection<T> GetAllDealershipCars<T>(int page, string dealershipId, int itemsPerPage = 4);

        string GetOwnerId(string dealershipId);

        Task AddCarAsync(CarsAddViewModel input, string imagePath, string dealershipId, string userId);

        Task DeleteAsync(string id);

        DealershipInfoViewModel Info(string dealershipId);
    }
}
