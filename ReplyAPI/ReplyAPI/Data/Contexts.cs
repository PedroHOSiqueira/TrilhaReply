using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ReplyAPI.Models;

namespace ReplyAPI.Data;

public class Contexts : DbContext
    {
    public DbSet<Projetos> Projetos { get; set; }
    public DbSet<Equipe> Equipe { get; set; }
    public DbSet<Tarefas> Tarefas { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<UsuarioEquipe> UsuarioEquipe { get; set; }
    public string DbPath { get; }

    public Contexts(DbContextOptions<Contexts> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarefas>()
            .HasOne(e => e.Projetos)
            .WithMany(e => e.Tarefas)
            .HasForeignKey(e => e.ProjetosId)
            .IsRequired();

        modelBuilder.Entity<UsuarioEquipe>()
          .HasKey(ue => new { ue.UsuarioId, ue.EquipeId });

        modelBuilder.Entity<UsuarioEquipe>()
           .HasOne(e => e.Equipe)
           .WithMany(e => e.UsuarioEquipe)
           .HasForeignKey(e => e.EquipeId)
           .IsRequired();

        modelBuilder.Entity<UsuarioEquipe>()
           .HasOne(e => e.Usuario)
           .WithMany(e => e.UsuarioEquipe)
           .HasForeignKey(e => e.UsuarioId)
           .IsRequired();
    }
}

