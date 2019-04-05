using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AspNetCoreAPI.Models
{
    public partial class MVCContext : DbContext
    {
        public MVCContext()
        {
        }

        public MVCContext(DbContextOptions<MVCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Predmet> Predmet { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<UpisNaPredmet> UpisNaPredmet { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Predmet>(entity =>
            {
                entity.Property(e => e.Etcs)
                    .HasColumnName("ETCS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(160);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ime).IsRequired();

                entity.Property(e => e.Prezime).IsRequired();
            });

            modelBuilder.Entity<UpisNaPredmet>(entity =>
            {
                entity.HasIndex(e => e.PredmetId);

                entity.HasIndex(e => e.StudentId);

                entity.HasOne(d => d.Predmet)
                    .WithMany(p => p.UpisNaPredmet)
                    .HasForeignKey(d => d.PredmetId);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.UpisNaPredmet)
                    .HasForeignKey(d => d.StudentId);
            });
        }
    }
}
