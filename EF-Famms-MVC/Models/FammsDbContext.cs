using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EF_Famms_MVC.Models;

public partial class FammsDbContext : DbContext
{
    public FammsDbContext()
    {
    }

    public FammsDbContext(DbContextOptions<FammsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FooterContact> FooterContacts { get; set; }

    public virtual DbSet<ProductsTbl> ProductsTbls { get; set; }

    public virtual DbSet<Query> Queries { get; set; }

    public virtual DbSet<Testimonial> Testimonials { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WIN-HRJ8B1ML5AG;Database=FammsDb;Trusted_Connection=true;TrustServerCertificate=True;Encrypt=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FooterContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FOOTER_C__3214EC2750E6E29C");

            entity.ToTable("FOOTER_CONTACT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adress).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(200)
                .HasColumnName("Phone_Number");
        });

       

        modelBuilder.Entity<ProductsTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC27D04D0A37");

            entity.ToTable("Products_tbl");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(200)
                .HasColumnName("Img_Path");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.Price).HasColumnType("money");
        });

        modelBuilder.Entity<Query>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Queries__3214EC277C7CC3DB");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Message).HasMaxLength(255);
            entity.Property(e => e.Subject).HasMaxLength(200);
        });

        modelBuilder.Entity<Testimonial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Testimon__3214EC27FE249B49");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Fullname)
                .HasMaxLength(200)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(200)
                .HasColumnName("Img_Path");
            entity.Property(e => e.Position).HasMaxLength(200);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
