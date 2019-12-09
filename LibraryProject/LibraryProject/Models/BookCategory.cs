using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Models
{
    public class BookCategory
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripation { get; set; }
       
        public ICollection<Book> Books { get; set; }
    }
}
