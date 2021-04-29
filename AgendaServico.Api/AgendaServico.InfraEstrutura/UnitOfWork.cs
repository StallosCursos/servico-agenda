using AgendaServico.InfraEstrutura.Context;
using AgendaServico.InfraEstrutura.Repositories;
using AgendaServico.InfraEstrutura.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaServico.InfraEstrutura
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IAgendaContext _agendaContext;

        public UnitOfWork(IAgendaContext agendaContext) =>
            _agendaContext = agendaContext;

        public IUsuarioRepository usuarioRepostiory => new UsuarioRepository(_agendaContext);

        public ICategoriaRepository categoriaRepository => new CategoriaRepository(_agendaContext);

        public void Commit()
        {
            _agendaContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _agendaContext.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
