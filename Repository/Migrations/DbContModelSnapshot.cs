﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Models;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(DbCont))]
    partial class DbContModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Repository.Models.Ausleih", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AusleihDatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("BenutzerId")
                        .HasColumnType("int");

                    b.Property<int>("BuchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RückgabeDatum")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BenutzerId");

                    b.HasIndex("BuchId");

                    b.ToTable("Ausleihs", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nachname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Benutzer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Geburtsdatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nachname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Benutzer", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Buch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Erscheinungsjahr")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seite")
                        .HasColumnType("int");

                    b.Property<int>("VerlagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("VerlagId");

                    b.ToTable("Buches", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Verlag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ort")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Verlags", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Ausleih", b =>
                {
                    b.HasOne("Repository.Models.Benutzer", "Benutzer")
                        .WithMany()
                        .HasForeignKey("BenutzerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Models.Buch", "Buch")
                        .WithMany()
                        .HasForeignKey("BuchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Benutzer");

                    b.Navigation("Buch");
                });

            modelBuilder.Entity("Repository.Models.Buch", b =>
                {
                    b.HasOne("Repository.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Models.Verlag", "Verlag")
                        .WithMany()
                        .HasForeignKey("VerlagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Verlag");
                });
#pragma warning restore 612, 618
        }
    }
}
