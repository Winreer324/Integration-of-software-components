﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pr7;

namespace Pr7.Migrations
{
    [DbContext(typeof(AutoContext))]
    [Migration("20190412075659_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("Pr7.Auto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Firma");

                    b.Property<string>("Model");

                    b.Property<string>("Number");

                    b.Property<double>("Price");

                    b.Property<double>("Speed");

                    b.HasKey("Id");

                    b.ToTable("Autos");
                });

            modelBuilder.Entity("Pr7.Body", b =>
                {
                    b.Property<int>("AutoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AutoId1");

                    b.Property<string>("BodyColor");

                    b.Property<double>("BodyWeight");

                    b.HasKey("AutoId");

                    b.HasIndex("AutoId1");

                    b.ToTable("Bodys");
                });

            modelBuilder.Entity("Pr7.Door", b =>
                {
                    b.Property<int>("AutoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AutoId1");

                    b.Property<string>("ColorDoor");

                    b.Property<double>("Price");

                    b.HasKey("AutoId");

                    b.HasIndex("AutoId1");

                    b.ToTable("Doors");
                });

            modelBuilder.Entity("Pr7.Engine", b =>
                {
                    b.Property<int>("AutoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AutoId1");

                    b.Property<int>("Id");

                    b.Property<double>("Power");

                    b.Property<double>("Volume");

                    b.HasKey("AutoId");

                    b.HasIndex("AutoId1");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("Pr7.Wheel", b =>
                {
                    b.Property<int>("AutoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AutoId1");

                    b.Property<int>("Diameter");

                    b.Property<int>("Id");

                    b.Property<double>("Price");

                    b.Property<string>("WheelManufacturer");

                    b.HasKey("AutoId");

                    b.HasIndex("AutoId1");

                    b.ToTable("Wheels");
                });

            modelBuilder.Entity("Pr7.Body", b =>
                {
                    b.HasOne("Pr7.Auto", "Auto")
                        .WithMany()
                        .HasForeignKey("AutoId1");
                });

            modelBuilder.Entity("Pr7.Door", b =>
                {
                    b.HasOne("Pr7.Auto", "Auto")
                        .WithMany()
                        .HasForeignKey("AutoId1");
                });

            modelBuilder.Entity("Pr7.Engine", b =>
                {
                    b.HasOne("Pr7.Auto", "Auto")
                        .WithMany()
                        .HasForeignKey("AutoId1");
                });

            modelBuilder.Entity("Pr7.Wheel", b =>
                {
                    b.HasOne("Pr7.Auto", "Auto")
                        .WithMany()
                        .HasForeignKey("AutoId1");
                });
#pragma warning restore 612, 618
        }
    }
}