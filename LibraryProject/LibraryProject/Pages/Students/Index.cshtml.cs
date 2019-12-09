using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace LibraryProject.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly LibraryProject.Models.LibraryContext _context;
        public IndexModel(LibraryProject.Models.LibraryContext context)
        {
            _context = context;
        }
        public IList<Student> Students { get; set; }
        [BindProperty]
        public int StudentId { get; set; }
        public async Task OnGetAsync()
        {
            Students = await _context.Students.ToListAsync();
            ViewData["Id"] = new SelectList(_context.Students, "Id", "Name");

        }
        public async Task<IActionResult> OnPostAsync()
        {
            Students = await _context.Students.Where(s => s.Id == StudentId).ToListAsync();
            return Page();
        }
    }

    
}