namespace FenzyCars.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using FenzyCars.Data.Models;
    using FenzyCars.Web.ViewModels;

    public interface ICarsService
    {
        Task AddAsync(CarsAddViewModel input, string imagePath);

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 4);

        CarsInListViewModel GetRandom();

        int GetCount();

        T ById<T>(int id);

        ICollection<CarsByIdViewModel> Search(CarsSearchViewModel input);

        Task UpdateAsync(int id, CarEditViewModel input);
    }
}
