using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMangementSystem.Models
{
    public class Patient
{
        [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public double PhoneNo { get; set; }
    public string Gender { get; set; }
    public string Status { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string Weight { get; set; }
    public string Height { get; set; }
    public int Disease_History { get; set; }
    [ForeignKey("Symptoms")]
    public int SymptomsId { get; set; }
    public virtual Symptoms Symptoms { get; set; }
    public ICollection<Appointment> Appointment { get; set; }
}
}
