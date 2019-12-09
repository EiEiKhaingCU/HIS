using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LibraryProject.Models;

namespace LibraryProject.Pages.BookReturns
{
    public class CreateModel : PageModel
    {
        private readonly LibraryProject.Models.LibraryContext _context;

        public CreateModel(LibraryProject.Models.LibraryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BookRentId"] = new SelectList(_context.BookRent, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public BookReturn BookReturn { get; set; }

        public Book Book { get; set; }
        public BookRent BookRent { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
           
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var RentId = BookReturn.BookRentId;
            var BookId = _context.BookRent.Where(s => s.Id == RentId).FirstOrDefault().BookId;
            var RentQty = _context.BookRent.Where(r => r.Id == RentId).FirstOrDefault().Qty;
            var OriginalQty = _context.BookRent.Where(t => t.Id == RentId).FirstOrDefault().Qty;
            var UpdateQty = RentQty + OriginalQty;
            var entity = _context.Books.FirstOrDefault(item => item.Id == RentId);
            if (entity != null)
            {
                entity.Qty = UpdateQty;
                _context.Books.Update(entity);
                _context.SaveChanges();

            }
            _context.BookReturn.Add(BookReturn);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
