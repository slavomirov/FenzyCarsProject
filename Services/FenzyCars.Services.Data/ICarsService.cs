namespace FenzyCars.Services.Data
{
    using System.Threading.Tasks;

    using FenzyCars.Data.Models;
    using FenzyCars.Web.ViewModels;

    public interface ICarsService
    {
        Task AddAsync(CarsAddViewModel input, string imagePath);
    }
}
