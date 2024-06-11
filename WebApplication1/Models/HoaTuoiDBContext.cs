using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.Models
{
    public partial class HoaTuoiDBContext : DbContext
    {
        public HoaTuoiDBContext()
        {
        }

        public HoaTuoiDBContext(DbContextOptions<HoaTuoiDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hoa> Hoas { get; set; }
        public virtual DbSet<Loai> Loais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=HoaTuoiDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Hoa>(entity =>
            {
                entity.HasKey(e => e.MaHoa);

                entity.ToTable("Hoa");

                entity.Property(e => e.Hinh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayDang).HasColumnType("datetime");

                entity.Property(e => e.TenHoa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.Hoas)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK_Hoa_DanhMuc");
            });

            modelBuilder.Entity<Loai>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK_DanhMuc");

                entity.ToTable("Loai");

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
