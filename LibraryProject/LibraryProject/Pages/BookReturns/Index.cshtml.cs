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
    public class IndexModel : PageModel
    {
        private readonly LibraryProject.Models.LibraryContext _context;

        public IndexModel(LibraryProject.Models.LibraryContext context)
        {
            _context = context;
        }

        public IList<BookReturn> BookReturn { get;set; }

        public async Task OnGetAsync()
        {
            BookReturn = await _context.BookReturn
                .Include(b => b.bookRent).ToListAsync();
        }
    }
}
