﻿// <auto-generated />
using System;
using Blog_informetion_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog_informetion_API.Migrations
{
    [DbContext(typeof(BlogInformationApiContext))]
    [Migration("20241212054048_Nuevocampo")]
    partial class Nuevocampo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog_informetion_API.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Autor")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Cuerpo")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Campo");

                    b.Property<DateOnly?>("FechaDePublicacion")
                        .HasColumnType("date")
                        .HasColumnName("Fecha_de_publicacion");

                    b.Property<string>("Titulo")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Url_images")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("Url_images");

                    b.HasKey("Id")
                        .HasName("PK__News__3214EC07FA2F815E");

                    b.HasIndex(new[] { "Titulo" }, "Titulo");

                    b.ToTable("News");
                });
#pragma warning restore 612, 618
        }
    }
}
