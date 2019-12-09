using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMangementSystem.Models
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        [ForeignKey("Medicine")]
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
        public int Qty { get; set; }
        public int Amount { get; set; }
        public double TotalMedicalAmount { get; set; }

        public int MedicalBill { get; set; }
        public double TotalBill { get; set; }

    }
}

