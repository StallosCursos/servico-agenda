using AgendaServico.Modelo;
using System.Collections.Generic;

namespace AgendaServico.InfraEstrutura.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        void AdicionarCategoria(Categoria categoria);
        void AtualizarCategoria(Categoria categoria);
        List<Categoria> BuscarCategorias();
        void RemoverCategoria(Categoria categoria);
    }
}