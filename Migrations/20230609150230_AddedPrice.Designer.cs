﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_Shop.Data;

#nullable disable

namespace Online_Shop.Migrations
{
    [DbContext(typeof(ClothesDbContext))]
    [Migration("20230609150230_AddedPrice")]
    partial class AddedPrice
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Online_Shop.Models.Pants", b =>
                {
                    b.Property<Guid>("PantsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Color")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Path")
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("PantsId");

                    b.ToTable("Pants");
                });

            modelBuilder.Entity("Online_Shop.Models.Shirt", b =>
                {
                    b.Property<Guid>("ShirtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Color")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Path")
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ShirtId");

                    b.ToTable("Shirts");
                });

            modelBuilder.Entity("Online_Shop.Models.Uniform", b =>
                {
                    b.Property<string>("SelectProductType")
                        .HasColumnType("varchar(255)");

                    b.Property<Guid>("PantsId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ShirtId")
                        .HasColumnType("char(36)");

                    b.HasKey("SelectProductType");

                    b.HasIndex("PantsId");

                    b.HasIndex("ShirtId");

                    b.ToTable("Uniforms");
                });

            modelBuilder.Entity("Online_Shop.Models.Uniform", b =>
                {
                    b.HasOne("Online_Shop.Models.Pants", "Pants")
                        .WithMany()
                        .HasForeignKey("PantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Shop.Models.Shirt", "Shirt")
                        .WithMany()
                        .HasForeignKey("ShirtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pants");

                    b.Navigation("Shirt");
                });
#pragma warning restore 612, 618
        }
    }
}
