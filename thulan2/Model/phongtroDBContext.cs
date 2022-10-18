using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace thulan2.Model
{
    public partial class phongtroDBContext : DbContext
    {
        public phongtroDBContext()
            : base("name=phongtroDBContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<CTDICHVU> CTDICHVUs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<HOPDONG> HOPDONGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<PHIEUGIAHAN> PHIEUGIAHANs { get; set; }
        public virtual DbSet<PHIEUTHANHTOAN> PHIEUTHANHTOANs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTDICHVU>()
                .Property(e => e.Sop)
                .IsFixedLength();

            modelBuilder.Entity<CTDICHVU>()
                .Property(e => e.Madv)
                .IsFixedLength();

            modelBuilder.Entity<CTDICHVU>()
                .Property(e => e.Maptt)
                .IsFixedLength();

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.Madv)
                .IsFixedLength();

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.Donvitinh)
                .IsFixedLength();

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.CTDICHVUs)
                .WithRequired(e => e.DICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.Mahd)
                .IsFixedLength();

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.Tiencoc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.Makh)
                .IsFixedLength();

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.Sop)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Makh)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.CMND)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Sdt)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUGIAHAN>()
                .Property(e => e.Maphieu)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUGIAHAN>()
                .Property(e => e.Mahd)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTHANHTOAN>()
                .Property(e => e.Maptt)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUTHANHTOAN>()
                .Property(e => e.Tongtiendichvu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUTHANHTOAN>()
                .Property(e => e.Tienphong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUTHANHTOAN>()
                .HasMany(e => e.CTDICHVUs)
                .WithRequired(e => e.PHIEUTHANHTOAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.Sop)
                .IsFixedLength();

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.CTDICHVUs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);
        }
    }
}
