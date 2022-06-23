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
    [Migration("20220623201804_sw4")]
    partial class sw4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.Core.Wallet.Entities.Balance", b =>
                {
                    b.Property<int>("BalanceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BalanceID"), 1L, 1);

                    b.Property<string>("balance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BalanceID");

                    b.ToTable("Balance");
                });

            modelBuilder.Entity("API.Core.Wallet.Entities.MoneyCurrency", b =>
                {
                    b.Property<int>("MoneyCurrencyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MoneyCurrencyID"), 1L, 1);

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

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

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

                    b.Property<int>("BalanceID")
                        .HasColumnType("int");

                    b.Property<int>("MoneyCurrencyID")
                        .HasColumnType("int");

                    b.HasKey("AccountID");

                    b.HasIndex("BalanceID");

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
                    b.HasOne("API.Core.Wallet.Entities.Balance", "balance")
                        .WithMany()
                        .HasForeignKey("BalanceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Core.Wallet.Entities.MoneyCurrency", "moneycurrency")
                        .WithMany()
                        .HasForeignKey("MoneyCurrencyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("balance");

                    b.Navigation("moneycurrency");
                });
#pragma warning restore 612, 618
        }
    }
}
