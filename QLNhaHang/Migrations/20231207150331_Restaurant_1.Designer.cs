﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLNhaHang.Model;

#nullable disable

namespace QLNhaHang.Migrations
{
    [DbContext(typeof(RestaurantDB))]
    [Migration("20231207150331_Restaurant_1")]
    partial class Restaurant_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("QLNhaHang.Model.Bill", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("TableID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("TableID");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("QLNhaHang.Model.Bill_InFo", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Bill_ID")
                        .HasColumnType("INTEGER");

                    b.Property<long>("FoodID")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("FoodID1")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("FoodID");

                    b.HasIndex("FoodID1");

                    b.ToTable("Bill_InFo");
                });

            modelBuilder.Entity("QLNhaHang.Model.BookingTable", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("TEXT");

                    b.Property<long>("CustomerID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfPeople")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("TableID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("TableID");

                    b.ToTable("BookingTable");
                });

            modelBuilder.Entity("QLNhaHang.Model.Customer", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("QLNhaHang.Model.Food", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdditionalInFo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("QLNhaHang.Model.FoodCategory", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FoodType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("FoodCategory");
                });

            modelBuilder.Entity("QLNhaHang.Model.Table", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfSeat")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReservedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("TableNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Table");
                });

            modelBuilder.Entity("QLNhaHang.Model.Bill", b =>
                {
                    b.HasOne("QLNhaHang.Model.Table", "Table")
                        .WithMany("Bill")
                        .HasForeignKey("TableID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("QLNhaHang.Model.Bill_InFo", b =>
                {
                    b.HasOne("QLNhaHang.Model.Bill", "Bill")
                        .WithMany("Bill_InFo")
                        .HasForeignKey("FoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLNhaHang.Model.Food", "Food")
                        .WithMany("Bill_InFo")
                        .HasForeignKey("FoodID1");

                    b.Navigation("Bill");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("QLNhaHang.Model.BookingTable", b =>
                {
                    b.HasOne("QLNhaHang.Model.Customer", "Customer")
                        .WithMany("BookingTable")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLNhaHang.Model.Table", "Table")
                        .WithMany("BookingTable")
                        .HasForeignKey("TableID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("QLNhaHang.Model.Food", b =>
                {
                    b.HasOne("QLNhaHang.Model.FoodCategory", "FoodCategory")
                        .WithMany("Food")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodCategory");
                });

            modelBuilder.Entity("QLNhaHang.Model.Bill", b =>
                {
                    b.Navigation("Bill_InFo");
                });

            modelBuilder.Entity("QLNhaHang.Model.Customer", b =>
                {
                    b.Navigation("BookingTable");
                });

            modelBuilder.Entity("QLNhaHang.Model.Food", b =>
                {
                    b.Navigation("Bill_InFo");
                });

            modelBuilder.Entity("QLNhaHang.Model.FoodCategory", b =>
                {
                    b.Navigation("Food");
                });

            modelBuilder.Entity("QLNhaHang.Model.Table", b =>
                {
                    b.Navigation("Bill");

                    b.Navigation("BookingTable");
                });
#pragma warning restore 612, 618
        }
    }
}
