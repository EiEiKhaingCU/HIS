using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMangementSystem.Models
{
    public class Schdeule
    {
        [Key]
       public int Id { get; set; }
       public string Day { get; set; }
       public string StartTime { get; set; }
       public string EndTime { get; set; }
       [ForeignKey("Doctor")]
       public int DoctorId { get; set; }
       public virtual Doctor Doctor { get; set; }
    }
}
