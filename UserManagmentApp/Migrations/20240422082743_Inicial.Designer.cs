﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UserManagmentApp.Models;

#nullable disable

namespace UserManagmentApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240422082743_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UserManagmentApp.Models.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
