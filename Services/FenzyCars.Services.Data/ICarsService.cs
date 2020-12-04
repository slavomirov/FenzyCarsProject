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

        CarsByIdViewModel ById(int id);

        public ICollection<CarsByIdViewModel> Search(CarsSearchViewModel input);
    }
}
