﻿// <auto-generated />
using System;
using Culturecubs.Microsite.DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Culturecubs.Microsite.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230715123339_Order-No")]
    partial class OrderNo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Culturecubs.Microsite.DataAccess.Models.CandidateRegistration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("canidate");
                });

            modelBuilder.Entity("Culturecubs.Microsite.DataAccess.Models.Contest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TenantContestId")
                        .HasColumnType("int");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TenantContestId");

                    b.ToTable("contest");
                });

            modelBuilder.Entity("Culturecubs.Microsite.DataAccess.Models.ContestTab", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ContestId")
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.ToTable("contest_tab");
                });

            modelBuilder.Entity("Culturecubs.Microsite.DataAccess.Models.TenantContest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("tenant_contest");
                });

            modelBuilder.Entity("Culturecubs.Microsite.DataAccess.Models.ThemeConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Background")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Error")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDark")
                        .HasColumnType("bit");

                    b.Property<string>("Primary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryDarken1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secondary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondaryDarken1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Success")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenantIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenatLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Warning")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("theme_configuration");
                });

            modelBuilder.Entity("Culturecubs.Microsite.DataAccess.Models.Contest", b =>
                {
                    b.HasOne("Culturecubs.Microsite.DataAccess.Models.TenantContest", null)
                        .WithMany("Contests")
                        .HasForeignKey("TenantContestId");
                });

            modelBuilder.Entity("Culturecubs.Microsite.DataAccess.Models.ContestTab", b =>
                {
                    b.HasOne("Culturecubs.Microsite.DataAccess.Models.Contest", null)
                        .WithMany("Tabs")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Culturecubs.Microsite.DataAccess.Models.Contest", b =>
                {
                    b.Navigation("Tabs");
                });

            modelBuilder.Entity("Culturecubs.Microsite.DataAccess.Models.TenantContest", b =>
                {
                    b.Navigation("Contests");
                });
#pragma warning restore 612, 618
        }
    }
}
