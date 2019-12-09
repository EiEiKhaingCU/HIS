using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalMangementSystem.Models;

namespace HospitalMangementSystem_EiEiKhaing_.Controllers
{
    public class MedicineCategoriesController : Controller
    {
        private readonly HospitalContext _context;

        public MedicineCategoriesController(HospitalContext context)
        {
            _context = context;
        }

        // GET: MedicineCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.MedicineCategory.ToListAsync());
        }

        // GET: MedicineCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicineCategory = await _context.MedicineCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicineCategory == null)
            {
                return NotFound();
            }

            return View(medicineCategory);
        }

        // GET: MedicineCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MedicineCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] MedicineCategory medicineCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicineCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicineCategory);
        }

        // GET: MedicineCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicineCategory = await _context.MedicineCategory.FindAsync(id);
            if (medicineCategory == null)
            {
                return NotFound();
            }
            return View(medicineCategory);
        }

        // POST: MedicineCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] MedicineCategory medicineCategory)
        {
            if (id != medicineCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicineCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicineCategoryExists(medicineCategory.Id))
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
            return View(medicineCategory);
        }

        // GET: MedicineCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicineCategory = await _context.MedicineCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicineCategory == null)
            {
                return NotFound();
            }

            return View(medicineCategory);
        }

        // POST: MedicineCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medicineCategory = await _context.MedicineCategory.FindAsync(id);
            _context.MedicineCategory.Remove(medicineCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicineCategoryExists(int id)
        {
            return _context.MedicineCategory.Any(e => e.Id == id);
        }
    }
}
