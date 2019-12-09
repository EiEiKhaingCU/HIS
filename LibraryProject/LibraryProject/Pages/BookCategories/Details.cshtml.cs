using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryProject.Models;

namespace LibraryProject.Pages.BookCategories
{
    public class DetailsModel : PageModel
    {
        private readonly LibraryProject.Models.LibraryContext _context;

        public DetailsModel(LibraryProject.Models.LibraryContext context)
        {
            _context = context;
        }

        public BookCategory BookCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookCategory = await _context.BookCategory.FirstOrDefaultAsync(m => m.Id == id);

            if (BookCategory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
