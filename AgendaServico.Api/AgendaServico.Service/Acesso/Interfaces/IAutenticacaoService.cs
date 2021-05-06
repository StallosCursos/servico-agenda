using AgendaServico.Modelo;

namespace AgendaServico.Service.Acesso.Interfaces
{
    public interface IAutenticacaoService
    {
        string Login(Usuario usuario);
    }
}