﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoWEBMVC_CSharp_Nelio.Data;

namespace ProjetoWEBMVC_CSharp_Nelio.Migrations
{
    [DbContext(typeof(ProjetoWEBMVC_CSharp_NelioContext))]
    [Migration("20210728163540_DepartamentIdFK")]
    partial class DepartamentIdFK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("ProjetoWEBMVC_CSharp_Nelio.Models.Departament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Departament");
                });

            modelBuilder.Entity("ProjetoWEBMVC_CSharp_Nelio.Models.SalesRecords", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SellerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("ProjetoWEBMVC_CSharp_Nelio.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("BaseSalary")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartamentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("ProjetoWEBMVC_CSharp_Nelio.Models.SalesRecords", b =>
                {
                    b.HasOne("ProjetoWEBMVC_CSharp_Nelio.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerId");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("ProjetoWEBMVC_CSharp_Nelio.Models.Seller", b =>
                {
                    b.HasOne("ProjetoWEBMVC_CSharp_Nelio.Models.Departament", "Departament")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departament");
                });

            modelBuilder.Entity("ProjetoWEBMVC_CSharp_Nelio.Models.Departament", b =>
                {
                    b.Navigation("Sellers");
                });

            modelBuilder.Entity("ProjetoWEBMVC_CSharp_Nelio.Models.Seller", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
