﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShefainCoreWebApp.DAL;

#nullable disable

namespace ShefainCoreWebApp.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240715115514_sp")]
    partial class sp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShefainCoreWebApp.Core.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressLine1 = "mirpur",
                            AddressLine2 = "25",
                            City = "Dhaka",
                            Country = "RajakarDesh",
                            PersonId = 1,
                            State = "DK",
                            ZipCode = "1210"
                        },
                        new
                        {
                            Id = 2,
                            AddressLine1 = "mmpur",
                            AddressLine2 = "25",
                            City = "Dhaka",
                            Country = "RajakarDesh",
                            PersonId = 2,
                            State = "DK",
                            ZipCode = "1210"
                        },
                        new
                        {
                            Id = 3,
                            AddressLine1 = "Azimpur",
                            AddressLine2 = "25",
                            City = "Dhaka",
                            Country = "RajakarDesh",
                            PersonId = 2,
                            State = "DK",
                            ZipCode = "1210"
                        });
                });

            modelBuilder.Entity("ShefainCoreWebApp.Core.Entities.LookUp", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LookUpType")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.ToTable("LookUps");

                    b.HasData(
                        new
                        {
                            Code = "DK",
                            Description = "Dhaka",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "SDP",
                            Description = "Saidpur",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "GP",
                            Description = "Gazipur",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "BN",
                            Description = "Banani",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "NL",
                            Description = "nillphamari",
                            LookUpType = 0
                        });
                });

            modelBuilder.Entity("ShefainCoreWebApp.Core.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Persons", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "shefain@gmail.com",
                            FirstName = "Md",
                            LastName = "Shefain"
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "shohana@gmail.com",
                            FirstName = "Shohana",
                            LastName = "Howlader"
                        });
                });

            modelBuilder.Entity("ShefainCoreWebApp.Core.Entities.Address", b =>
                {
                    b.HasOne("ShefainCoreWebApp.Core.Entities.Person", "Person")
                        .WithMany("Addresses")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ShefainCoreWebApp.Core.Entities.Person", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
