﻿// <auto-generated />
using CMSProjekt.dbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMSProjekt.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240105102258_modified Account table name")]
    partial class modifiedAccounttablename
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("CMSProjekt.Models.Account", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Login");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("CMSProjekt.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("ElementId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ElementId")
                        .IsUnique();

                    b.ToTable("Files");
                });

            modelBuilder.Entity("CMSProjekt.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("ElementId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ElementId")
                        .IsUnique();

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

                    b.Property<int>("OrderNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.ToTable("PageElements");
                });

            modelBuilder.Entity("CMSProjekt.Models.Settings", b =>
                {
                    b.Property<string>("Name")
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("");

                    b.Property<string>("ContentJSON")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ElementId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ElementId")
                        .IsUnique();

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

                    b.Property<int>("ElementId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsBold")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TextString")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ElementId")
                        .IsUnique();

                    b.ToTable("Texts");
                });

            modelBuilder.Entity("CMSProjekt.Models.File", b =>
                {
                    b.HasOne("CMSProjekt.Models.PageElement", "Element")
                        .WithOne("File")
                        .HasForeignKey("CMSProjekt.Models.File", "ElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Element");
                });

            modelBuilder.Entity("CMSProjekt.Models.Image", b =>
                {
                    b.HasOne("CMSProjekt.Models.PageElement", "Element")
                        .WithOne("Image")
                        .HasForeignKey("CMSProjekt.Models.Image", "ElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Element");
                });

            modelBuilder.Entity("CMSProjekt.Models.PageElement", b =>
                {
                    b.HasOne("CMSProjekt.Models.Page", "Page")
                        .WithMany("PageElements")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Page");
                });

            modelBuilder.Entity("CMSProjekt.Models.Table", b =>
                {
                    b.HasOne("CMSProjekt.Models.PageElement", "Element")
                        .WithOne("Table")
                        .HasForeignKey("CMSProjekt.Models.Table", "ElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Element");
                });

            modelBuilder.Entity("CMSProjekt.Models.Text", b =>
                {
                    b.HasOne("CMSProjekt.Models.PageElement", "Element")
                        .WithOne("Text")
                        .HasForeignKey("CMSProjekt.Models.Text", "ElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Element");
                });

            modelBuilder.Entity("CMSProjekt.Models.Page", b =>
                {
                    b.Navigation("PageElements");
                });

            modelBuilder.Entity("CMSProjekt.Models.PageElement", b =>
                {
                    b.Navigation("File");

                    b.Navigation("Image");

                    b.Navigation("Table");

                    b.Navigation("Text");
                });
#pragma warning restore 612, 618
        }
    }
}
