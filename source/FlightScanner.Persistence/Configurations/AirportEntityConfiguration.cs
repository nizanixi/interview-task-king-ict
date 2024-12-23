﻿using FlightScanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightScanner.Persistence.Configurations;

public class AirportEntityConfiguration : IEntityTypeConfiguration<AirportEntity>
{
    public void Configure(EntityTypeBuilder<AirportEntity> builder)
    {
        builder.HasKey(e => e.IataCode);
        builder.Property(e => e.IataCode)
            .HasColumnName("IATA_Code");

        builder.Property(e => e.AirportName)
            .HasColumnName("Airport_Name");

        builder.Property(e => e.Location)
            .HasColumnName("Location");
    }
}
