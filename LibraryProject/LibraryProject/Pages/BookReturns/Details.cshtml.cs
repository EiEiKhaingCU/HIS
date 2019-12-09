using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryProject.Models;

namespace LibraryProject.Pages.BookReturns
{
    public class DetailsModel : PageModel
    {
        private readonly LibraryProject.Models.LibraryContext _context;

        public DetailsModel(LibraryProject.Models.LibraryContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
