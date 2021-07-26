﻿// <auto-generated />
using System;
using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalManagement.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20210723161756_UserRole")]
    partial class UserRole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalManagement.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedOn");

                    b.Property<string>("Emailid")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("PhoneNo")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("HospitalManagement.Models.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedOn");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("UserRole");
                });
#pragma warning restore 612, 618
        }
    }
}
