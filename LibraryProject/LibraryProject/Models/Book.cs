using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }
        public string Isbn { get; set; }
        public int Qty { get; set; }
        public BookCategory BookCategory { get; set; }
        public BookRent BookRent { get; set; }
    
   
    }
}
