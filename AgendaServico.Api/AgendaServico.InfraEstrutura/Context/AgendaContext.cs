using System;
using System.Diagnostics.CodeAnalysis;
using AgendaServico.Modelo;
using Microsoft.EntityFrameworkCore;

namespace AgendaServico.InfraEstrutura.Context
{
    public class AgendaContext : DbContext, IAgendaContext
    {
        public AgendaContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<NumeroContato> NumeroContato { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
