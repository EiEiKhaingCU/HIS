using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly LibraryProject.Models.LibraryContext _context;
        public DetailsModel(LibraryProject.Models.LibraryContext context)
        {
            _context = context;
        }
        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Student = await _context.Students.FirstOrDefaultAsync(m => m.Id == id);
            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}