using AgendaServico.InfraEstrutura.Repositories.Interfaces;
using System;

namespace AgendaServico.InfraEstrutura
{
    public interface IUnitOfWork: IDisposable
    {
        public IUsuarioRepository usuarioRepostiory { get; }
        public ICategoriaRepository categoriaRepository { get; }

        public void Commit();
    }
}
