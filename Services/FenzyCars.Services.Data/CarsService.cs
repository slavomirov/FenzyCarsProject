namespace FenzyCars.Services.Data
{
    using FenzyCars.Data.Models;
    using FenzyCars.Data;

    public class CarsService : ICarsService
    {
        private readonly ApplicationDbContext db;

        public CarsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void Add(Car car)
        {
            throw new System.NotImplementedException();
        }
    }
}
