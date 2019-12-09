using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMangementSystem.Models
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        [ForeignKey("MedicineCategory")]
        public int CategoryId { get; set; }
        public virtual MedicineCategory MedicineCategory { get; set; }
}
}
