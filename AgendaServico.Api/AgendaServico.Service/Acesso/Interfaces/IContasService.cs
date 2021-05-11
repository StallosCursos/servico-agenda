using AgendaServico.Modelo;

namespace AgendaServico.Service.Acesso.Interfaces
{
    public interface IContasService
    {
        Usuario NovaConta(Usuario usuario);
        Usuario BuscarUsuarioPorNome(string NomeUsuario);
    }
}