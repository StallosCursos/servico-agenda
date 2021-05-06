using System.Collections.Generic;
using System.Linq;
using AgendaServico.InfraEstrutura.Context;
using AgendaServico.InfraEstrutura.Repositories.Interfaces;
using AgendaServico.Modelo;

namespace AgendaServico.InfraEstrutura.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(IAgendaContext agendaContext) : base(agendaContext)
        {
        }

        public void AdicionarCategoria(Categoria categoria) =>
            AgendaContext.Categoria.Add(categoria);

        public void AtualizarCategoria(Categoria categoria)
        {
            ValidarChaveInformada(categoria);
            AgendaContext.Categoria.Update(categoria);
        }

        public void RemoverCategoria(Categoria categoria)
        {
            ValidarChaveInformada(categoria);
            AgendaContext.Categoria.Remove(categoria);
        }

        public List<Categoria> BuscarCategorias() =>
            AgendaContext.Categoria.ToList();
    }
}
