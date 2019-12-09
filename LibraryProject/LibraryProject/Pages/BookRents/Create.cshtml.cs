using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LibraryProject.Models;

namespace LibraryProject.Pages.BookRents
{
    public class CreateModel : PageModel
    {
        private readonly LibraryProject.Models.LibraryContext _context;

        public CreateModel(LibraryProject.Models.LibraryContext context)
        {
            _context = context;
        }
        public Book book { get; set; }
        public IActionResult OnGe()
        {
           
            return Page();
        }

        [BindProperty]
        public BookRent BookRent { get; set; }

       public Book Book { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            int RentQty = BookRent.Qty;
            var RentBookId = BookRent.BookId;
            var OriginalQty = _context.Books.Where(s => s.Id == RentBookId).FirstOrDefault().Qty;
            var UpdateQty = OriginalQty - RentQty;
            var entity = _context.Books.FirstOrDefault(item => item.Id == RentBookId);

            if (entity != null)
            {
                entity.Qty = UpdateQty;
                _context.Books.Update(entity);
                _context.SaveChanges();
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }
           
            _context.BookRent.Add(BookRent);
            await _context.SaveChangesAsync();
           
            return RedirectToPage("./Index");
        }
    }
}
