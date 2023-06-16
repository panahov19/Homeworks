﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ORM.Data.Contexts;

#nullable disable

namespace ORM.Migrations
{
    [DbContext(typeof(CountryDbContext))]
    partial class CountryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ORM.Data.Model.Country", b =>
                {
                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<DateTime>("FoundationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GDP")
                        .HasColumnType("int");

                    b.Property<string>("GovernmentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.ToTable("Countries");
                });
#pragma warning restore 612, 618
        }
    }
}
