namespace FenzyCars.Services.Data
{
    using FenzyCars.Data.Models;
    using FenzyCars.Web.ViewModels;

    public interface ICarsService
    {
        void Add(CarsAddViewModel input);
    }
}
