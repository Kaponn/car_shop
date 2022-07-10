﻿// <auto-generated />
using System;
using Ef.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ef.Database.Migrations
{
    [DbContext(typeof(CarLotContext))]
    [Migration("20211218153357_UpdateMigration2")]
    partial class UpdateMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ef.Database.Entities.Brand", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("Ef.Database.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CurrentPersonId")
                        .HasColumnType("int");

                    b.Property<int?>("ModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CurrentPersonId");

                    b.HasIndex("ModelId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Ef.Database.Entities.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandName");

                    b.ToTable("Model");
                });

            modelBuilder.Entity("Ef.Database.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Ef.Database.Entities.Car", b =>
                {
                    b.HasOne("Ef.Database.Entities.Person", "CurrentPerson")
                        .WithMany()
                        .HasForeignKey("CurrentPersonId");

                    b.HasOne("Ef.Database.Entities.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");

                    b.Navigation("CurrentPerson");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Ef.Database.Entities.Model", b =>
                {
                    b.HasOne("Ef.Database.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandName");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Ef.Database.Entities.Person", b =>
                {
                    b.HasOne("Ef.Database.Entities.Car", null)
                        .WithMany("Owner")
                        .HasForeignKey("CarId");
                });

            modelBuilder.Entity("Ef.Database.Entities.Car", b =>
                {
                    b.Navigation("Owner");
                });
#pragma warning restore 612, 618
        }
    }
}