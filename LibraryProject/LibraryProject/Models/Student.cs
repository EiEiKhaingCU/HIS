﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Models
{
    public class Student
    {
       

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string RollNo { get; set; }
        public string Nrc { get; set; }
        public string Email { get; set; }
        public BookRent BookRent { get; set; }
      
    }
}
