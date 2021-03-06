﻿// <auto-generated />
using Capillum.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Capillum.Migrations
{
    [DbContext(typeof(CapillumContext))]
    [Migration("20191119224217_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1");

            modelBuilder.Entity("Capillum.Models.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecoMedio")
                        .HasColumnType("TEXT");

                    b.Property<int>("TempoMedio")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Servico");
                });
#pragma warning restore 612, 618
        }
    }
}
