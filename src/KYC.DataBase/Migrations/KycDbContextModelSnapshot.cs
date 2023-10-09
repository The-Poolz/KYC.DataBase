﻿// <auto-generated />
using System;
using KYC.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KYC.DataBase.Migrations
{
    [DbContext(typeof(KycDbContext))]
    partial class KycDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KYC.DataBase.Models.User", b =>
                {
                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApprovedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlockPassID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InreviewDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("RecordId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubmitCount")
                        .HasColumnType("int");

                    b.Property<string>("WaitingDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid", "Status");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
