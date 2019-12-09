using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMangementSystem.Models
{
    public class Appointment
{
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

       

        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public Schdeule Schdeule { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int tokenNo { get; set; }

}
}
