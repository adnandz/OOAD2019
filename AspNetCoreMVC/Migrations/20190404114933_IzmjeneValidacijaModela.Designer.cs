﻿// <auto-generated />
using AspNetCoreMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCoreMVC.Migrations
{
    [DbContext(typeof(OOADContext))]
    [Migration("20190404114933_IzmjeneValidacijaModela")]
    partial class IzmjeneValidacijaModela
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCoreMVC.Models.Predmet", b =>
                {
                    b.Property<int>("PredmetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ETCS");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(160);

                    b.HasKey("PredmetId");

                    b.ToTable("Predmet");
                });

            modelBuilder.Entity("AspNetCoreMVC.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime")
                        .IsRequired();

                    b.Property<string>("Prezime")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("AspNetCoreMVC.Models.UpisNaPredmet", b =>
                {
                    b.Property<int>("UpisNaPredmetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ocjena");

                    b.Property<int>("PredmetId");

                    b.Property<int>("StudentId");

                    b.HasKey("UpisNaPredmetId");

                    b.HasIndex("PredmetId");

                    b.HasIndex("StudentId");

                    b.ToTable("UpisNaPredmet");
                });

            modelBuilder.Entity("AspNetCoreMVC.Models.UpisNaPredmet", b =>
                {
                    b.HasOne("AspNetCoreMVC.Models.Predmet", "Predmet")
                        .WithMany("UpisiNaPredmet")
                        .HasForeignKey("PredmetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AspNetCoreMVC.Models.Student", "Student")
                        .WithMany("UpisiNaPredmet")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
