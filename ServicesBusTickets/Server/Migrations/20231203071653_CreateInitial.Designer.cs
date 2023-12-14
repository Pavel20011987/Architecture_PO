﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServicesBusTickets.Server.Data;

#nullable disable

namespace ServicesBusTickets.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231203071653_CreateInitial")]
    partial class CreateInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ServicesBusTickets.Shared.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DatePurchase")
                        .HasColumnType("datetime2");

                    b.Property<string>("FromStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ToStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatePurchase = new DateTime(2023, 12, 3, 18, 30, 10, 0, DateTimeKind.Unspecified),
                            FromStation = "Нижний-Новгород",
                            Price = 1200.40m,
                            ToStation = "Москва"
                        },
                        new
                        {
                            Id = 2,
                            DatePurchase = new DateTime(2023, 12, 2, 23, 30, 20, 0, DateTimeKind.Unspecified),
                            FromStation = "Москва",
                            Price = 1100.30m,
                            ToStation = "Нижний-Новгород"
                        },
                        new
                        {
                            Id = 3,
                            DatePurchase = new DateTime(2023, 12, 1, 13, 35, 30, 0, DateTimeKind.Unspecified),
                            FromStation = "Москва",
                            Price = 1690.10m,
                            ToStation = "Санкт-Петербург"
                        },
                        new
                        {
                            Id = 4,
                            DatePurchase = new DateTime(2023, 12, 4, 15, 45, 22, 0, DateTimeKind.Unspecified),
                            FromStation = "Санкт-Петербург",
                            Price = 1830.80m,
                            ToStation = "Москва"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
