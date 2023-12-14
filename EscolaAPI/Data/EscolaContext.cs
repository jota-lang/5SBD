using EscolaAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EscolaAPI.Data
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Professor> Professores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Turma>().HasNoKey();
            modelBuilder.Entity<Turma>()
                .HasOne(t => t.Disciplina)
                .WithMany()
                .HasForeignKey(t => t.IDdisciplina);

            modelBuilder.Entity<Turma>()
                .HasOne(t => t.Professor)
                .WithMany()
                .HasForeignKey(t => t.IDprofessor);
        }
    }
}
