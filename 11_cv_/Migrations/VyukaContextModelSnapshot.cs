﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _11_cv_.EFCore;

#nullable disable

namespace _11_cv_.Migrations
{
    [DbContext(typeof(VyukaContext))]
    partial class VyukaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_11_cv_.EFCore.Hodnoceni", b =>
                {
                    b.Property<int>("IdStudent")
                        .HasColumnType("int");

                    b.Property<string>("ZkratkaPredmet")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<short>("Znamka")
                        .HasColumnType("smallint");

                    b.HasKey("IdStudent", "ZkratkaPredmet");

                    b.ToTable("Hodnocenis");
                });

            modelBuilder.Entity("_11_cv_.EFCore.Predmet", b =>
                {
                    b.Property<string>("PredmetId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nazev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PredmetId");

                    b.ToTable("Predmets");
                });

            modelBuilder.Entity("_11_cv_.EFCore.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime>("DatumNarozeni")
                        .HasColumnType("datetime2");

                    b.Property<string>("Jmeno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prijmeni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("_11_cv_.EFCore.StudentPredmet", b =>
                {
                    b.Property<int>("IdStudent")
                        .HasColumnType("int");

                    b.Property<string>("ZkratkaPredmet")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdStudent", "ZkratkaPredmet");

                    b.ToTable("StudentPredmets");
                });
#pragma warning restore 612, 618
        }
    }
}