﻿// <auto-generated />
using System;
using API.Core.Wallet.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SharkWalletCripto.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220616002404_SW")]
    partial class SW
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.Core.Wallet.Entities.MoneyCurrency", b =>
                {
                    b.Property<int>("MoneyCurrencyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MoneyCurrencyID"), 1L, 1);

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<string>("moneyCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MoneyCurrencyID");

                    b.ToTable("MoneyCurrencies");
                });

            modelBuilder.Entity("API.Core.Wallet.Entities.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("AccountID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API.Core.Wallet.Entities.Wallets", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountID"), 1L, 1);

                    b.Property<double?>("Balance")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int>("MoneyCurrencyID")
                        .HasColumnType("int");

                    b.HasKey("AccountID");

                    b.HasIndex("MoneyCurrencyID");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("API.Core.Wallet.Entities.User", b =>
                {
                    b.HasOne("API.Core.Wallet.Entities.Wallets", "account")
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");
                });

            modelBuilder.Entity("API.Core.Wallet.Entities.Wallets", b =>
                {
                    b.HasOne("API.Core.Wallet.Entities.MoneyCurrency", "moneycurrency")
                        .WithMany()
                        .HasForeignKey("MoneyCurrencyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("moneycurrency");
                });
#pragma warning restore 612, 618
        }
    }
}
