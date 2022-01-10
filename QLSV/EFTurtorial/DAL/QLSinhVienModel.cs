using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFTurtorial.DAL
{
    public partial class QLSinhVienModel : DbContext
    {
        public QLSinhVienModel()
            : base("name=QLSinhVienModelApppppp")
        {
        }
     
     
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVien>()
                .Property(e => e.IDStudent)
                .IsUnicode(false);
        }
    }
}
