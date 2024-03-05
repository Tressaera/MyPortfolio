using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyPortfolio.Models
{
    public partial class MyPortfolioContext : DbContext
    {
        public MyPortfolioContext()
        {
        }

        public MyPortfolioContext(DbContextOptions<MyPortfolioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAbout> TblAbouts { get; set; } = null!;
        public virtual DbSet<TblCategory> TblCategories { get; set; } = null!;
        public virtual DbSet<TblContact> TblContacts { get; set; } = null!;
        public virtual DbSet<TblFeature> TblFeatures { get; set; } = null!;
        public virtual DbSet<TblProject> TblProjects { get; set; } = null!;
        public virtual DbSet<TblService> TblServices { get; set; } = null!;
        public virtual DbSet<TblSocialMedial> TblSocialMedials { get; set; } = null!;
        public virtual DbSet<TblSocialMedium> TblSocialMedia { get; set; } = null!;
        public virtual DbSet<TblTestimonial> TblTestimonials { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

            => optionsBuilder.UseSqlServer("Server=(localdb)\\local;Database=MyPortfolio;");
           
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAbout>(entity =>
            {
                entity.HasKey(e => e.AboutId)
                    .HasName("PK__TblAbout__717FC93C6F73629C");

                entity.ToTable("TblAbout");

                entity.Property(e => e.AboutId).ValueGeneratedNever();

                entity.Property(e => e.Header).HasMaxLength(100);

                entity.Property(e => e.ImageUrl).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__TblCateg__19093A0BB1F82B44");

                entity.ToTable("TblCategory");

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TblContact>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK__TblConta__5C66259BE4DFC3D6");

                entity.ToTable("TblContact");

                entity.Property(e => e.ContactId).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.NameSurname).HasMaxLength(200);

                entity.Property(e => e.SendDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblFeature>(entity =>
            {
                entity.HasKey(e => e.FeatureId)
                    .HasName("PK__TblFeatu__82230BC9C6C3CDEB");

                entity.ToTable("TblFeature");

                entity.Property(e => e.FeatureId).ValueGeneratedNever();

                entity.Property(e => e.Header).HasMaxLength(100);

                entity.Property(e => e.NameSurname).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<TblProject>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("PK__TblProje__761ABEF0C4A42785");

                entity.ToTable("TblProject");

                entity.Property(e => e.ProjectId).ValueGeneratedNever();

                entity.Property(e => e.ImageUrl).HasMaxLength(200);

                entity.Property(e => e.ProjectUrl).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.ProjectCategoryNavigation)
                    .WithMany(p => p.TblProjects)
                    .HasForeignKey(d => d.ProjectCategory)
                    .HasConstraintName("FK_TblProject_TblCategory");
            });

            modelBuilder.Entity<TblService>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK__TblServi__C51BB00AA791E764");

                entity.ToTable("TblService");

                entity.Property(e => e.ServiceId).ValueGeneratedNever();

                entity.Property(e => e.ServiceIcon).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(150);
            });

            modelBuilder.Entity<TblSocialMedial>(entity =>
            {
                entity.HasKey(e => e.SocialMediaId)
                    .HasName("PK__TblSocia__3B026C1BBDC8CA0F");

                entity.ToTable("TblSocialMedial");

                entity.Property(e => e.SocialMediaId).ValueGeneratedNever();

                entity.Property(e => e.IconUrl).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(200);
            });

            modelBuilder.Entity<TblSocialMedium>(entity =>
            {
                entity.HasKey(e => e.SocialMediaId)
                    .HasName("PK__TblSocia__3B026C1BF84AD118");

                entity.ToTable("TblSocialMedium");

                entity.Property(e => e.SocialMediaId).ValueGeneratedNever();

                entity.Property(e => e.IconUrl).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(200);
            });

            modelBuilder.Entity<TblTestimonial>(entity =>
            {
                entity.HasKey(e => e.TestimonialId)
                    .HasName("PK__TblTesti__91A23E7318F5F5C0");

                entity.ToTable("TblTestimonial");

                entity.Property(e => e.TestimonialId).ValueGeneratedNever();

                entity.Property(e => e.ImageUrl).HasMaxLength(200);

                entity.Property(e => e.NameSurname).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
