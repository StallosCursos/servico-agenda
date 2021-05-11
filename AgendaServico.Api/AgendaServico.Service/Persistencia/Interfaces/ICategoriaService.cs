using AgendaServico.Modelo;
using System.Collections.Generic;

namespace AgendaServico.Service.Persistencia.Interfaces
{
    public interface ICategoriaService
    {
        Categoria AtualizarCategoria(Categoria categoria);
        Categoria NovaCategoria(Categoria categoria);
        List<Categoria> Categorias();
        List<Categoria> CategoriasComecandoCom(string term);
    }
}