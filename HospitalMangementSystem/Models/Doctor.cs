using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMangementSystem.Models
{
    public class Doctor
    {
        [Key]
      public  int Id { get; set; }
      public  string Name { get; set; }
      public string Email { get; set; }
      public double PhoneNo { get; set; }
      public string Gender { get; set; }
      public string NRC { get; set; }
      public string MedicalLicence { get; set; }


     [ForeignKey("Specialist")]
     public int SpecialistId { get; set; }


     public virtual Specialist Specialist { get; set; }
     ICollection<Schdeule> Schedule { get; set; }


     public virtual Appointment Appointment { get; set; }

    }
}
