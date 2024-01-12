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
    [Migration("20231228111118_restaurant_8")]
    partial class restaurant_8
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("QLNhaHang.Model.Account", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserName");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("QLNhaHang.Model.Bill", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCheckIn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateCheckOut")
                        .HasColumnType("TEXT");

                    b.Property<int>("Discount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TableID")
                        .HasColumnType("INTEGER");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("REAL");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("TableID");

                    b.HasIndex("UserName");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("QLNhaHang.Model.Bill_InFo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Bill_ID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FoodID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("Bill_ID");

                    b.HasIndex("FoodID");

                    b.ToTable("Bill_InFo");
                });

            modelBuilder.Entity("QLNhaHang.Model.Food", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
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
                    b.Property<int>("ID")
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
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

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

                    b.HasOne("QLNhaHang.Model.Account", "Account")
                        .WithMany("Bill")
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("QLNhaHang.Model.Bill_InFo", b =>
                {
                    b.HasOne("QLNhaHang.Model.Bill", "Bill")
                        .WithMany("Bill_InFo")
                        .HasForeignKey("Bill_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLNhaHang.Model.Food", "Food")
                        .WithMany("Bill_InFo")
                        .HasForeignKey("FoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Food");
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

            modelBuilder.Entity("QLNhaHang.Model.Account", b =>
                {
                    b.Navigation("Bill");
                });

            modelBuilder.Entity("QLNhaHang.Model.Bill", b =>
                {
                    b.Navigation("Bill_InFo");
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
                });
#pragma warning restore 612, 618
        }
    }
}
