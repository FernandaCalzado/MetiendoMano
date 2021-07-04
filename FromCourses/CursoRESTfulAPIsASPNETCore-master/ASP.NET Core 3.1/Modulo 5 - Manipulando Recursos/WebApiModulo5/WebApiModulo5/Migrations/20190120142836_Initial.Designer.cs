﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiModulo5.Contexts;

namespace WebApiModulo5.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190120142836_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiModulo5.Entities.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Identificacion");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Autores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FechaNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Felipe Gavilán"
                        },
                        new
                        {
                            Id = 2,
                            FechaNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Claudia Rodríguez"
                        });
                });

            modelBuilder.Entity("WebApiModulo5.Entities.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutorId");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("WebApiModulo5.Entities.Libro", b =>
                {
                    b.HasOne("WebApiModulo5.Entities.Autor", "Autor")
                        .WithMany("Books")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}