﻿// <auto-generated />
using System;
using EFCORE.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCORE.DATA.Migrations
{
    [DbContext(typeof(FootballLeagueDBContext))]
    [Migration("20240124060709_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("EFCORE.DOMAIN.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("coaches");
                });

            modelBuilder.Entity("EFCORE.DOMAIN.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("teams");
                });
#pragma warning restore 612, 618
        }
    }
}
