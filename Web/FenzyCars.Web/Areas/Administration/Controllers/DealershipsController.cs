using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FenzyCars.Data;
using FenzyCars.Data.Models;

namespace FenzyCars.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class DealershipsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DealershipsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Administration/Dealerships
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dealerships.ToListAsync());
        }

        // GET: Administration/Dealerships/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealership = await _context.Dealerships
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dealership == null)
            {
                return NotFound();
            }

            return View(dealership);
        }

        // GET: Administration/Dealerships/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administration/Dealerships/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,City,PhoneNumber,Description,CreatedOn,ModifiedOn,IsDeleted,DeletedOn,Added")] Dealership dealership)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dealership);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dealership);
        }

        // GET: Administration/Dealerships/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealership = await _context.Dealerships.FindAsync(id);
            if (dealership == null)
            {
                return NotFound();
            }
            return View(dealership);
        }

        // POST: Administration/Dealerships/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,City,PhoneNumber,Description,CreatedOn,ModifiedOn,IsDeleted,DeletedOn,Added")] Dealership dealership)
        {
            if (id != dealership.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dealership);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DealershipExists(dealership.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dealership);
        }

        // GET: Administration/Dealerships/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealership = await _context.Dealerships
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dealership == null)
            {
                return NotFound();
            }

            return View(dealership);
        }

        // POST: Administration/Dealerships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dealership = await _context.Dealerships.FindAsync(id);
            _context.Dealerships.Remove(dealership);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DealershipExists(string id)
        {
            return _context.Dealerships.Any(e => e.Id == id);
        }
    }
}
