﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using okul_kayit;

#nullable disable

namespace okul_kayit.Migrations
{
    [DbContext(typeof(veritaban))]
    [Migration("20240213111039_bır")]
    partial class bır
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("okul_kayit.modelller.ogrenciler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("SınıfId")
                        .HasColumnType("int");

                    b.Property<string>("ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("okulno")
                        .HasColumnType("int");

                    b.Property<string>("soyad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SınıfId");

                    b.ToTable("ogrencilerr");
                });

            modelBuilder.Entity("okul_kayit.modelller.sinif", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("seviye")
                        .HasColumnType("int");

                    b.Property<string>("sube")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("siniflar");
                });

            modelBuilder.Entity("okul_kayit.modelller.ogrenciler", b =>
                {
                    b.HasOne("okul_kayit.modelller.sinif", "Sınıf")
                        .WithMany("ogenci")
                        .HasForeignKey("SınıfId");

                    b.Navigation("Sınıf");
                });

            modelBuilder.Entity("okul_kayit.modelller.sinif", b =>
                {
                    b.Navigation("ogenci");
                });
#pragma warning restore 612, 618
        }
    }
}
