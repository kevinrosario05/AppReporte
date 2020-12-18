﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial1_P3;

namespace Parcial1_P3.Migrations
{
    [DbContext(typeof(Datos))]
    partial class DatosModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Parcial1_P3.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Parcial1_P3.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Parcial1_P3.accidente", b =>
                {
                    b.Property<int>("accidenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("accidenteId1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("apellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("color")
                        .HasColumnType("TEXT");

                    b.Property<string>("descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("marca")
                        .HasColumnType("TEXT");

                    b.Property<string>("modelo")
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("placa")
                        .HasColumnType("TEXT");

                    b.HasKey("accidenteId");

                    b.HasIndex("accidenteId1");

                    b.ToTable("accidentes");
                });

            modelBuilder.Entity("Parcial1_P3.Post", b =>
                {
                    b.HasOne("Parcial1_P3.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Parcial1_P3.accidente", b =>
                {
                    b.HasOne("Parcial1_P3.accidente", null)
                        .WithMany("accidentes")
                        .HasForeignKey("accidenteId1");
                });
#pragma warning restore 612, 618
        }
    }
}
