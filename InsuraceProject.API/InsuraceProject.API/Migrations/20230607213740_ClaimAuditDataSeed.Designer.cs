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
    [Migration("20230607213740_ClaimAuditDataSeed")]
    partial class ClaimAuditDataSeed
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
                            Created = new DateTime(2023, 6, 7, 21, 37, 40, 160, DateTimeKind.Utc).AddTicks(698),
                            HttpRequestType = "Https"
                        },
                        new
                        {
                            Id = 2,
                            ClaimId = "2",
                            Created = new DateTime(2023, 5, 26, 21, 37, 40, 160, DateTimeKind.Utc).AddTicks(702),
                            HttpRequestType = "Https"
                        },
                        new
                        {
                            Id = 3,
                            ClaimId = "3",
                            Created = new DateTime(2023, 6, 5, 21, 37, 40, 160, DateTimeKind.Utc).AddTicks(708),
                            HttpRequestType = "Https"
                        },
                        new
                        {
                            Id = 4,
                            ClaimId = "4",
                            Created = new DateTime(2023, 6, 2, 21, 37, 40, 160, DateTimeKind.Utc).AddTicks(710),
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("HttpRequestType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CoverAudits");
                });
#pragma warning restore 612, 618
        }
    }
}