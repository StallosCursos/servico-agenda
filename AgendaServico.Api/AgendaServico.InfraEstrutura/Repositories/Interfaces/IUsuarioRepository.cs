using System;
using System.Collections.Generic;
using AgendaServico.Modelo;

namespace AgendaServico.InfraEstrutura.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        void AdicionarNovoUsuario(Usuario usuario);
        void AlterarUsuario(Usuario usuario);
        Usuario BuscarUsuarioId(int Id);
        Usuario BuscarUsuarioPorNome(string NomeUsuario);
        List<Usuario> BuscarUsuarios(Func<Usuario, bool> Predicate);
        void RemoverUsuario(Usuario usuario);
    }
}