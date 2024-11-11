﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using practicemodel.Data;

#nullable disable

namespace practicemodel.Migrations
{
    [DbContext(typeof(ApplicationDb))]
    partial class ApplicationDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("practicemodel.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "asim@gmail.com",
                            Password = "asim123",
                            UserName = "Asim"
                        },
                        new
                        {
                            Id = 2,
                            Email = "mohsin@gmail.com",
                            Password = "mohsin123",
                            UserName = "Mohsin"
                        },
                        new
                        {
                            Id = 3,
                            Email = "ali@gmail.com",
                            Password = "ali123",
                            UserName = "Ali"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}