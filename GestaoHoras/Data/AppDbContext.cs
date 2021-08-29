using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoHoras3.Data;

namespace GestaoHoras3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Projeto> Projetos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Pessoa
            modelBuilder.Entity<Pessoa>().Property(p => p.Nome).HasMaxLength(100);

            modelBuilder.Entity<Pessoa>()
                .HasData(
                    new Pessoa { Id = 1, Nome = "Jorge" },
                    new Pessoa { Id = 2, Nome = "Carlos" },
                    new Pessoa { Id = 3, Nome = "Maria" },
                    new Pessoa { Id = 4, Nome = "Manoel" },
                    new Pessoa { Id = 5, Nome = "Edson" },
                    new Pessoa { Id = 6, Nome = "Joaquim" },
                    new Pessoa { Id = 7, Nome = "Ana Paula" },
                    new Pessoa { Id = 8, Nome = "Roberto" },
                    new Pessoa { Id = 9, Nome = "Julia" },
                    new Pessoa { Id = 10, Nome = "Carla" },
                    new Pessoa { Id = 11, Nome = "Amadeu" }
                );


            //Projeto
            modelBuilder.Entity<Projeto>().Property(p => p.Nome).HasMaxLength(80);

            modelBuilder.Entity<Projeto>()
                .HasData(
                    new Projeto { Id = 1, Nome = "Pequenas manutenções" },
                    new Projeto { Id = 2, Nome = "Refatoração da rotina XPTO" }
                );


            //Lancamento
            modelBuilder.Entity<Lancamento>()
                .HasData(
                    new Lancamento { Id = 1, IdPessoa = 1, idProjeto = 1, Data = new DateTime(2021, 8, 27), HoraInicio = new DateTime(2021, 8, 27, 15, 30, 0), HoraFim = new DateTime(2021, 8, 27, 16, 30, 0) },
                    new Lancamento { Id = 2, IdPessoa = 2, idProjeto = 1, Data = new DateTime(2021, 8, 27), HoraInicio = new DateTime(2021, 8, 27, 8, 0, 0), HoraFim = new DateTime(2021, 8, 27, 12, 0, 0) },
                    new Lancamento { Id = 3, IdPessoa = 2, idProjeto = 1, Data = new DateTime(2021, 8, 27), HoraInicio = new DateTime(2021, 8, 27, 13, 30, 0), HoraFim = new DateTime(2021, 8, 27, 18, 0, 0) }
                );


            //Equipe
            modelBuilder.Entity<Equipe>()
                .HasData(
                    new Equipe { Id = 1, Titulo = "Equipe Guerreiros", IdEquipePessoa = 1 },
                    new Equipe { Id = 2, Titulo = "Equipe Masters", IdEquipePessoa = 1 },
                    new Equipe { Id = 3, Titulo = "Equipe Reserva", IdEquipePessoa = 2 }
                );

            //EquipePessoa
            modelBuilder.Entity<EquipePessoa>()
                .HasData(
                    new EquipePessoa { Id = 1, IdEquipe = 1, IdPessoa = 1 },
                    new EquipePessoa { Id = 2, IdEquipe = 1, IdPessoa = 2 },
                    new EquipePessoa { Id = 3, IdEquipe = 2, IdPessoa = 2 }
                );

        }

        public DbSet<GestaoHoras3.Data.Lancamento> Lancamento { get; set; }

    }
}
