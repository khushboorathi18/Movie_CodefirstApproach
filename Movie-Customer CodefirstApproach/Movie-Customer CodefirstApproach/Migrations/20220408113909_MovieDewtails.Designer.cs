﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movie_Customer_CodefirstApproach.Models;

namespace Movie_Customer_CodefirstApproach.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20220408113909_MovieDewtails")]
    partial class MovieDewtails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Movie_Customer_CodefirstApproach.Models.MovieDetails", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MovieCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("MovieDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MovieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MoviePrice")
                        .HasColumnType("int");

                    b.Property<string>("MovieType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("MovieDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
