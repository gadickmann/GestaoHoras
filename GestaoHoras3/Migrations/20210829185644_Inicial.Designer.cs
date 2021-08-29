﻿// <auto-generated />
using System;
using GestaoHoras3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestaoHoras3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210829185644_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("GestaoHoras3.Data.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdEquipePessoa")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Equipe");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdEquipePessoa = 1,
                            Titulo = "Equipe Guerreiros"
                        },
                        new
                        {
                            Id = 2,
                            IdEquipePessoa = 1,
                            Titulo = "Equipe Masters"
                        },
                        new
                        {
                            Id = 3,
                            IdEquipePessoa = 2,
                            Titulo = "Equipe Reserva"
                        });
                });

            modelBuilder.Entity("GestaoHoras3.Data.EquipePessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdEquipe")
                        .HasColumnType("int");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EquipePessoa");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdEquipe = 1,
                            IdPessoa = 1
                        },
                        new
                        {
                            Id = 2,
                            IdEquipe = 1,
                            IdPessoa = 2
                        },
                        new
                        {
                            Id = 3,
                            IdEquipe = 2,
                            IdPessoa = 2
                        });
                });

            modelBuilder.Entity("GestaoHoras3.Data.Lancamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("HoraFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("HoraInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int");

                    b.Property<int>("idProjeto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lancamento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Data = new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HoraFim = new DateTime(2021, 8, 27, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            HoraInicio = new DateTime(2021, 8, 27, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            IdPessoa = 1,
                            idProjeto = 1
                        },
                        new
                        {
                            Id = 2,
                            Data = new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HoraFim = new DateTime(2021, 8, 27, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            HoraInicio = new DateTime(2021, 8, 27, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            IdPessoa = 2,
                            idProjeto = 1
                        },
                        new
                        {
                            Id = 3,
                            Data = new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HoraFim = new DateTime(2021, 8, 27, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            HoraInicio = new DateTime(2021, 8, 27, 13, 30, 0, 0, DateTimeKind.Unspecified),
                            IdPessoa = 2,
                            idProjeto = 1
                        });
                });

            modelBuilder.Entity("GestaoHoras3.Data.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Jorge"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Carlos"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Maria"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Manoel"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Edson"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Joaquim"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Ana Paula"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Roberto"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Julia"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Carla"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "Amadeu"
                        });
                });

            modelBuilder.Entity("GestaoHoras3.Data.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Projetos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Pequenas manutenções"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Refatoração da rotina XPTO"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}