using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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

        public override int SaveChanges()
        {
            var Entries = base.ChangeTracker.Entries().Where(t => t.State == EntityState.Added || t.State == EntityState.Modified);

            foreach (var Entry in Entries)
            {
                if (Entry.Entity is Entidade EntidadeInclusao && Entry.State == EntityState.Added)
                    EntidadeInclusao.DataInclusao = DateTime.Now;
                else if (Entry.Entity is Entidade EntidadeEdicao && Entry.State == EntityState.Modified)
                    EntidadeEdicao.DataAlteracao = DateTime.Now;
            }

            return base.SaveChanges();
        }
    }
}
