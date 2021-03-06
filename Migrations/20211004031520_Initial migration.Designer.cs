// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practica_2.Models;

namespace Practica_2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211004031520_Initial migration")]
    partial class Initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("Practica_2.Models.PostModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("body")
                        .HasColumnType("longtext");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
