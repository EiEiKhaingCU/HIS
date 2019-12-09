using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalMangementSystem.Models;

namespace HospitalMangementSystem.Models
{
    public class HospitalContext:DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Schdeule> Schedule { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Specialist> Specialist { get; set; }
        public virtual DbSet<Symptoms> Symptoms { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<MedicineCategory> MedicineCategory { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Room> Room { get; set; }
    }
}
