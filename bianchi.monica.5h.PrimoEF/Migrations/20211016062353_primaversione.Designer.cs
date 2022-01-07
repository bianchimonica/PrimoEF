﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bianchi.monica._5h.PrimoEF.Models;

namespace bianchi.monica._5h.PrimoEF.Migrations
{
    [DbContext(typeof(DbPersone))]
    [Migration("20211016062353_primaversione")]
    partial class primaversione
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("bianchi.monica._5h.PrimoEF.Models.Persona", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cognome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Persone");
                });
#pragma warning restore 612, 618
        }
    }
}