using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab_KiemTra.Models
{
    public partial class ManageModel : DbContext
    {
        public ManageModel()
            : base("name=ManageModel")
        {
        }

        public virtual DbSet<CONGTY> CONGTies { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CONGTY>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.CONGTY)
                .WillCascadeOnDelete(false);
        }
    }
}
