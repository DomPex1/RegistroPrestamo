﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroPrestamo.DAL;

namespace RegistroPrestamo.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200926180119_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("RegistroPrestamo.Models.Personas", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("RegistroPrestamo.Models.PersonasDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("PersonasDetalle");
                });

            modelBuilder.Entity("RegistroPrestamo.Models.Prestamo", b =>
                {
                    b.Property<int>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Balance")
                        .HasColumnType("REAL");

                    b.Property<float>("Concepto")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<float>("Monto")
                        .HasColumnType("REAL");

                    b.HasKey("PrestamoId");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("RegistroPrestamo.Models.PrestamoDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PrestamoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PrestamoId");

                    b.ToTable("PrestamoDetalle");
                });

            modelBuilder.Entity("RegistroPrestamo.Models.PersonasDetalle", b =>
                {
                    b.HasOne("RegistroPrestamo.Models.Personas", null)
                        .WithMany("PersonasDetalle")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegistroPrestamo.Models.PrestamoDetalle", b =>
                {
                    b.HasOne("RegistroPrestamo.Models.Prestamo", null)
                        .WithMany("PrestamoDetalle")
                        .HasForeignKey("PrestamoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}