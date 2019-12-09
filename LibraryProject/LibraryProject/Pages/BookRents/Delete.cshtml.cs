using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryProject.Models;

namespace LibraryProject.Pages.BookRents
{
    public class DeleteModel : PageModel
    {
        private readonly LibraryProject.Models.LibraryContext _context;

        public DeleteModel(LibraryProject.Models.LibraryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BookRent BookRent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookRent = await _context.BookRent.FirstOrDefaultAsync(m => m.Id == id);

            if (BookRent == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookRent = await _context.BookRent.FindAsync(id);

            if (BookRent != null)
            {
                _context.BookRent.Remove(BookRent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
