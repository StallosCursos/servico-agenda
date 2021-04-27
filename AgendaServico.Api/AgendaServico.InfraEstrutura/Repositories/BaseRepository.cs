using System;
using AgendaServico.InfraEstrutura.Context;
using AgendaServico.Modelo;

namespace AgendaServico.InfraEstrutura.Repositories
{
    public abstract class BaseRepository<TEntity> where TEntity : Entidade
    {
        protected readonly IAgendaContext AgendaContext;

        public BaseRepository(IAgendaContext agendaContext)
        {
            AgendaContext = agendaContext;
        }

        protected void ValidarChaveInformada(TEntity entity)
        {
            if (entity.Id == 0)
                throw new InvalidOperationException("Chave de usuario não informada para esta ação");
        }
    }
}
