using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Pages.BookRentHistory
{
    public class BookRentHistoryModel : PageModel
    {
        private readonly LibraryProject.Models.LibraryContext _context;
        public BookRentHistoryModel(LibraryProject.Models.LibraryContext context)
        {
            _context = context;
        }

        public Student student { get; set; }
        public List<Student> StudentList { get; set; }
        public async Task<IActionResult>  OnGetAsync()
        {
            //var stu = await _context.Students.Select(s => s.Name).ToListAsync();

            var studentList = await _context.Students.ToListAsync();
            if (studentList == null)
            {
                return NotFound();
            }
            StudentList = studentList;
            return Page();
        }
       
    }
}