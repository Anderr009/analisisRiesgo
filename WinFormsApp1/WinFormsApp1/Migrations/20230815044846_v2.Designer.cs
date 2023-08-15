﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp1;

#nullable disable

namespace WinFormsApp1.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230815044846_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("WinFormsApp1.Models.Agresion.Agresion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("valoration")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("agresion");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Extension.Extension", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("valoration")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("extension");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Funcion.Funcion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("valoration")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("funcion");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Profundidad.Profundidad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("valoration")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("profundidad");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Riesgo.Riesgo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("active")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("analist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("damage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("risk")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("riesgo");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Vulnerabilidad.Vulnerabilidad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("valoration")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("vuln");
                });
#pragma warning restore 612, 618
        }
    }
}
