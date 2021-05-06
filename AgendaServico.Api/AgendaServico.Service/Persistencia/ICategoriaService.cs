using AgendaServico.Modelo;

namespace AgendaServico.Service.Persistencia
{
    public interface ICategoriaService
    {
        Categoria AtualizarCategoria(Categoria categoria);
        Categoria NovaCategoria(Categoria categoria);
    }
}