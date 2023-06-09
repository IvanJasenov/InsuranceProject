﻿// <auto-generated />
using System;
using InsuraceProject.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Claims.Migrations
{
    [DbContext(typeof(AuditContext))]
    [Migration("20230607223950_CoverAuditDataSeed")]
    partial class CoverAuditDataSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InsuraceProject.API.DbEntities.ClaimAudit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("HttpRequestType")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("ClaimAudits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimId = "1",
                            Created = new DateTime(2023, 6, 7, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7690),
                            HttpRequestType = "Https"
                        },
                        new
                        {
                            Id = 2,
                            ClaimId = "2",
                            Created = new DateTime(2023, 5, 26, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7692),
                            HttpRequestType = "Https"
                        },
                        new
                        {
                            Id = 3,
                            ClaimId = "3",
                            Created = new DateTime(2023, 6, 5, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7697),
                            HttpRequestType = "Https"
                        },
                        new
                        {
                            Id = 4,
                            ClaimId = "4",
                            Created = new DateTime(2023, 6, 2, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7698),
                            HttpRequestType = "Https"
                        });
                });

            modelBuilder.Entity("InsuraceProject.API.DbEntities.CoverAudit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CoverId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("HttpRequestType")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("CoverAudits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CoverId = "1",
                            Created = new DateTime(2023, 6, 7, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7801),
                            HttpRequestType = "Https"
                        },
                        new
                        {
                            Id = 2,
                            CoverId = "2",
                            Created = new DateTime(2023, 6, 4, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7803),
                            HttpRequestType = "Https"
                        },
                        new
                        {
                            Id = 3,
                            CoverId = "3",
                            Created = new DateTime(2023, 5, 28, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7804),
                            HttpRequestType = "Https"
                        },
                        new
                        {
                            Id = 4,
                            CoverId = "4",
                            Created = new DateTime(2023, 6, 2, 22, 39, 50, 445, DateTimeKind.Utc).AddTicks(7805),
                            HttpRequestType = "Https"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
