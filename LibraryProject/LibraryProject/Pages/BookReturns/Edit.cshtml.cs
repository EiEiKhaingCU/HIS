using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibraryProject.Models;

namespace LibraryProject.Pages.BookReturns
{
    public class EditModel : PageModel
    {
        private readonly LibraryProject.Models.LibraryContext _context;

        public EditModel(LibraryProject.Models.LibraryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BookReturn BookReturn { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookReturn = await _context.BookReturn
                .Include(b => b.bookRent).FirstOrDefaultAsync(m => m.Id == id);

            if (BookReturn == null)
            {
                return NotFound();
            }
           ViewData["BookRentId"] = new SelectList(_context.BookRent, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BookReturn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookReturnExists(BookReturn.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BookReturnExists(int id)
        {
            return _context.BookReturn.Any(e => e.Id == id);
        }
    }
}
