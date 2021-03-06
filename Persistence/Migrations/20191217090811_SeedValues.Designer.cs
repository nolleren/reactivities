﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191217090811_SeedValues")]
    partial class SeedValues
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Domain.Value", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = new Guid("35441fe6-36c7-497b-987b-e64e86b9dd24"),
                            Name = "Value 101"
                        },
                        new
                        {
                            Id = new Guid("56999560-f91b-4dc1-9302-9145750d34e1"),
                            Name = "Value 102"
                        },
                        new
                        {
                            Id = new Guid("7631503c-3575-47f5-8dda-b8b8ff8b0e3b"),
                            Name = "Value 103"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
