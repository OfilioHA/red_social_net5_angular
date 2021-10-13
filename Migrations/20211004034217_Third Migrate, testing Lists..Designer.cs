﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practica_2.Models;

namespace Practica_2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211004034217_Third Migrate, testing Lists.")]
    partial class ThirdMigratetestingLists
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("Practica_2.Models.Address", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("geoId")
                        .HasColumnType("int");

                    b.Property<string>("street")
                        .HasColumnType("longtext");

                    b.Property<string>("suite")
                        .HasColumnType("longtext");

                    b.Property<string>("zipcode")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("geoId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Practica_2.Models.Geo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("lat")
                        .HasColumnType("longtext");

                    b.Property<string>("lng")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Geo");
                });

            modelBuilder.Entity("Practica_2.Models.PostModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("UserModelId")
                        .HasColumnType("int");

                    b.Property<string>("body")
                        .HasColumnType("longtext");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Practica_2.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("addressId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("addressId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Practica_2.Models.Address", b =>
                {
                    b.HasOne("Practica_2.Models.Geo", "geo")
                        .WithMany()
                        .HasForeignKey("geoId");

                    b.Navigation("geo");
                });

            modelBuilder.Entity("Practica_2.Models.PostModel", b =>
                {
                    b.HasOne("Practica_2.Models.UserModel", null)
                        .WithMany("PostsList")
                        .HasForeignKey("UserModelId");
                });

            modelBuilder.Entity("Practica_2.Models.UserModel", b =>
                {
                    b.HasOne("Practica_2.Models.Address", "address")
                        .WithMany()
                        .HasForeignKey("addressId");

                    b.Navigation("address");
                });

            modelBuilder.Entity("Practica_2.Models.UserModel", b =>
                {
                    b.Navigation("PostsList");
                });
#pragma warning restore 612, 618
        }
    }
}
