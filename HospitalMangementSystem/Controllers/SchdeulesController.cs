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
    public class SchdeulesController : Controller
    {
        private readonly HospitalContext _context;

        public SchdeulesController(HospitalContext context)
        {
            _context = context;
        }

        // GET: Schdeules
        public async Task<IActionResult> Index()
        {
            var hospitalContext = _context.Schedule.Include(s => s.Doctor);
            return View(await hospitalContext.ToListAsync());
        }

        // GET: Schdeules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schdeule = await _context.Schedule
                .Include(s => s.Doctor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schdeule == null)
            {
                return NotFound();
            }

            return View(schdeule);
        }

        // GET: Schdeules/Create
        public IActionResult Create()
        {
            ViewData["DoctorId"] = new SelectList(_context.Doctor, "Id", "Name");
            return View();
        }

        // POST: Schdeules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Day,StartTime,EndTime,DoctorId")] Schdeule schdeule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schdeule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctor, "Id", "Name", schdeule.DoctorId);
            return View(schdeule);
        }

        // GET: Schdeules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schdeule = await _context.Schedule.FindAsync(id);
            if (schdeule == null)
            {
                return NotFound();
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctor, "Id", "Name", schdeule.DoctorId);
            return View(schdeule);
        }

        // POST: Schdeules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Day,StartTime,EndTime,DoctorId")] Schdeule schdeule)
        {
            if (id != schdeule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schdeule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchdeuleExists(schdeule.Id))
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
            ViewData["DoctorId"] = new SelectList(_context.Doctor, "Id", "Name", schdeule.DoctorId);
            return View(schdeule);
        }

        // GET: Schdeules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schdeule = await _context.Schedule
                .Include(s => s.Doctor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schdeule == null)
            {
                return NotFound();
            }

            return View(schdeule);
        }

        // POST: Schdeules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schdeule = await _context.Schedule.FindAsync(id);
            _context.Schedule.Remove(schdeule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchdeuleExists(int id)
        {
            return _context.Schedule.Any(e => e.Id == id);
        }
    }
}
