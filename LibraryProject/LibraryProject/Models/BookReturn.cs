using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Models
{
    public class BookReturn
    {
        public int Id { get; set; }
        public int BookRentId { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime SysDate { get; set; }
        public BookRent bookRent { get; set; }
       
    }
}
