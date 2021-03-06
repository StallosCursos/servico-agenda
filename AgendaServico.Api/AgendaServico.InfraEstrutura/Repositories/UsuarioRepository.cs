using System;
using System.Collections.Generic;
using System.Linq;
using AgendaServico.InfraEstrutura.Context;
using AgendaServico.InfraEstrutura.Repositories.Interfaces;
using AgendaServico.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace AgendaServico.InfraEstrutura.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IAgendaContext agendaContext) : base(agendaContext)
        {
        }

        private IIncludableQueryable<Usuario, Categoria> CarregarTodasRelacoes()
        {
            return this.AgendaContext.Usuario
                                     .Include(t => t.Contatos)
                                        .ThenInclude(t => t.NumerContato)
                                           .ThenInclude(t => t.Contato)
                                        .ThenInclude(t => t.NumerContato)
                                           .ThenInclude(t => t.Categoria);
        }

        public void AdicionarNovoUsuario(Usuario usuario) =>
            this.AgendaContext.Usuario.Add(usuario);

        public void AlterarUsuario(Usuario usuario)
        {
            this.ValidarChaveInformada(usuario);
            this.AgendaContext.Usuario.Update(usuario);
        }

        public void RemoverUsuario(Usuario usuario)
        {
            this.ValidarChaveInformada(usuario);
            this.AgendaContext.Usuario.Remove(usuario);
        }

        public Usuario BuscarUsuarioId(int Id) => 
            CarregarTodasRelacoes().FirstOrDefault(t => t.Id == Id);

        public Usuario BuscarUsuarioPorNome(string NomeUsuario) =>
            CarregarTodasRelacoes().FirstOrDefault(t => t.NomeUsuario == NomeUsuario);

        public List<Usuario> BuscarUsuarios(Func<Usuario, bool> Predicate) =>
            this.AgendaContext.Usuario.Where(Predicate).ToList();
    }
}
