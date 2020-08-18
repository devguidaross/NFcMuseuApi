﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MuseuApi.Db;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MuseuApi.Migrations
{
    [DbContext(typeof(MuseuContext))]
    [Migration("20200812205638_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MuseuApi.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataCadastro");

                    b.Property<string>("Descricao");

                    b.Property<string>("DistribuicaoGeografica");

                    b.Property<string>("Familia");

                    b.Property<string>("Habitat");

                    b.Property<string>("HabitosAlimentares");

                    b.Property<string>("Nome");

                    b.Property<string>("Ordem");

                    b.Property<string>("PeriodoDeVida");

                    b.Property<string>("Reproducao");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("MuseuApi.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
