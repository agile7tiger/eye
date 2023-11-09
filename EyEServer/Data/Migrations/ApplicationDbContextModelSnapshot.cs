﻿// <auto-generated />
using System;
using EyEServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EyEServer.Migrations;

[DbContext(typeof(ApplicationDbContext))]
partial class ApplicationDbContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1")
            .HasAnnotation("Relational:MaxIdentifierLength", 128);

        SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

        modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.DeviceFlowCodes", b =>
            {
                b.Property<string>("UserCode")
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("ClientId")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<DateTime>("CreationTime")
                    .HasColumnType("datetime2");

                b.Property<string>("Data")
                    .IsRequired()
                    .HasMaxLength(50000)
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Description")
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("DeviceCode")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<DateTime?>("Expiration")
                    .IsRequired()
                    .HasColumnType("datetime2");

                b.Property<string>("SessionId")
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("SubjectId")
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.HasKey("UserCode");

                b.HasIndex("DeviceCode")
                    .IsUnique();

                b.HasIndex("Expiration");

                b.ToTable("DeviceCodes", (string)null);
            });

        modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.Key", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("Algorithm")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<DateTime>("Created")
                    .HasColumnType("datetime2");

                b.Property<string>("Data")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("DataProtected")
                    .HasColumnType("bit");

                b.Property<bool>("IsX509Certificate")
                    .HasColumnType("bit");

                b.Property<string>("Use")
                    .HasColumnType("nvarchar(450)");

                b.Property<int>("Version")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("Use");

                b.ToTable("Keys", (string)null);
            });

        modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.PersistedGrant", b =>
            {
                b.Property<string>("Key")
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("ClientId")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<DateTime?>("ConsumedTime")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("CreationTime")
                    .HasColumnType("datetime2");

                b.Property<string>("Data")
                    .IsRequired()
                    .HasMaxLength(50000)
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Description")
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<DateTime?>("Expiration")
                    .HasColumnType("datetime2");

                b.Property<string>("SessionId")
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("SubjectId")
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("Type")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.HasKey("Key");

                b.HasIndex("ConsumedTime");

                b.HasIndex("Expiration");

                b.HasIndex("SubjectId", "ClientId", "Type");

                b.HasIndex("SubjectId", "SessionId", "Type");

                b.ToTable("PersistedGrants", (string)null);
            });

        modelBuilder.Entity("Identity.Models.UserModel", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("int");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("bit");

                b.Property<bool>("LockoutEnabled")
                    .HasColumnType("bit");

                b.Property<DateTimeOffset?>("LockoutEnd")
                    .HasColumnType("datetimeoffset");

                b.Property<string>("NormalizedEmail")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<string>("NormalizedUserName")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<string>("PasswordHash")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("PhoneNumberConfirmed")
                    .HasColumnType("bit");

                b.Property<string>("RefreshToken")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("RefreshTokenExpiryTime")
                    .HasColumnType("datetime2");

                b.Property<string>("SecurityStamp")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("TwoFactorEnabled")
                    .HasColumnType("bit");

                b.Property<string>("UserName")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.HasKey("Id");

                b.HasIndex("NormalizedEmail")
                    .HasDatabaseName("EmailIndex");

                b.HasIndex("NormalizedUserName")
                    .IsUnique()
                    .HasDatabaseName("UserNameIndex")
                    .HasFilter("[NormalizedUserName] IS NOT NULL");

                b.ToTable("AspNetUsers", (string)null);
            });

        modelBuilder.Entity("MemoryLib.Models.Common.LinkModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnType("nvarchar(13)");

                b.Property<int>("FolderName")
                    .HasColumnType("int");

                b.Property<string>("ImageSource")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Link")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Links");

                b.HasDiscriminator<string>("Discriminator").HasValue("LinkModel");

                b.UseTphMappingStrategy();
            });

        modelBuilder.Entity("MemoryLib.Models.Common.TextModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("FolderName")
                    .HasColumnType("int");

                b.Property<bool>("IsEditing")
                    .HasColumnType("bit");

                b.Property<string>("Text")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Texts");
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<string>("NormalizedName")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.HasKey("Id");

                b.HasIndex("NormalizedName")
                    .IsUnique()
                    .HasDatabaseName("RoleNameIndex")
                    .HasFilter("[NormalizedName] IS NOT NULL");

                b.ToTable("AspNetRoles", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("ClaimType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("RoleId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.ToTable("AspNetRoleClaims", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("ClaimType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserClaims", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.Property<string>("LoginProvider")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("ProviderKey")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("ProviderDisplayName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("LoginProvider", "ProviderKey");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserLogins", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("RoleId")
                    .HasColumnType("nvarchar(450)");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("AspNetUserRoles", (string)null);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("LoginProvider")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("Name")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("Value")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("UserId", "LoginProvider", "Name");

                b.ToTable("AspNetUserTokens", (string)null);
            });

        modelBuilder.Entity("MemoryLib.Models.Review.AnimeModel", b =>
            {
                b.HasBaseType("MemoryLib.Models.Common.LinkModel");

                b.Property<DateTime>("AddingDate")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("datetime2");

                b.Property<string>("AniDbId")
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("AniDbRating")
                    .HasColumnType("float");

                b.Property<int>("AniDbVotes")
                    .HasColumnType("int");

                b.Property<string>("Comment")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Episodecount")
                    .HasColumnType("int");

                b.Property<string>("Information")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("MyRating")
                    .HasColumnType("float");

                b.Property<DateTime>("StartingDate")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("datetime2");

                b.Property<string>("Type")
                    .HasColumnType("nvarchar(max)");

                b.HasDiscriminator().HasValue("AnimeModel");
            });

        modelBuilder.Entity("MemoryLib.Models.Review.FilmModel", b =>
            {
                b.HasBaseType("MemoryLib.Models.Common.LinkModel");

                b.Property<DateTime>("AddingDate")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("datetime2");

                b.Property<string>("Comment")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Country")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Genre")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("IMDbId")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("IMDbRating")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("float");

                b.Property<int>("IMDbVotes")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("int");

                b.Property<string>("Information")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Runtime")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("int");

                b.Property<DateTime>("StartingDate")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("datetime2");

                b.HasDiscriminator().HasValue("FilmModel");
            });

        modelBuilder.Entity("MemoryLib.Models.Review.GameModel", b =>
            {
                b.HasBaseType("MemoryLib.Models.Common.LinkModel");

                b.Property<DateTime>("AddingDate")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("datetime2");

                b.Property<string>("Comment")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Country")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Genre")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("IMDbId")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("IMDbRating")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("float");

                b.Property<int>("IMDbVotes")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("int");

                b.Property<string>("Information")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Runtime")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("int");

                b.Property<DateTime>("StartingDate")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("datetime2");

                b.HasDiscriminator().HasValue("GameModel");
            });

        modelBuilder.Entity("MemoryLib.Models.Review.MusicModel", b =>
            {
                b.HasBaseType("MemoryLib.Models.Common.LinkModel");

                b.Property<DateTime>("AddingDate")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("datetime2");

                b.Property<string>("Comment")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("DiscogsId")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Information")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Sites")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("StartingDate")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("datetime2");

                b.Property<string>("YoutubePlaylist")
                    .HasColumnType("nvarchar(max)");

                b.HasDiscriminator().HasValue("MusicModel");
            });

        modelBuilder.Entity("MemoryLib.Models.Review.SerialModel", b =>
            {
                b.HasBaseType("MemoryLib.Models.Common.LinkModel");

                b.Property<DateTime>("AddingDate")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("datetime2");

                b.Property<string>("Comment")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Country")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Genre")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("IMDbId")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("IMDbRating")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("float");

                b.Property<int>("IMDbVotes")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("int");

                b.Property<string>("Information")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Runtime")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("int");

                b.Property<DateTime>("StartingDate")
                    .ValueGeneratedOnUpdateSometimes()
                    .HasColumnType("datetime2");

                b.Property<int>("TotalSeasons")
                    .HasColumnType("int");

                b.HasDiscriminator().HasValue("SerialModel");
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.HasOne("Identity.Models.UserModel", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.HasOne("Identity.Models.UserModel", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Identity.Models.UserModel", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.HasOne("Identity.Models.UserModel", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
    }
}
