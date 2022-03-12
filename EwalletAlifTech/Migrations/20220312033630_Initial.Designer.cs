﻿// <auto-generated />
using System;
using EwalletAlifTech.Modules.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EwalletAlifTech.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220312033630_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("EwalletAlifTech.Modules.Accounts.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AccountType")
                        .HasColumnType("int")
                        .HasColumnName("account_type");

                    b.Property<decimal>("Balance")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BalanceLimit")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("balance_limit");

                    b.Property<DateTime>("BalanceLimitUpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("balance_limit_updated_at");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasAlternateKey("Number");

                    b.HasIndex("UserId");

                    b.ToTable("accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1ca06b7b-13fa-5952-827b-2fef6e40d111"),
                            AccountType = 1,
                            Balance = 80000m,
                            BalanceLimit = 20000m,
                            BalanceLimitUpdatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 775, DateTimeKind.Local).AddTicks(9334),
                            CreatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 774, DateTimeKind.Local).AddTicks(7856),
                            IsActive = true,
                            Number = "20202000000000001",
                            UpdatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 774, DateTimeKind.Local).AddTicks(8476),
                            UserId = new Guid("1ca06b7b-13fa-5952-827b-2fef6e40d111")
                        },
                        new
                        {
                            Id = new Guid("1ca06b7b-13fa-5952-827b-2fef6e40d114"),
                            AccountType = 1,
                            Balance = 0m,
                            BalanceLimit = 10000m,
                            BalanceLimitUpdatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 775, DateTimeKind.Local).AddTicks(9414),
                            CreatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 775, DateTimeKind.Local).AddTicks(9406),
                            IsActive = true,
                            Number = "20202000000000002",
                            UpdatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 775, DateTimeKind.Local).AddTicks(9409),
                            UserId = new Guid("1ca06b7b-13fa-5952-827b-2fef6e40d112")
                        },
                        new
                        {
                            Id = new Guid("1ca06b7b-13fa-5952-827b-2fef6e40d115"),
                            AccountType = 1,
                            Balance = 10000m,
                            BalanceLimit = 90000m,
                            BalanceLimitUpdatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 775, DateTimeKind.Local).AddTicks(9435),
                            CreatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 775, DateTimeKind.Local).AddTicks(9421),
                            IsActive = true,
                            Number = "20202000000000003",
                            UpdatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 775, DateTimeKind.Local).AddTicks(9423),
                            UserId = new Guid("1ca06b7b-13fa-5952-827b-2fef6e40d113")
                        });
                });

            modelBuilder.Entity("EwalletAlifTech.Modules.Settings.Entities.Setting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("settings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1ca06b7b-13fa-5952-827b-2fef6e40d121"),
                            CreatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 786, DateTimeKind.Local).AddTicks(5534),
                            Key = "NOT_IDENTIFIED_USER_MAX_BALANCE",
                            UpdatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 786, DateTimeKind.Local).AddTicks(6988),
                            Value = "10000"
                        },
                        new
                        {
                            Id = new Guid("1ca06b7b-13fa-5952-827b-2fef6e40d122"),
                            CreatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 786, DateTimeKind.Local).AddTicks(7703),
                            Key = "IDENTIFIED_USER_MAX_BALANCE",
                            UpdatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 786, DateTimeKind.Local).AddTicks(7713),
                            Value = "100000"
                        });
                });

            modelBuilder.Entity("EwalletAlifTech.Modules.Transactions.Entities.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("AccountBalance")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("account_balance");

                    b.Property<decimal>("Amount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("created_by_user_id");

                    b.Property<Guid>("FromAccountId")
                        .HasColumnType("char(36)")
                        .HasColumnName("from_account_id");

                    b.Property<Guid>("ToAccountId")
                        .HasColumnType("char(36)")
                        .HasColumnName("to_account_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("FromAccountId");

                    b.HasIndex("ToAccountId");

                    b.ToTable("transactions");
                });

            modelBuilder.Entity("EwalletAlifTech.Modules.Users.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AttestationId")
                        .HasColumnType("char(36)")
                        .HasColumnName("attestation_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("full_name");

                    b.Property<string>("Hash")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_active");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("phone_number");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Email");

                    b.HasAlternateKey("PhoneNumber");

                    b.HasAlternateKey("UserName");

                    b.HasIndex("AttestationId");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1ca06b7b-13fa-5952-827b-2fef6e40d111"),
                            AttestationId = new Guid("5ee95dcb-a078-11e8-904b-b06ebfbfa235"),
                            CreatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 764, DateTimeKind.Local).AddTicks(9566),
                            Email = "user1@gmail.com",
                            FullName = "User1",
                            Hash = "",
                            IsActive = false,
                            Password = "user1",
                            PhoneNumber = "992938640102",
                            UpdatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 766, DateTimeKind.Local).AddTicks(4143),
                            UserName = "user1"
                        },
                        new
                        {
                            Id = new Guid("1ca06b7b-13fa-5952-827b-2fef6e40d112"),
                            AttestationId = new Guid("5ee95dcb-a078-11e8-904b-b06ebfbfa234"),
                            CreatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 766, DateTimeKind.Local).AddTicks(4909),
                            Email = "user2@gmail.com",
                            FullName = "User2",
                            Hash = "",
                            IsActive = false,
                            Password = "user2",
                            PhoneNumber = "992938640103",
                            UpdatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 766, DateTimeKind.Local).AddTicks(4920),
                            UserName = "user2"
                        },
                        new
                        {
                            Id = new Guid("1ca06b7b-13fa-5952-827b-2fef6e40d113"),
                            AttestationId = new Guid("5ee95dcb-a078-11e8-904b-b06ebfbfa235"),
                            CreatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 766, DateTimeKind.Local).AddTicks(4929),
                            Email = "user3@gmail.com",
                            FullName = "User3",
                            Hash = "",
                            IsActive = false,
                            Password = "user3",
                            PhoneNumber = "992938640104",
                            UpdatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 766, DateTimeKind.Local).AddTicks(4931),
                            UserName = "user3"
                        });
                });

            modelBuilder.Entity("EwalletAlifTech.Modules.Users.Modules.Attestations.Entities.Attestation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("attestations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5ee95dcb-a078-11e8-904b-b06ebfbfa234"),
                            Code = "NOT_IDENTIFIED",
                            CreatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 778, DateTimeKind.Local).AddTicks(3469),
                            Name = "Неидентифицированный",
                            UpdatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 778, DateTimeKind.Local).AddTicks(4160)
                        },
                        new
                        {
                            Id = new Guid("5ee95dcb-a078-11e8-904b-b06ebfbfa235"),
                            Code = "IDENTIFIED",
                            CreatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 778, DateTimeKind.Local).AddTicks(4918),
                            Name = "Идентифицированный",
                            UpdatedAt = new DateTime(2022, 3, 12, 8, 36, 29, 778, DateTimeKind.Local).AddTicks(4927)
                        });
                });

            modelBuilder.Entity("EwalletAlifTech.Modules.Accounts.Entities.Account", b =>
                {
                    b.HasOne("EwalletAlifTech.Modules.Users.Entities.User", "User")
                        .WithMany("Accounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EwalletAlifTech.Modules.Transactions.Entities.Transaction", b =>
                {
                    b.HasOne("EwalletAlifTech.Modules.Users.Entities.User", "CreatedByUser")
                        .WithMany("Transactions")
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EwalletAlifTech.Modules.Accounts.Entities.Account", "FromAccount")
                        .WithMany("FromAccountTransactions")
                        .HasForeignKey("FromAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EwalletAlifTech.Modules.Accounts.Entities.Account", "ToAccount")
                        .WithMany("ToAccountTransactions")
                        .HasForeignKey("ToAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedByUser");

                    b.Navigation("FromAccount");

                    b.Navigation("ToAccount");
                });

            modelBuilder.Entity("EwalletAlifTech.Modules.Users.Entities.User", b =>
                {
                    b.HasOne("EwalletAlifTech.Modules.Users.Modules.Attestations.Entities.Attestation", "Attestation")
                        .WithMany("Users")
                        .HasForeignKey("AttestationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attestation");
                });

            modelBuilder.Entity("EwalletAlifTech.Modules.Accounts.Entities.Account", b =>
                {
                    b.Navigation("FromAccountTransactions");

                    b.Navigation("ToAccountTransactions");
                });

            modelBuilder.Entity("EwalletAlifTech.Modules.Users.Entities.User", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("EwalletAlifTech.Modules.Users.Modules.Attestations.Entities.Attestation", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}