﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMangementSystem.Models
{
    public class Specialist
    { 
        [Key]
      public int Id { get; set; }
       public string Name { get; set; }
       public ICollection<Doctor> Doctor { get; set; }
    }
}
