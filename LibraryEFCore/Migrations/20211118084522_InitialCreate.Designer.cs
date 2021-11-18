﻿// <auto-generated />
using LibraryEFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryEFCore.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211118084522_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AuthorsBooks", b =>
                {
                    b.Property<int>("AuthorsID")
                        .HasColumnType("int");

                    b.Property<int>("BooksID")
                        .HasColumnType("int");

                    b.HasKey("AuthorsID", "BooksID");

                    b.HasIndex("BooksID");

                    b.ToTable("AuthorsBooks");
                });

            modelBuilder.Entity("LibraryEFCore.Authors", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfBirth")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("LibraryEFCore.Books", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("AuthorsBooks", b =>
                {
                    b.HasOne("LibraryEFCore.Authors", null)
                        .WithMany()
                        .HasForeignKey("AuthorsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryEFCore.Books", null)
                        .WithMany()
                        .HasForeignKey("BooksID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
