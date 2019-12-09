using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Models
{
    public class BookRent
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int StudentId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Qty { get; set; }
        public BookReturn bookReturn { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
