﻿// <auto-generated />
using System;
using CMSProjekt.dbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMSProjekt.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231217180607_adding elements dbsets")]
    partial class addingelementsdbsets
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("CMSProjekt.Models.Accounts", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Login");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("CMSProjekt.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("CMSProjekt.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("CMSProjekt.Models.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParentPageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(-1);

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Visible")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("CMSProjekt.Models.PageElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FileId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ImageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PageId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TableId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TextId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FileId");

                    b.HasIndex("ImageId");

                    b.HasIndex("PageId");

                    b.HasIndex("TableId");

                    b.HasIndex("TextId");

                    b.ToTable("PageElements");
                });

            modelBuilder.Entity("CMSProjekt.Models.Settings", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("CMSProjekt.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContentJSON")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("CMSProjekt.Models.Text", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsBold")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TextString")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Texts");
                });

            modelBuilder.Entity("CMSProjekt.Models.PageElement", b =>
                {
                    b.HasOne("CMSProjekt.Models.File", "File")
                        .WithMany()
                        .HasForeignKey("FileId");

                    b.HasOne("CMSProjekt.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.HasOne("CMSProjekt.Models.Page", "Page")
                        .WithMany("PageElements")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMSProjekt.Models.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId");

                    b.HasOne("CMSProjekt.Models.Text", "Text")
                        .WithMany()
                        .HasForeignKey("TextId");

                    b.Navigation("File");

                    b.Navigation("Image");

                    b.Navigation("Page");

                    b.Navigation("Table");

                    b.Navigation("Text");
                });

            modelBuilder.Entity("CMSProjekt.Models.Page", b =>
                {
                    b.Navigation("PageElements");
                });
#pragma warning restore 612, 618
        }
    }
}
