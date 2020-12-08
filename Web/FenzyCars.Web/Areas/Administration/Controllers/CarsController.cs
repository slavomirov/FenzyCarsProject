namespace FenzyCars.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using FenzyCars.Data;
    using FenzyCars.Data.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    [Area("Administration")]
    public class CarsController : AdministrationController
    {
        private readonly ApplicationDbContext db;

        public CarsController(ApplicationDbContext context)
        {
            this.db = context;
        }

        // GET: Administration/Cars
        public async Task<IActionResult> Index()
        {
            return this.View(await this.db.Cars.ToListAsync());
        }

        // GET: Administration/Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var car = await this.db.Cars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return this.NotFound();
            }

            return this.View(car);
        }

        // GET: Administration/Cars/Create
        public IActionResult Create()
        {
            return this.View();
        }

        // POST: Administration/Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Make,Model,Color,Hp,Mileage,BodyType,FuelType,Seats,Doors,Transmission,EngineSize,Year,Description,Price,IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] Car car)
        {
            if (this.ModelState.IsValid)
            {
                this.db.Add(car);
                await this.db.SaveChangesAsync();
                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(car);
        }

        // GET: Administration/Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var car = await this.db.Cars.FindAsync(id);
            if (car == null)
            {
                return this.NotFound();
            }

            return this.View(car);
        }

        // POST: Administration/Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Make,Model,Color,Hp,Mileage,BodyType,FuelType,Seats,Doors,Transmission,EngineSize,Year,Description,Price,IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] Car car)
        {
            if (id != car.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {
                try
                {
                    this.db.Update(car);
                    await this.db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.CarExists(car.Id))
                    {
                        return this.NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(car);
        }

        // GET: Administration/Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var car = await this.db.Cars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return this.NotFound();
            }

            return this.View(car);
        }

        // POST: Administration/Cars/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = await this.db.Cars.FindAsync(id);

            // this.db.Cars.Remove(car);
            MyRemove(car);
            await this.db.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }

        private static void MyRemove(Car car)
        {
            car.DeletedOn = DateTime.UtcNow;
            car.IsDeleted = true;
        }

        private bool CarExists(int id)
        {
            return this.db.Cars.Any(e => e.Id == id);
        }
    }
}
