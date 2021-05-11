using AgendaServico.Modelo;
using System.Collections.Generic;

namespace AgendaServico.Service.Persistencia.Interfaces
{
    public interface IContatoService
    {
        Contato AtualizarContato(string nomeUsuario, Contato contato);
        Contato NovoContato(string nomeUsuario, Contato contato);
        Contato RemoverContato(string nomeUsuario, Contato contato);
        List<Contato> BuscarContatos(string nomeUsuario);
    }
}