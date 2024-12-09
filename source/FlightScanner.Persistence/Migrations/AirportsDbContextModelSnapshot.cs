﻿// <auto-generated />
using FlightScanner.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlightScanner.Persistence.Migrations
{
    [DbContext(typeof(AirportsDbContext))]
    partial class AirportsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("FlightScanner.Domain.Entities.AirportEntity", b =>
                {
                    b.Property<string>("IataCode")
                        .HasColumnType("TEXT")
                        .HasColumnName("IATA_Code");

                    b.Property<string>("AirportName")
                        .HasColumnType("TEXT")
                        .HasColumnName("Airport_Name");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT")
                        .HasColumnName("Location");

                    b.HasKey("IataCode");

                    b.ToTable("Airports");
                });
#pragma warning restore 612, 618
        }
    }
}